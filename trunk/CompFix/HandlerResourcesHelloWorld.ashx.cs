using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CompFix
{
    public class HandlerResourcesHelloWorld : IHttpHandler
    {
        public bool IsReusable
        {
            get { return false; }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            context.Response.Write("Hello world!");
        }
    }

}