﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DotNetCore.CAP;
using Syinpo.BusinessLogic.Content;
using Syinpo.BusinessLogic.Devices;
using Syinpo.Core.Caches;
using Syinpo.Core.Container;
using Syinpo.Core.Data;
using Syinpo.Core.Domain.Poco;
using Syinpo.Core.Hangfire;
using Syinpo.Core.Reflection;
using Syinpo.Model;
using Syinpo.Model.Core.Content;
using Microsoft.Extensions.Logging;

namespace Syinpo.BusinessLogic.Jobs {
    public class EventQueueJob : IBackgroundJob<NullJobArgs> {

        private readonly ILogger<EventQueueJob> _logger;
        private readonly ICache _cache;
        private readonly ICurrent _current;
        private readonly IDataContainer _dataContainer;
        private readonly ITypeFinder _typeFinder;
        private readonly ITypeResolve _typeResolve;
        private readonly IDeviceService _deviceService;
        private readonly IDbContext _dbContext;
        private readonly IEventQueueService _eventQueueService;
        private readonly ICapPublisher _capBus;

        private volatile bool _isRuning;
        private readonly object _lockObj = new object();

        #region 常量

        private const string CurrentDeviceId = "currentDeviceId";
        private const string TraceId = "traceId";
        private const string CapMsgName = "cap-msg-name";
        private const string CustomVersion = "customVersion";
        private const string ItemId = "ItemId";

        #endregion

        public EventQueueJob( ILogger<EventQueueJob> logger, ICache cache, ICurrent current, IDataContainer dataContainer, ITypeFinder typeFinder, ITypeResolve typeResolve, IDeviceService deviceService, IDbContext dbContext, IEventQueueService eventQueueService, ICapPublisher capPublisher ) {
            _logger = logger;
            _cache = cache;
            _current = current;
            _dataContainer = dataContainer;
            _typeFinder = typeFinder;
            _typeResolve = typeResolve;
            _deviceService = deviceService;
            _dbContext = dbContext;
            _eventQueueService = eventQueueService;
            _capBus = capPublisher;
        }

        public async Task Process( string route ) {
            try
            {
                var max = 3;
                var ques = await _eventQueueService.SearchEventQueues( routeName: route, onlyNoOut: true, maxRetry: max,
                    pageIndex: 0, pageSize: 300 );

                if( !ques.Any() )
                    return;

                foreach( var item in ques ) {
                    try {
                        item.OutTime = DateTime.Now;
                    }
                    catch( Exception exc ) {
                        item.Note = exc.ToString();
                    }
                    finally {
                        item.Retry = item.Retry + 1;
                    }
                }

                await _eventQueueService.UpdateRangeEventQueue( ques );
                await _capBus.PublishAsync( "/batch" + route , ques.ToList() );
            }
            catch( Exception ex ) {
                _logger.LogError( ex, $"EventQueueJob {route} Error." );
            }
        }


        public async Task Execute( NullJobArgs args ) {
            if( !_isRuning ) {
                _isRuning = true;

                try {
                    //await _cache.LockWith( "EventQueueJob", TimeSpan.FromSeconds( 30 ), async () =>
                    //    {

                    //    } );

                    await Process( "/api/device/callLog/create" );

                    await Process( "/api/device/sms/create" );

                    await Process( "/api/device/location/create" );

                    await Process( "/api/device/event/create" );

                    await Process( "/api/device/notification/write/state" );

                    await Process( "/api/device/contact/crud" );

                    await Process( "/api/device/wechat/db/upload" );

                    await Process( "/api/device/weixin/upload" );

                }
                catch( Exception ex ) {
                    _logger.LogError( "EventQueueJob Error : " + ex );
                }


                _isRuning = false;
            }

        }

    }

}
