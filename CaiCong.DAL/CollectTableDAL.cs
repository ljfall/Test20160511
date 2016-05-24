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
	/// 数据访问类:CollectTable收藏表
	/// </summary>
	public partial class CollectTableDAL
	{
        /// <summary>
        /// 添加一个收藏
        /// </summary>
        /// <param name="collect">收藏对象</param>
        /// <returns>是否成功</returns>
	    public bool Add(CollectTable collect)
        {
            string sql = "INSERT INTO [dbo].[CollectTable]([CollectUserID],[GoodsID],[CollectTime],[IsDel])VALUES(@CollectUserID,@GoodsID,@CollectTime,1)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@CollectUserID",collect.CollectUserID), 
                new SqlParameter("@GoodsID",collect.GoodsID), 
                new SqlParameter("@CollectTime",collect.CollectTime),  
            };
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
        /// 根据用户ID删除一个收藏
        /// </summary>
        /// <param name="CollectUserID"></param>
        /// <returns></returns>
	    public bool DelByUserID(int CollectUserID)
        {
            string sql = "UPDATE [dbo].[CollectTable] SET [IsDel] = 0 WHERE  CollectUserID=@CollectUserID";
            SqlParameter sqlParameters = new SqlParameter("@CollectUserID", CollectUserID);
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
        /// 根据商品ID删除一个收藏
        /// </summary>
        /// <param name="GoodsID"></param>
        /// <returns></returns>
	    public bool DelByGoodsID(int GoodsID)
        {
            string sql = "UPDATE [dbo].[CollectTable] SET [IsDel] = 0 WHERE  GoodsID=@GoodsID";
            SqlParameter sqlParameters = new SqlParameter("@CollectUserID", GoodsID);
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
        /// 查询一个收藏根据用户ID
        /// </summary>
        /// <param name="word">用户的ID</param>
        /// <returns>收藏</returns>
	    public List<CollectTable> Select(int UserID)
	    {
            List<CollectTable> list=new List<CollectTable>();
            string sql = "select * from [dbo].[CollectTable] where CollectUserID=@CollectUserID";
            SqlParameter sqlParameter=new SqlParameter("@CollectUserID", UserID);
            SqlDataReader sdr = SqlHelper.SqlHelper.ExecuteReader(sql, CommandType.Text, sqlParameter);
            while (sdr.Read())
            {
                CollectTable collect = new CollectTable();
                collect.ID = Convert.ToInt32(sdr["ID"]);
                collect.CollectUserID = Convert.ToInt32(sdr["CollectUserID"]);
                collect.GoodsID = Convert.ToInt32(sdr["GoodsID"]);
                collect.CollectTime = Convert.ToDateTime(sdr["ID"]);
                list.Add(collect);
            }

            return list;
	    }
        

	}
}

