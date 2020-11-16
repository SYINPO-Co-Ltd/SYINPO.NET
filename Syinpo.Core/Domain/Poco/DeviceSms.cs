﻿using System;

namespace Syinpo.Core.Domain.Poco
{
    public partial class DeviceSms {
        /// <summary>
        /// 主键
        /// </summary>
        public int Id {
            get; set;
        }
        /// <summary>
        /// 设备主键
        /// </summary>
        public int DeviceId {
            get; set;
        }
        /// <summary>
        /// 从哪个号码
        /// </summary>
        public string FromPhone {
            get; set;
        }
        /// <summary>
        /// 到哪个号码
        /// </summary>
        public string ToPhone {
            get; set;
        }
        /// <summary>
        /// 是否发送，否则接收
        /// </summary>
        public bool Sent {
            get; set;
        }
        /// <summary>
        /// 短信内容
        /// </summary>
        public string Content {
            get; set;
        }
        /// <summary>
        /// 设备短信收到时间
        /// </summary>
        public DateTime SmsReceiveTime {
            get; set;
        }
        /// <summary>
        /// 设备短信创建时间
        /// </summary>
        public DateTime SmsCreateTime {
            get; set;
        }
        /// <summary>
        /// 创建时间
        /// </summary>
        public DateTime CreateTime {
            get; set;
        }
        /// <summary>
        /// 敏感词
        /// </summary>
        public string SensitiveWord {
            get; set;
        }

        public virtual Device Device {
            get; set;
        }
    }
}