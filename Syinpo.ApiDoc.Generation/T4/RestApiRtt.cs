﻿// ------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本: 16.0.0.0
//  
//     对此文件的更改可能导致不正确的行为，如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
// ------------------------------------------------------------------------------
namespace Syinpo.ApiDoc.Generation.T4
{
    using System.Linq;
    using System.Text;
    using System.Collections.Generic;
    using System;
    
    /// <summary>
    /// Class to produce the template output
    /// </summary>
    
    #line 1 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public partial class RestApiRtt : RestApiRttBase
    {
#line hidden
        /// <summary>
        /// Create the template output
        /// </summary>
        public virtual string TransformText()
        {
            this.Write("\r\n");
            this.Write("\r\n\r\n<span class=\"small pull-right mobile-hide\">\r\n  <a href=\"#\">改进这个文档</a>\r\n</span" +
                    ">\r\n\r\n\r\n<h1 class=\"text-capitalize\">");
            
            #line 15 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_data.Info.Name ?? ""));
            
            #line default
            #line hidden
            this.Write("</h1>\r\n\r\n<div class=\"markdown level1 description\">1.\t描述：");
            
            #line 17 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_data.Info.Description ?? ""));
            
            #line default
            #line hidden
            this.Write("</div>\r\n\r\n<div class=\"markdown level1 description\">2.\t接口类型：RestApi</div>\r\n\r\n<div " +
                    "class=\"markdown level1 description\">3. 安全认证：");
            
            #line 21 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_data.Info.Authentication));
            
            #line default
            #line hidden
            this.Write("</div>\r\n\r\n<h2 id=\"EnvironmentResources\">调用环境</h2>\r\n<table class=\"table table-bord" +
                    "ered table-striped table-condensed\">\r\n\t<thead>\r\n\t\t<tr>\r\n\t\t\t<th>操作</th>\r\n\t\t\t<th>H" +
                    "TTP方法</th>\r\n\t\t\t<th>请求URI</th>\r\n\t\t\t<th>环境</th>\r\n\t\t</tr>\r\n\t</thead>\r\n<tbody>\r\n");
            
            #line 34 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 foreach (var item in _data.EnvironmentResources) { 
            
            #line default
            #line hidden
            this.Write("\t\t<tr>\r\n\t\t<td>");
            
            #line 36 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_data.Info.OperationId));
            
            #line default
            #line hidden
            this.Write("</td>\r\n\t\t<td>");
            
            #line 37 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_data.Info.OperationName));
            
            #line default
            #line hidden
            this.Write("</td>\r\n\t\t<td>");
            
            #line 38 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.LoacalUrl));
            
            #line default
            #line hidden
            this.Write("</td>\r\n\t\t<td><font style=\"vertical-align: inherit;\"><font style=\"vertical-align: " +
                    "inherit;\">");
            
            #line 39 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Description));
            
            #line default
            #line hidden
            this.Write("</font></font></td>\r\n\t\t</tr>\r\n\t\t<tr>\r\n");
            
            #line 42 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 } 
            
            #line default
            #line hidden
            this.Write("</tbody>\r\n</table>\r\n\r\n\r\n");
            
            #line 47 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 if( _data.RequestPathParameters.Any() ) { 
            
            #line default
            #line hidden
            this.Write("\t<h2 id=\"RequestPathParameters\">RequestPath参数</h2>\r\n\t");
            
            #line 49 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 IterateThroughChildren( _data.RequestPathParameters, "路径名称" ); 
            
            #line default
            #line hidden
            
            #line 50 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 52 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 if( _data.RequestQueryParameters.Any() ) { 
            
            #line default
            #line hidden
            this.Write("\t<h2 id=\"RequestQueryParameters\">RequestQuery参数</h2>\r\n\t");
            
            #line 54 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 IterateThroughChildren( _data.RequestQueryParameters ); 
            
            #line default
            #line hidden
            
            #line 55 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n");
            
            #line 57 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 if( _data.RequestBodyParameters.Any() ) { 
            
            #line default
            #line hidden
            this.Write("\t<h2 id=\"RequestBodyParameters\">RequestBody参数</h2>\r\n\r\n\t### [参数文档](#tab/RequestBod" +
                    "yParameters-doc)\r\n\t\t");
            
            #line 61 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 IterateThroughChildren( _data.RequestBodyParameters ); 
            
            #line default
            #line hidden
            this.Write("\r\n\t");
            
            #line 63 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 if( _data.RequestBodyDefinition != null &&  _data.RequestBodyDefinition.SourceCode != null ) { 
            
            #line default
            #line hidden
            this.Write("\t\t### [参数源码](#tab/RequestBodyParameters-sourcecode)\r\n\t\t\t<span class=\"small\"><a hr" +
                    "ef=\"");
            
            #line 65 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_data.RequestBodyDefinition.SourceCode.ViewSource));
            
            #line default
            #line hidden
            this.Write("\" target=\"_blank\">查看完整源代码</a></span>\r\n\t\t\t[!code-csharp[](");
            
            #line 66 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_data.RequestBodyDefinition.SourceCode.Link));
            
            #line default
            #line hidden
            this.Write(")]\r\n\t");
            
            #line 67 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t---\r\n");
            
            #line 70 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n<h2 id=\"Response\">响应</h2>\r\n\r\n\t### [成功](#tab/Response-success)\r\n\t\t");
            
            #line 75 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 var okResponse =  _data.Responses.FirstOrDefault( f => f.StatusCode == "0" ); 
            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 76 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 if( okResponse != null ) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 77 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 IterateThroughChildren( okResponse.Parameters ); 
            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 78 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t### [失败](#tab/Response-fail)\r\n\t\t");
            
            #line 81 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 var failResponse =  _data.Responses.FirstOrDefault( f => f.StatusCode == "-1" ); 
            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 82 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 if( failResponse != null ) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t");
            
            #line 83 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 IterateThroughChildren( failResponse.Parameters ); 
            
            #line default
            #line hidden
            this.Write("\t\t");
            
            #line 84 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t### [错误码](#tab/Response-erros)\r\n\t\t<table class=\"table table-bordered table-str" +
                    "iped table-condensed\">\r\n\t\t\t<thead>\r\n\t\t\t\t<tr>\r\n\t\t\t\t\t<th>错误码</th>\r\n\t\t\t\t\t<th>错误信息</" +
                    "th>\r\n\t\t\t\t</tr>\r\n\t\t\t</thead>\r\n\t\t<tbody>\r\n\t\t");
            
            #line 95 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 foreach (var response in _data.Responses.Where(w => w.StatusCode != "0" )) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<tr>\r\n\t\t\t\t<td>");
            
            #line 97 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(response.StatusCode));
            
            #line default
            #line hidden
            this.Write("</td>\r\n\t\t\t\t<td>");
            
            #line 98 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(response.Description));
            
            #line default
            #line hidden
            this.Write("</td>\r\n\t\t\t\t</tr>\r\n\t\t\t\t<tr>\r\n\t\t");
            
            #line 101 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t</tbody>\r\n\t\t</table>\r\n\r\n\t---\r\n\r\n\t<h2 id=\"examples\">示例</h2>\r\n\t<h3 id=\"httpfilder" +
                    "\">");
            
            #line 108 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_data.Info.Name));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\r\n\t<h4>示例请求 HTTP/1.1</h4>\r\n\t<pre><code class=\"lang-http\">");
            
            #line 111 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_data.Info.OperationName));
            
            #line default
            #line hidden
            this.Write(" ");
            
            #line 111 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_data.EnvironmentResources.First().LoacalUrl));
            
            #line default
            #line hidden
            this.Write("\r\n\t</code></pre>\r\n\r\n\t");
            
            #line 114 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 if( !string.IsNullOrEmpty( _data.Example.RequestBodyJson ) ) { 
            
            #line default
            #line hidden
            this.Write("\t\t<h4>示例请求体 Content-Type: application/json</h4>\r\n\t\t<pre><code class=\"lang-json\">");
            
            #line 116 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_data.Example.RequestBodyJson));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t</code></pre>\r\n\t");
            
            #line 118 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\t<h4>示例响应 Http StatusCode: 200</h4>\r\n\t<pre><code class=\"lang-json\">");
            
            #line 121 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(_data.Example.ResponseJson));
            
            #line default
            #line hidden
            this.Write("\r\n\t</code></pre>\r\n\r\n");
            
            #line 124 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 if( _data.Definitions.Any() ) { 
            
            #line default
            #line hidden
            this.Write("\t<h2 id=\"Definition\">定义</h2>\r\n\t<table class=\"\"table table-bordered table-striped " +
                    "table-condensed\"\">\r\n\t<tbody>\r\n\t");
            
            #line 128 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 foreach (var item in _data.Definitions) { 
            
            #line default
            #line hidden
            this.Write("\t\t<tr>\r\n\t\t\t<td>\r\n\t\t\t\t<a href=\"#");
            
            #line 131 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Name));
            
            #line default
            #line hidden
            this.Write("\" data-linktype=\"self-bookmark\">");
            
            #line 131 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Name));
            
            #line default
            #line hidden
            this.Write("</a>\r\n\t\t\t</td>\r\n\t\t\t<td>");
            
            #line 133 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Description));
            
            #line default
            #line hidden
            this.Write("</td>\r\n\t\t\t<td><span class=\"small\">\r\n\t\t\t\t");
            
            #line 135 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 if( !string.IsNullOrEmpty( item.SourceCode.ViewSource ) ) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t<a href=\"");
            
            #line 136 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.SourceCode.ViewSource));
            
            #line default
            #line hidden
            this.Write("\" target=\"_blank\">查看源代码</a>\r\n\t\t\t\t");
            
            #line 137 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t</span>\r\n\t\t\t</td>\r\n\t\t</tr>\r\n\t");
            
            #line 141 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t</tbody>\r\n\t</table>\r\n\r\n\t");
            
            #line 145 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 foreach (var item in _data.Definitions) { 
            
            #line default
            #line hidden
            this.Write("\t\t<span class=\"small pull-right mobile-hide\">\r\n\t\t\t");
            
            #line 147 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 if( !string.IsNullOrEmpty( item.SourceCode.ViewSource ) ) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<a href=\"");
            
            #line 148 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.SourceCode.ViewSource));
            
            #line default
            #line hidden
            this.Write("\" target=\"_blank\">查看源代码</a>\r\n\t\t\t");
            
            #line 149 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t</span>\r\n\r\n\t\t<h3 id=\"");
            
            #line 152 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Name));
            
            #line default
            #line hidden
            this.Write("\">");
            
            #line 152 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Name));
            
            #line default
            #line hidden
            this.Write("</h3>\r\n\t\t<p>");
            
            #line 153 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(item.Description));
            
            #line default
            #line hidden
            this.Write("</p>\r\n\r\n\t\t<table class=\"table table-bordered table-striped table-condensed\">\r\n\t\t\t" +
                    "<thead>\r\n\t\t\t\t<tr>\r\n\t\t\t\t\t<th>名称</th>\r\n\t\t\t\t\t<th>类型</th>\r\n\t\t\t\t\t<th>描述</th>\r\n\t\t\t\t</t" +
                    "r>\r\n\t\t\t</thead>\r\n\t\t<tbody>\r\n\t\t");
            
            #line 164 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 foreach (var par in item.Parameters) { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t<tr>\r\n\t\t\t\t<td>");
            
            #line 166 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(par.Name));
            
            #line default
            #line hidden
            this.Write("</td>\r\n\t\t\t\t<td>\r\n\t\t\t\t\t");
            
            #line 168 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 if( par.IsDefinition ){ 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t<a href=\"#");
            
            #line 169 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(par.Ref));
            
            #line default
            #line hidden
            this.Write("\" data-linktype=\"self-bookmark\">");
            
            #line 169 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(par.DataType));
            
            #line default
            #line hidden
            this.Write("</a>\r\n\t\t\t\t\t");
            
            #line 170 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 } else { 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t\t\t");
            
            #line 171 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(par.DataType));
            
            #line default
            #line hidden
            this.Write("\r\n\t\t\t\t\t");
            
            #line 172 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t\t\t</td>\r\n\t\t\t\t<td>");
            
            #line 174 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
            this.Write(this.ToStringHelper.ToStringWithCulture(par.Description));
            
            #line default
            #line hidden
            this.Write("</td>\r\n\t\t\t\t</tr>\r\n\t\t\t\t<tr>\r\n\t\t");
            
            #line 177 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\t\t</tbody>\r\n\t\t</table>\r\n\t");
            
            #line 180 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 } 
            
            #line default
            #line hidden
            
            #line 181 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"
 } 
            
            #line default
            #line hidden
            this.Write("\r\n\r\n");
            return this.GenerationEnvironment.ToString();
        }
        
        #line 184 "C:\融智融力\github\Syinpo\Syinpo.ApiDoc.Generation\T4\RestApiRtt.tt"

    void IterateThroughChildren( List<Syinpo.ApiDoc.Generation.Model.AllModel.ParameterInfo> parameters, string modelName = null, int currentLevel = 0, int level = 1 )
    {
		this.WriteLine( @"<table class=""table table-bordered table-striped table-condensed"">
							<thead>
								<tr>
									<th>{0}</th>
									<th>数据类型</th>
									<th>默认值</th>
									<th>是否必填</th>
									<th>备注</th>
								</tr>
							</thead>
						<tbody>", modelName ?? "名称" );

		foreach ( var item in parameters ) {
			currentLevel++;

			this.WriteLine( @"<tr>");
			this.WriteLine( @"<td><span class=""parametername""><code>{0}</code></span></td>", item.Name );
			if( item.IsDefinition ){
				this.WriteLine( @"<td><a href=""#{0}"" data-linktype=""self-bookmark"">{1}</a></td>", item.Ref, item.DataType );
			}
			else{
				this.WriteLine( @"<td>{0}</td>", item.DataType );
			}
			this.WriteLine( @"<td>{0}</td>", item.DefaultValue );
			this.WriteLine( @"<td>{0}</td>", item.Required ? "*" : "" );
			this.WriteLine( @"<td>{0}</td>", item.Description );
			this.WriteLine( @"</tr>");

			if( item.IsDefinition && item.Definition.Parameters.Any() && currentLevel <= level ) {
				currentLevel++;

				this.WriteLine( @"<tr>");
				this.WriteLine( @"<td colspan=""5"">");
					IterateThroughChildren( item.Definition.Parameters, currentLevel:currentLevel, level:level);
				this.WriteLine( @"</td>");
				this.WriteLine( @"</tr>");
			}
		}

		this.WriteLine( @"</tbody></table>");
	}


        
        #line default
        #line hidden
    }
    
    #line default
    #line hidden
    #region Base class
    /// <summary>
    /// Base class for this transformation
    /// </summary>
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.VisualStudio.TextTemplating", "16.0.0.0")]
    public class RestApiRttBase
    {
        #region Fields
        private global::System.Text.StringBuilder generationEnvironmentField;
        private global::System.CodeDom.Compiler.CompilerErrorCollection errorsField;
        private global::System.Collections.Generic.List<int> indentLengthsField;
        private string currentIndentField = "";
        private bool endsWithNewline;
        private global::System.Collections.Generic.IDictionary<string, object> sessionField;
        #endregion
        #region Properties
        /// <summary>
        /// The string builder that generation-time code is using to assemble generated output
        /// </summary>
        protected System.Text.StringBuilder GenerationEnvironment
        {
            get
            {
                if ((this.generationEnvironmentField == null))
                {
                    this.generationEnvironmentField = new global::System.Text.StringBuilder();
                }
                return this.generationEnvironmentField;
            }
            set
            {
                this.generationEnvironmentField = value;
            }
        }
        /// <summary>
        /// The error collection for the generation process
        /// </summary>
        public System.CodeDom.Compiler.CompilerErrorCollection Errors
        {
            get
            {
                if ((this.errorsField == null))
                {
                    this.errorsField = new global::System.CodeDom.Compiler.CompilerErrorCollection();
                }
                return this.errorsField;
            }
        }
        /// <summary>
        /// A list of the lengths of each indent that was added with PushIndent
        /// </summary>
        private System.Collections.Generic.List<int> indentLengths
        {
            get
            {
                if ((this.indentLengthsField == null))
                {
                    this.indentLengthsField = new global::System.Collections.Generic.List<int>();
                }
                return this.indentLengthsField;
            }
        }
        /// <summary>
        /// Gets the current indent we use when adding lines to the output
        /// </summary>
        public string CurrentIndent
        {
            get
            {
                return this.currentIndentField;
            }
        }
        /// <summary>
        /// Current transformation session
        /// </summary>
        public virtual global::System.Collections.Generic.IDictionary<string, object> Session
        {
            get
            {
                return this.sessionField;
            }
            set
            {
                this.sessionField = value;
            }
        }
        #endregion
        #region Transform-time helpers
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void Write(string textToAppend)
        {
            if (string.IsNullOrEmpty(textToAppend))
            {
                return;
            }
            // If we're starting off, or if the previous text ended with a newline,
            // we have to append the current indent first.
            if (((this.GenerationEnvironment.Length == 0) 
                        || this.endsWithNewline))
            {
                this.GenerationEnvironment.Append(this.currentIndentField);
                this.endsWithNewline = false;
            }
            // Check if the current text ends with a newline
            if (textToAppend.EndsWith(global::System.Environment.NewLine, global::System.StringComparison.CurrentCulture))
            {
                this.endsWithNewline = true;
            }
            // This is an optimization. If the current indent is "", then we don't have to do any
            // of the more complex stuff further down.
            if ((this.currentIndentField.Length == 0))
            {
                this.GenerationEnvironment.Append(textToAppend);
                return;
            }
            // Everywhere there is a newline in the text, add an indent after it
            textToAppend = textToAppend.Replace(global::System.Environment.NewLine, (global::System.Environment.NewLine + this.currentIndentField));
            // If the text ends with a newline, then we should strip off the indent added at the very end
            // because the appropriate indent will be added when the next time Write() is called
            if (this.endsWithNewline)
            {
                this.GenerationEnvironment.Append(textToAppend, 0, (textToAppend.Length - this.currentIndentField.Length));
            }
            else
            {
                this.GenerationEnvironment.Append(textToAppend);
            }
        }
        /// <summary>
        /// Write text directly into the generated output
        /// </summary>
        public void WriteLine(string textToAppend)
        {
            this.Write(textToAppend);
            this.GenerationEnvironment.AppendLine();
            this.endsWithNewline = true;
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void Write(string format, params object[] args)
        {
            this.Write(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Write formatted text directly into the generated output
        /// </summary>
        public void WriteLine(string format, params object[] args)
        {
            this.WriteLine(string.Format(global::System.Globalization.CultureInfo.CurrentCulture, format, args));
        }
        /// <summary>
        /// Raise an error
        /// </summary>
        public void Error(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Raise a warning
        /// </summary>
        public void Warning(string message)
        {
            System.CodeDom.Compiler.CompilerError error = new global::System.CodeDom.Compiler.CompilerError();
            error.ErrorText = message;
            error.IsWarning = true;
            this.Errors.Add(error);
        }
        /// <summary>
        /// Increase the indent
        /// </summary>
        public void PushIndent(string indent)
        {
            if ((indent == null))
            {
                throw new global::System.ArgumentNullException("indent");
            }
            this.currentIndentField = (this.currentIndentField + indent);
            this.indentLengths.Add(indent.Length);
        }
        /// <summary>
        /// Remove the last indent that was added with PushIndent
        /// </summary>
        public string PopIndent()
        {
            string returnValue = "";
            if ((this.indentLengths.Count > 0))
            {
                int indentLength = this.indentLengths[(this.indentLengths.Count - 1)];
                this.indentLengths.RemoveAt((this.indentLengths.Count - 1));
                if ((indentLength > 0))
                {
                    returnValue = this.currentIndentField.Substring((this.currentIndentField.Length - indentLength));
                    this.currentIndentField = this.currentIndentField.Remove((this.currentIndentField.Length - indentLength));
                }
            }
            return returnValue;
        }
        /// <summary>
        /// Remove any indentation
        /// </summary>
        public void ClearIndent()
        {
            this.indentLengths.Clear();
            this.currentIndentField = "";
        }
        #endregion
        #region ToString Helpers
        /// <summary>
        /// Utility class to produce culture-oriented representation of an object as a string.
        /// </summary>
        public class ToStringInstanceHelper
        {
            private System.IFormatProvider formatProviderField  = global::System.Globalization.CultureInfo.InvariantCulture;
            /// <summary>
            /// Gets or sets format provider to be used by ToStringWithCulture method.
            /// </summary>
            public System.IFormatProvider FormatProvider
            {
                get
                {
                    return this.formatProviderField ;
                }
                set
                {
                    if ((value != null))
                    {
                        this.formatProviderField  = value;
                    }
                }
            }
            /// <summary>
            /// This is called from the compile/run appdomain to convert objects within an expression block to a string
            /// </summary>
            public string ToStringWithCulture(object objectToConvert)
            {
                if ((objectToConvert == null))
                {
                    throw new global::System.ArgumentNullException("objectToConvert");
                }
                System.Type t = objectToConvert.GetType();
                System.Reflection.MethodInfo method = t.GetMethod("ToString", new System.Type[] {
                            typeof(System.IFormatProvider)});
                if ((method == null))
                {
                    return objectToConvert.ToString();
                }
                else
                {
                    return ((string)(method.Invoke(objectToConvert, new object[] {
                                this.formatProviderField })));
                }
            }
        }
        private ToStringInstanceHelper toStringHelperField = new ToStringInstanceHelper();
        /// <summary>
        /// Helper to produce culture-oriented representation of an object as a string
        /// </summary>
        public ToStringInstanceHelper ToStringHelper
        {
            get
            {
                return this.toStringHelperField;
            }
        }
        #endregion
    }
    #endregion
}
