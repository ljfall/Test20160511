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
	/// 评价表
	/// </summary>
	public partial class AppraiseTableDAL
	{
        /// <summary>
        /// 添加一个评价
        /// </summary>
        /// <param name="appraise">评价对象</param>
        /// <returns>是否成功</returns>
	    public bool Add(AppraiseTable appraise)
        {
            SqlParameter[] sps =
            {
                new SqlParameter("@Appraise", appraise.Appraise),
                new SqlParameter("@AppraiseGoodsID", appraise.AppraiseGoodsID),
                new SqlParameter("@AppraiseGenre", appraise.AppraiseGenre),
                new SqlParameter("@AppraiseTxt", appraise.AppraiseTxt),
            };
            string sql = "INSERT INTO [dbo].[AppraiseTable]([Appraise],[AppraiseGoodsID],[AppraiseGenre],[IsDel],[AppraiseTxt])VALUES(@Appraise,@AppraiseGoodsID,@AppraiseGenre,1,@AppraiseTxt)";
            int num= SqlHelper.SqlHelper.ExecuteNonQuery(sql, CommandType.Text, sps);
            if (num>0)
            {
                return true;
            }
            else
            {
	            return false;
            }
        }
        /// <summary>
        /// 根据ID删除一个评价
        /// </summary>
        /// <param name="ID">评价ID</param>
        /// <returns>是否成功</returns>
	    public bool DelByID(int ID)
	    {
            SqlParameter sps = new SqlParameter("@ID",ID);
            string sql = "UPDATE [dbo].[AppraiseTable] SET [IsDel] = 0 WHERE ID=@ID";
            int num = SqlHelper.SqlHelper.ExecuteNonQuery(sql, CommandType.Text, sps);
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
        /// 根据评价人删除评价
        /// </summary>
        /// <param name="GoodsID">评价人ID</param>
        /// <returns>是否成功</returns>
	    public bool DelByUserID(int UserID)
	    {
            SqlParameter sps = new SqlParameter("@Appraise", UserID);
            string sql = "UPDATE [dbo].[AppraiseTable] SET [IsDel] = 0 WHERE Appraise=@Appraise";
            int num = SqlHelper.SqlHelper.ExecuteNonQuery(sql, CommandType.Text, sps);
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
        /// 根据商品ID删除评价
        /// </summary>
        /// <param name="GoodsID"></param>
        /// <returns>是否成功</returns>
	    public bool DelByGoodsID(int GoodsID)
	    {
            SqlParameter sps = new SqlParameter("@AppraiseGoodsID", GoodsID);
            string sql = "UPDATE [dbo].[AppraiseTable] SET [IsDel] = 0 WHERE AppraiseGoodsID=@AppraiseGoodsID";
            int num = SqlHelper.SqlHelper.ExecuteNonQuery(sql, CommandType.Text, sps);
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
        /// 根据ID查询评价
        /// </summary>
        /// <param name="ID">评价的ID</param>
        /// <returns>是否成功</returns>
	    public AppraiseTable SelectByID(int ID)
	    {
            AppraiseTable appraise=new AppraiseTable();
            SqlParameter[] sps =
            {
                new SqlParameter("@ID",ID) 
            };
            string sql = "SELECT * FROM [dbo].[AppraiseTable] where ID=@ID";
            SqlDataReader sdr= SqlHelper.SqlHelper.ExecuteReader(sql, CommandType.Text, sps);
            if (sdr.Read())
            {
                appraise.ID = Convert.ToInt32(sdr["ID"]);
                appraise.Appraise = Convert.ToInt32(sdr["Appraise"]);
                appraise.AppraiseGenre = Convert.ToInt32(sdr["AppraiseGenre"]);
                appraise.AppraiseGoodsID = Convert.ToInt32(sdr["AppraiseGoodsID"]);
                appraise.AppraiseTxt = sdr["AppraiseTxt"].ToString();
            }
	        return appraise;
	    }
        /// <summary>
        /// 根据评价人ID查询评价
        /// </summary>
        /// <param name="UserID">评价人ID</param>
        /// <returns>评价</returns>
	    public List<AppraiseTable> SelectByUserID(int UserID)
	    {
            List<AppraiseTable> appraiseList=new List<AppraiseTable>();
            SqlParameter[] sps = {new SqlParameter("@Appraise", UserID),  };
            string sql = "SELECT * FROM [dbo].[AppraiseTable] where Appraise=@Appraise";
            SqlDataReader sdr = SqlHelper.SqlHelper.ExecuteReader(sql, CommandType.Text, sps);
            while (sdr.Read())
            {
                AppraiseTable appraise1 = new AppraiseTable();
                appraise1.ID = Convert.ToInt32(sdr["ID"]);
                appraise1.Appraise = Convert.ToInt32(sdr["Appraise"]);
                appraise1.AppraiseGenre = Convert.ToInt32(sdr["AppraiseGenre"]);
                appraise1.AppraiseGoodsID = Convert.ToInt32(sdr["AppraiseGoodsID"]);
                appraise1.AppraiseTxt = sdr["AppraiseTxt"].ToString();
                appraiseList.Add(appraise1);
            }
            return appraiseList;
	    }
        /// <summary>
        /// 根据评价的商品ID查询评价
        /// </summary>
        /// <param name="GoodsID">评价的商品ID</param>
        /// <returns>评价对象的列表</returns>
	    public List<AppraiseTable> SelectByGoodsID(int GoodsID)
	    {
            List<AppraiseTable> appraiseList =new List<AppraiseTable>();
            SqlParameter[] sps = { new SqlParameter("@AppraiseGoodsID", GoodsID), };
            string sql = "SELECT * FROM [dbo].[AppraiseTable] where AppraiseGoodsID=@AppraiseGoodsID";
            SqlDataReader sdr = SqlHelper.SqlHelper.ExecuteReader(sql, CommandType.Text, sps);
            while (sdr.Read())
            {
                AppraiseTable appraise1 = new AppraiseTable();
                appraise1.ID = Convert.ToInt32(sdr["ID"]);
                appraise1.Appraise = Convert.ToInt32(sdr["Appraise"]);
                appraise1.AppraiseGenre = Convert.ToInt32(sdr["AppraiseGenre"]);
                appraise1.AppraiseGoodsID = Convert.ToInt32(sdr["AppraiseGoodsID"]);
                appraise1.AppraiseTxt = sdr["AppraiseTxt"].ToString();
                appraiseList.Add(appraise1);

            }
            return appraiseList;
	    }
        /// <summary>
        /// 多条件查询评价
        /// </summary>
        /// <param name="GoodsID">评价对象</param>
        /// <returns>评价对象的列表</returns>
	    public List<AppraiseTable> SelectByEveryOne(AppraiseTable appraise)
        {
            List<AppraiseTable> appraiseList = new List<AppraiseTable>();
            SqlParameter[] sps = { };
            string sql = "SELECT * FROM [dbo].[AppraiseTable] where ";
            List<string> stringList=new List<string>();
            List<SqlParameter> spsList=new List<SqlParameter>();
            //多条件拼接
            if (appraise.ID>0)
            {
                stringList.Add("ID=@ID");
                spsList.Add(new SqlParameter("@ID", appraise.ID));
            }else if (appraise.Appraise>0)
            {
                stringList.Add("Appraise=@Appraise");
                spsList.Add(new SqlParameter("@Appraise", appraise.Appraise));
            }
            else if (appraise.AppraiseGenre > 0)
            {
                stringList.Add("AppraiseGenre=@AppraiseGenre");
                spsList.Add(new SqlParameter("@AppraiseGenre", appraise.AppraiseGenre));
            }
            else if (appraise.AppraiseGoodsID > 0)
            {
                stringList.Add("AppraiseGoodsID=@AppraiseGoodsID");
                spsList.Add(new SqlParameter("@AppraiseGoodsID", appraise.AppraiseGoodsID));
            }
            SqlParameter[] sqlParameters = {};
            spsList.CopyTo(sqlParameters,0);
            sql=sql+ string.Join(",", stringList);
            SqlDataReader sdr = SqlHelper.SqlHelper.ExecuteReader(sql, CommandType.Text, sps);
            while (sdr.Read())
            {
                AppraiseTable appraise1=new AppraiseTable();
                appraise1.ID = Convert.ToInt32(sdr["ID"]);
                appraise1.Appraise = Convert.ToInt32(sdr["Appraise"]);
                appraise1.AppraiseGenre = Convert.ToInt32(sdr["AppraiseGenre"]);
                appraise1.AppraiseGoodsID = Convert.ToInt32(sdr["AppraiseGoodsID"]);
                appraise1.AppraiseTxt = sdr["AppraiseTxt"].ToString();
                appraiseList.Add(appraise1);
            }
            return appraiseList;
        }

    }
}

