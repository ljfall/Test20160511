using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Test
{
    /// <summary>
    /// testzuoye 的摘要说明
    /// </summary>
    public class testzuoye : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            //数字加千分位
            //int num = 78789789;
            //List<string> list=new List<string>();
            //while (num>1000)
            //{
            //    list.Add((num%1000).ToString());
            //    num = num/1000;
            //}
            //list.Add(num.ToString());
            //list.Reverse(0, list.Count);
            //string string1 = string.Join(",", list);

            //输出1-999中能被3整除，而且至少有一位数字是5的所有数字，比如165、555、525。
            List<int> intlList = new List<int>();
            

            context.Response.Write("kajsdl");
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