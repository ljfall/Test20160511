using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CaiCongModel;
using CaiCong.BLL;

namespace CaiCongWeb.text
{
    /// <summary>
    /// HomeTable 的摘要说明
    /// </summary>
    public class HomeTable : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            SearchGoodsBLL searchGoods=new SearchGoodsBLL();
            //没有分页和全文检索，先不做
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