using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NVelocity2;

namespace Test.NVelocity
{
    /// <summary>
    /// Handler1 的摘要说明
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            NVelocityHelper nVelocity=new NVelocityHelper("Template");
            List<Book> books =new List<Book>();
            books.Add(new Book(1,"11","111"));
            books.Add(new Book(2,"22","222"));
            books.Add(new Book(3,"33","333"));
            books.Add(new Book(4,"44","444"));
            books.Add(new Book(5,"55","555"));
            books.Add(new Book(6,"66","666"));
            nVelocity.Put("date",books);
            nVelocity.Render("index.html");

            context.Response.Write("Hello World");
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