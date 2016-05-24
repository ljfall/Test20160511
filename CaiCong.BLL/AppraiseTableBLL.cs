using System;
using System.Data;
using System.Collections.Generic;
using CaiCong.DAL;
using CaiCongModel;
namespace CaiCong.BLL
{
	/// <summary>
	/// AppraiseTable
	/// </summary>
	public partial class AppraiseTableBLL
	{
        AppraiseTableDAL atDal=new AppraiseTableDAL();
        /// <summary>
        /// 添加一个评价
        /// </summary>
        /// <param name="appraise">评价对象</param>
        /// <returns>是否成功</returns>
        public bool Add(AppraiseTable appraise)
        {
            return atDal.Add(appraise);
        }
        /// <summary>
        /// 根据ID删除一个评价
        /// </summary>
        /// <param name="ID">评价ID</param>
        /// <returns>是否成功</returns>
	    public bool DelByID(int ID)
        {
            return atDal.DelByID(ID);
        }
        /// <summary>
        /// 根据评价人删除评价
        /// </summary>
        /// <param name="GoodsID">评价人ID</param>
        /// <returns>是否成功</returns>
	    public bool DelByUserID(int UserID)
        {
            return atDal.DelByUserID(UserID);
        }
        /// <summary>
        /// 根据商品ID删除评价
        /// </summary>
        /// <param name="GoodsID"></param>
        /// <returns>是否成功</returns>
	    public bool DelByGoodsID(int GoodsID)
        {
            return atDal.DelByGoodsID(GoodsID);
        }
        /// <summary>
        /// 根据ID查询评价
        /// </summary>
        /// <param name="ID">评价的ID</param>
        /// <returns>是否成功</returns>
	    public AppraiseTable SelectByID(int ID)
        {
            return atDal.SelectByID(ID);
        }
        /// <summary>
        /// 根据评价人ID查询评价
        /// </summary>
        /// <param name="UserID">评价人ID</param>
        /// <returns>评价</returns>
	    public List<AppraiseTable> SelectByUserID(int UserID)
        {
            return atDal.SelectByUserID(UserID);
        }
        /// <summary>
        /// 根据评价的商品ID查询评价
        /// </summary>
        /// <param name="GoodsID">评价的商品ID</param>
        /// <returns>评价对象的列表</returns>
	    public List<AppraiseTable> SelectByGoodsID(int GoodsID)
        {
            return atDal.SelectByGoodsID(GoodsID);
        }
        /// <summary>
        /// 多条件查询评价
        /// </summary>
        /// <param name="GoodsID">评价对象</param>
        /// <returns>评价对象的列表</returns>
	    public List<AppraiseTable> SelectByEveryOne(AppraiseTable appraise)
        {
            return atDal.SelectByEveryOne(appraise);
        }
    }
}

