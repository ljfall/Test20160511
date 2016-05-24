using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using CaiCongModel;
using Common;

namespace CaiCong.DAL
{
	/// <summary>
	/// 数据访问类:CouponTable优惠券表
	/// </summary>
	public partial class CouponTableDAL
	{
        /// <summary>
        /// 添加一个优惠券
        /// </summary>
        /// <param name="coupon">优惠券对象</param>
        /// <returns>是否成功</returns>
	    public bool Add(CouponTable coupon)
        {
            string sql = "INSERT INTO [dbo].[CouponTable]([UserID],[ShopID],[UseMoney],[Subduction],[GetTime],[OverTime],[IsDel])VALUES(@UserID,@ShopID,@UseMoney,@Subduction,@GetTime,@OverTime,1)";
            SqlParameter[] sqlParameter =
            {
                new SqlParameter("@UserID",coupon.UserID),
                new SqlParameter("@ShopID",coupon.ShopID),
                new SqlParameter("@UseMoney",coupon.UseMoney),
                new SqlParameter("@Subduction",coupon.Subduction),
                new SqlParameter("@GetTime",coupon.GetTime),
                new SqlParameter("@OverTime",coupon.OverTime)
            };
            int num = SqlHelper.SqlHelper.ExecuteNonQuery(sql, CommandType.Text, sqlParameter);
            if (num > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        //分页查询
        /// <summary>
        /// 根据用户ID 删除优惠券
        /// </summary>
        /// <param name="UserID">用户ID</param>
        /// <returns></returns>
	    public bool DelByUserID(int UserID)
        {
            string sql = "UPDATE [dbo].[CouponTable] SET [IsDel] = 0 where [UserID]=@UserID";
            SqlParameter sqlParameter=new SqlParameter("@UserID", UserID);
            int num = SqlHelper.SqlHelper.ExecuteNonQuery(sql, CommandType.Text, sqlParameter);
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
        /// 根据店铺ID 删除优惠券
        /// </summary>
        /// <param name="ShopID">店铺ID</param>
        /// <returns></returns>
	    public bool DelByShopID(int ShopID)
        {
            string sql = "UPDATE [dbo].[CouponTable] SET [IsDel] = 0 where [ShopID]=@ShopID";
            SqlParameter sqlParameter = new SqlParameter("@ShopID", ShopID);
            int num = SqlHelper.SqlHelper.ExecuteNonQuery(sql, CommandType.Text, sqlParameter);
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
        /// 根据过期时间 删除优惠券
        /// </summary>
        /// <param name="OverTime">过期时间</param>
        /// <returns></returns>
        public bool DelByUserTime(DateTime OverTime)
        {
            string sql = "UPDATE [dbo].[CouponTable] SET [IsDel] = 0 where [OverTime]>@OverTime";
            SqlParameter sqlParameter = new SqlParameter("@OverTime", OverTime);
            int num = SqlHelper.SqlHelper.ExecuteNonQuery(sql, CommandType.Text, sqlParameter);
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
        /// 根据ID 删除优惠券
        /// </summary>
        /// <param name="ID">用户ID</param>
        /// <returns></returns>
        public bool DelByID(int ID)
        {
            string sql = "UPDATE [dbo].[CouponTable] SET [IsDel] = 0 where [ID]=@ID";
            SqlParameter sqlParameter = new SqlParameter("@ID", ID);
            int num = SqlHelper.SqlHelper.ExecuteNonQuery(sql, CommandType.Text, sqlParameter);
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
        /// 根据用户ID查询优惠券
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
	    public List<CouponTable> SelectByUserIDList(int UserID)
	    {
            List<CouponTable> couponList=new List<CouponTable>();
            string sql = "SELECT [ID],[UserID],[ShopID],[UseMoney],[Subduction],[GetTime],[OverTime] FROM [dbo].[CouponTable] where [UserID]=@UserID";
            SqlParameter[] sqlParameters=
	        {
                new SqlParameter("@UserID",UserID), 
	        };
            SqlDataReader sdr = SqlHelper.SqlHelper.ExecuteReader(sql, CommandType.Text, sqlParameters);
            while (sdr.Read())
            {
                CouponTable coupon=new CouponTable();
                coupon.ShopID = Convert.ToInt32(sdr["ShopID"]);
                coupon.SubductionID = Convert.ToInt32(sdr["SubductionID"]);
                coupon.UserID = Convert.ToInt32(sdr["UserID"]);
                coupon.GetTime = Convert.ToDateTime(sdr["GetTime"]);
                coupon.OverTime = Convert.ToDateTime(sdr["OverTime"]);
                coupon.Subduction = Convert.ToDecimal(sdr["Subduction"]);
                coupon.UseMoney = Convert.ToDecimal(sdr["UseMoney"]);
                couponList.Add(coupon);
            }
            return couponList;

	    }
        /// <summary>
        /// 根据店铺ID查询优惠券
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
	    public List<CouponTable> SelectByShopIDList(int ShopID)
        {
            List<CouponTable> couponList = new List<CouponTable>();
            string sql = "SELECT [ID],[UserID],[ShopID],[UseMoney],[Subduction],[GetTime],[OverTime] FROM [dbo].[CouponTable] where [ShopID]=@ShopID";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@ShopID",ShopID),
            };
            SqlDataReader sdr = SqlHelper.SqlHelper.ExecuteReader(sql, CommandType.Text, sqlParameters);
            while (sdr.Read())
            {
                CouponTable coupon = new CouponTable();
                coupon.ShopID = Convert.ToInt32(sdr["ShopID"]);
                coupon.SubductionID = Convert.ToInt32(sdr["SubductionID"]);
                coupon.UserID = Convert.ToInt32(sdr["UserID"]);
                coupon.GetTime = Convert.ToDateTime(sdr["GetTime"]);
                coupon.OverTime = Convert.ToDateTime(sdr["OverTime"]);
                coupon.Subduction = Convert.ToDecimal(sdr["Subduction"]);
                coupon.UseMoney = Convert.ToDecimal(sdr["UseMoney"]);
                couponList.Add(coupon);
            }
            return couponList;

        }
    }
}

