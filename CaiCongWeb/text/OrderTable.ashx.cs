using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CaiCongWeb.text
{
    /// <summary>
    /// OrderTable 的摘要说明
    /// </summary>
    public class OrderTable : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            int OrderId= Convert.ToInt32(context.Request["ID"]);
            DateTime OrderTime = Convert.ToDateTime(context.Request["OrderTime"]) ;
            string ID = context.Request["ID"];
            string OrderSerial = context.Request["OrderSerial"];
            string GoodsID = context.Request["GoodsID"];
            string Price = context.Request["Price"];
            string GoodsNumber = context.Request["GoodsNumber"];
            string ReceivingManagementID = context.Request["ReceivingManagementID"];
            string OrderStateID = context.Request["OrderStateID"];
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