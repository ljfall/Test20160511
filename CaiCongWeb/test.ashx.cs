using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CaiCong.BLL;
using CaiCongModel;
using System.Web.Script.Serialization;

namespace CaiCongWeb
{
    /// <summary>
    /// test 的摘要说明
    /// </summary>
    partial class test : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            OrderTableBLL otBll = new OrderTableBLL();
            string use= context.Request["use"];
            if (use== "OrderAdd")
            {
                OrderTable order = new OrderTable();
                order.GoodsID = 23455;//商品ID
                order.GoodsNumber = 5;//购买个数
                order.OrderSerial = "3456789";//订单流水号
                order.OrderStateID = 1;//订单状态对应ID
                order.OrderTime=DateTime.Now;//订单时间
                order.Price = Convert.ToDecimal(33.5);//订单商品价格
                order.ReceivingManagementID = 2;//订单对应收货地址
                order.UserID = 345678;//订单对应收货地址
                List<OrderTable> orderList=new List<OrderTable>();
                orderList.Add(order);
                if (otBll.Add(orderList))
                {
                    context.Response.Write(1);   
                }
                else
                {
                    context.Response.Write(0);
                }
            }
            else if (use== "OrderDel")
            {
                
                BoolToInt(OrderDel(), context);
            }
            else if (use == "OrderSelect")
            {

                List<OrderTable> orderList = OrderSelect();
                XuLieHua(orderList, context);
            }
            else if (use == "ShopCarAdd")
            {

                BoolToInt(ShopCarAdd(), context);
            }
            else if (use == "ShopCarDel")
            {

                BoolToInt(ShopCarDel(), context);
            }
            else if (use == "ShopCarUpdate")
            {

                BoolToInt(ShopCarUpdate(), context);
            }
            else if (use == "ShopCarSelect")
            {
                
                XuLieHua(ShopCarSelect(), context);
            }
            else if (use == "CollectAdd")
            {

                BoolToInt(CollectAdd(), context);
            }
            else if (use == "CollectDelByGoodsId")
            {

                BoolToInt(CollectDelByGoodsId(), context);
            }
            else if (use == "CollectDelByGoodsId")
            {

                BoolToInt(CollectDelByGoodsId(), context);
            }
            else if (use == "CollectSelect")
            {

                XuLieHuaObj(CollectSelect(), context);
            }
            else if (use == "SensitiveWordAdd")
            {

                BoolToInt(SensitiveWordAdd(), context);
            }
            else if (use == "SensitiveWordDel")
            {

                BoolToInt(SensitiveWordDel(), context);
            }
            else if (use == "SensitiveWordSelecJZ")
            {

                BoolToInt(SensitiveWordSelecJZ(), context);
            }
            else if (use == "SensitiveWordSelectMH")
            {

                BoolToInt(SensitiveWordSelectMH(), context);
            }
            else if (use == "SensitiveWordSelectByDJ")
            {

                BoolToInt(SensitiveWordSelectByDJ(), context);
            }
            else if (use == "CouponAdd")
            {

                BoolToInt(CouponAdd(), context);
            }
            else if (use == "CouponDelByID")
            {

                BoolToInt(CouponDelByID(), context);
            }
            else if (use == "CouponDelByShopID")
            {

                BoolToInt(CouponDelByShopID(), context);
            }
            else if (use == "CouponDelByUserID")
            {

                BoolToInt(CouponDelByUserID(), context);
            }


            else if (use == "CouponSelectByShopId")
            {

                XuLieHua(CouponSelectByShopId(), context);
            }
            else if (use == "CouponSelectByUserId")
            {

                XuLieHua(CouponSelectByUserId(), context);
            }
            else if (use == "AppraiseAdd")
            {

                BoolToInt(AppraiseAdd(), context);
            }
            else if (use == "AppraiseDelByID")
            {

                BoolToInt(AppraiseDelByID(), context);
            }
            else if (use == "AppraiseDelByUserID")
            {

                BoolToInt(AppraiseDelByUserID(), context);
            }
            else if (use == "AppraiseDelByGoodsID")
            {

                BoolToInt(AppraiseDelByGoodsID(), context);
            }
            else if (use == "AppraiseSelectByID")
            {

                BoolToInt(AppraiseSelectByID(), context);
            }
            else if (use == "AppraiseSelectByUserID")
            {

                BoolToInt(AppraiseSelectByUserID(), context);
            }
            else if (use == "AppraiseSelectByGoodsID")
            {

                BoolToInt(AppraiseSelectByGoodsID(), context);
            }
            else if (use == "AppraiseSelectByAll")
            {

                BoolToInt(AppraiseSelectByAll(), context);
            }

            context.Response.Write(-1);
        }
        /// <summary>
        /// 非查询语句使用
        /// </summary>
        /// <param name="b">返回参数</param>
        /// <param name="context"></param>
        public void BoolToInt(bool b, HttpContext context)
        {
            if (b)
            {
                context.Response.Write(1);
            }
            else
            {
                context.Response.Write(0);
            }
        }

        public void XuLieHua<T>(List<T> objList, HttpContext context)
        {
            JavaScriptSerializer jss=new JavaScriptSerializer();
            string strings= jss.Serialize(objList);
            context.Response.Write(strings);
        }

        public void XuLieHuaObj(object obj, HttpContext context)
        {
            JavaScriptSerializer jss = new JavaScriptSerializer();
            string strings = jss.Serialize(obj);
            context.Response.Write(strings);
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