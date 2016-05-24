using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Common;
using CaiCongModel;

namespace CaiCong.DAL
{
	/// <summary>
	/// 数据访问类:OrderTable订单表
	/// </summary>
	public partial class OrderTableDAL
	{
        /// <summary>
        /// 添加一个订单，流水号一样
        /// </summary>
        /// <param name="orderTables">传过来的订单</param>
        /// <returns>是否操作成功</returns>
	    public bool Add(List<OrderTable> orderTables)
        {
            int num=0;
            foreach (OrderTable order in orderTables)
            {
                string sql =
                    "INSERT INTO [dbo].[OrderTable]([OrderTime],[OrderSerial],[GoodsID],[Price],[GoodsNumber],[ReceivingManagementID],[IsDel],[OrderStateID])VALUES(@OrderTime,@OrderSerial,@GoodsID,@Price,@GoodsNumber,@ReceivingManagementID,1,1)";
                SqlParameter[] sqlParameters =
                {
                    new SqlParameter("@OrderTime", order.OrderTime),
                    new SqlParameter("@OrderSerial", order.OrderSerial),
                    new SqlParameter("@GoodsID", order.GoodsID),
                    new SqlParameter("@Price", order.Price),
                    new SqlParameter("@GoodsNumber", order.GoodsNumber),
                    new SqlParameter("@ReceivingManagementID", order.ReceivingManagementID)
                };
                num = SqlHelper.SqlHelper.ExecuteNonQuery(sql, CommandType.Text, sqlParameters);
            }
            if (num > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
	    }
        /// <summary>
        /// 删除一个订单通过流水号
        /// </summary>
        /// <param name="orderSerial">订单流水号</param>
        /// <returns>是否成功</returns>
	    public bool Del(string orderSerial)
        {
            string sql = "UPDATE [dbo].[OrderTable] SET [IsDel] = 0 WHERE OrderSerial=@OrderSerial";
            SqlParameter sqlParameters=new SqlParameter("@orderSerial", orderSerial);

            int num = SqlHelper.SqlHelper.ExecuteNonQuery(sql, CommandType.Text, sqlParameters);
            if (num > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        /// <summary>
        /// 根据用户ID查询订单
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>订单结果数据</returns>
	    public List<OrderTable> SelectList(int UserID)
	    {
            List<OrderTable> list=new List<OrderTable>();
            string sql = "select * from OrderTable where UserID=@UserID";
            SqlParameter sqlParameters=new SqlParameter("@UserID", UserID);
            SqlDataReader sdr = SqlHelper.SqlHelper.ExecuteReader(sql, CommandType.Text, sqlParameters);
            while (sdr.Read())
            {
                OrderTable order = new OrderTable();
                order.ID = Convert.ToInt32(sdr["ID"]);
                order.GoodsID = Convert.ToInt32(sdr["GoodsID"]);
                order.GoodsNumber = Convert.ToInt32(sdr["GoodsNumber"]);
                order.OrderStateID = Convert.ToInt32(sdr["OrderStateID"]);
                order.ReceivingManagementID = Convert.ToInt32(sdr["ReceivingManagementID"]);
                order.OrderSerial = sdr["OrderSerial"].ToString();
                order.OrderTime = Convert.ToDateTime(sdr["OrderTime"]);
                order.Price = Convert.ToDecimal(sdr["Price"]);
                order.UserID = Convert.ToInt32(sdr["UserID"]);
                list.Add(order);
            }
            return list;
	    }
        
	}
}

