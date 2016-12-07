using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Sagittarius.WebServer
{
    /// <summary>
    /// UserInfo 的摘要说明
    /// </summary>
    public class UserInfo : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            string userid = context.Request.Params["id"].ToString();
            context.Response.ContentType = "text/plain";
            context.Response.Write(userid);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}