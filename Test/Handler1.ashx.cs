using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int? num = 11;
            string name = "";
            if (num > 0)
            {
                name = "askdfjgklj";
            }

            context.Response.Write(name);
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