using System;
using System.Data;
using System.Collections.Generic;
using CaiCong.DAL;
using CaiCongModel;
namespace CaiCong.BLL
{
	/// <summary>
	/// CollectTable收藏表
	/// </summary>
	public partial class CollectTableBLL
	{
        CollectTableDAL ctBll=new CollectTableDAL();
        /// <summary>
        /// 添加一个收藏
        /// </summary>
        /// <param name="collect">收藏对象</param>
        /// <returns>是否成功</returns>
        public bool Add(CollectTable collect)
        {

            return ctBll.Add(collect);
        }
        /// <summary>
        /// 根据用户ID删除一个收藏
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
	    public bool DelByUserID(int CollectUserID)
        {
            return ctBll.DelByUserID(CollectUserID);
        }

	    /// <summary>
	    /// 根据商品ID删除一个收藏
	    /// </summary>
	    /// <param name="GoodsID"></param>
	    /// <returns></returns>
	    public bool DelByGoodsID(int GoodsID)
	    {
	        return ctBll.DelByGoodsID(GoodsID);
	    }

	    /// <summary>
	    /// 查询一个收藏根据用户ID
	    /// </summary>
	    /// <param name="word">用户的ID</param>
	    /// <returns>收藏</returns>
	    public List<CollectTable> Select(int UserID)
	    {
	        return ctBll.Select(UserID);
	    }


	}
}

