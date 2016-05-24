using System;
using System.Data;
using System.Collections.Generic;
using CaiCong.DAL;
using CaiCongModel;
namespace CaiCong.BLL
{
	/// <summary>
	/// OrderTable
	/// </summary>
	public partial class OrderTableBLL
	{
		OrderTableDAL otDal=new OrderTableDAL();

	    /// <summary>
	    /// 添加一个订单，流水号一样
	    /// </summary>
	    /// <param name="orderTables">传过来的订单</param>
	    /// <returns>是否操作成功</returns>
	    public bool Add(List<OrderTable> orderTables)
	    {
	        return otDal.Add(orderTables);
	    }
        /// <summary>
        /// 删除一个订单通过流水号
        /// </summary>
        /// <param name="orderSerial">订单流水号</param>
        /// <returns>是否成功</returns>
	    public bool Del(string orderSerial)
        {

            return otDal.Del(orderSerial);
        }
        /// <summary>
        /// 根据用户ID查询订单
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns>订单结果数据</returns>
	    public List<OrderTable> SelectList(int UserID)
        {
            return otDal.SelectList(UserID);
        }

    }
}

