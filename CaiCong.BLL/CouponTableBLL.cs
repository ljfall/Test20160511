using System;
using System.Data;
using System.Collections.Generic;
using CaiCong.DAL;
using CaiCongModel;
namespace CaiCong.BLL
{
	/// <summary>
	/// CouponTable
	/// </summary>
	public partial class CouponTableBLL
	{
		CouponTableDAL ctDal=new CouponTableDAL();

	    /// <summary>
	    /// 添加一个优惠券
	    /// </summary>
	    /// <param name="coupon">优惠券对象</param>
	    /// <returns>是否成功</returns>
	    public bool Add(CouponTable coupon)
	    {
	        return ctDal.Add(coupon);
	    }

	    /// <summary>
	    /// 根据用户ID 删除优惠券
	    /// </summary>
	    /// <param name="UserID">用户ID</param>
	    /// <returns></returns>
	    public bool DelByUserID(int UserID)
	    {
	        return ctDal.DelByUserID(UserID);
	    }

	    /// <summary>
	    /// 根据店铺ID 删除优惠券
	    /// </summary>
	    /// <param name="ShopID">店铺ID</param>
	    /// <returns></returns>
	    public bool DelByShopID(int ShopID)
	    {
	        return ctDal.DelByShopID(ShopID);
	    }

	    /// <summary>
	    /// 根据过期时间 删除优惠券
	    /// </summary>
	    /// <param name="OverTime">过期时间</param>
	    /// <returns></returns>
	    public bool DelByUserTime(DateTime OverTime)
	    {
	        return ctDal.DelByUserTime(OverTime);
	    }

	    /// <summary>
	    /// 根据ID 删除优惠券
	    /// </summary>
	    /// <param name="ID">用户ID</param>
	    /// <returns></returns>
	    public bool DelByID(int ID)
	    {
	        return ctDal.DelByID(ID);
	    }

	    /// <summary>
	    /// 根据用户ID查询优惠券
	    /// </summary>
	    /// <param name="UserID"></param>
	    /// <returns></returns>
	    public List<CouponTable> SelectByUserIDList(int UserID)
	    {
	        return ctDal.SelectByUserIDList(UserID);
	    }

	    /// <summary>
	    /// 根据店铺ID查询优惠券
	    /// </summary>
	    /// <param name="UserID"></param>
	    /// <returns></returns>
	    public List<CouponTable> SelectByShopIDList(int ShopID)
	    {
	        return ctDal.SelectByShopIDList(ShopID);
	    }

	}
}

