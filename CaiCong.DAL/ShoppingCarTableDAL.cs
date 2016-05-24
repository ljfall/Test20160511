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
	/// 数据访问类:ShoppingCarTable购物车表
	/// </summary>
	public partial class ShoppingCarTableDAL
	{
        /// <summary>
        /// 添加一件商品到购物车
        /// </summary>
        /// <param name="shoppingCar">shoppingCar对象</param>
        /// <returns>是否成功</returns>
	    public bool Add(ShoppingCarTable shoppingCar)
        {
            string sql = "INSERT INTO [dbo].[ShoppingCarTable]([UserID],[GoodsID],[GoodsNumber],[IsDel],[ThisTime])VALUES(@UserID,@GoodsID,@GoodsNumber,1,@ThisTime)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@UserID",shoppingCar.UserID), 
                new SqlParameter("@GoodsID",shoppingCar.GoodsID), 
                new SqlParameter("@GoodsNumber",shoppingCar.GoodsNumber), 
                new SqlParameter("@ThisTime",shoppingCar.ThisTime), 
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
        /// 删除一个购物车中的商品
        /// </summary>
        /// <param name="ID">购物车的ID</param>
        /// <returns>是否成功</returns>
	    public bool Del(int ID)
        {
            string sql = "UPDATE [dbo].[ShoppingCarTable] SET [IsDel] = 0 WHERE ID=@ID";
            SqlParameter sqlParameter=new SqlParameter("ID",ID);
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
        /// 更改一个商品的数量
        /// </summary>
        /// <param name="GoodsNumber">商品的数量</param>
        /// <param name="ID">购物车的ID</param>
        /// <returns>是否成功</returns>
	    public bool Update(int GoodsNumber,int ID)
	    {
            string sql = "UPDATE [dbo].[ShoppingCarTable] SET [GoodsNumber] = @GoodsNumber WHERE ID=@ID";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@ID", ID),
                new SqlParameter("@GoodsNumber", GoodsNumber)

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
        /// 根据用户ID 查询购物车中的商品
        /// </summary>
        /// <param name="UserID"></param>
        /// <returns></returns>
	    public List<ShoppingCarTable> SelectList(int UserID)
	    {
            List<ShoppingCarTable> list = new List<ShoppingCarTable>();
            string sql = "SELECT [ID],[UserID],[GoodsID],[GoodsNumber],[IsDel],[ThisTime] FROM [dbo].[ShoppingCarTable] where [UserID]=@UserID";
            SqlParameter sqlParameter=new SqlParameter("@UserID", UserID);
            SqlDataReader sdr = SqlHelper.SqlHelper.ExecuteReader(sql, CommandType.Text, sqlParameter);
            while (sdr.Read())
            {
               ShoppingCarTable shoppingCar=new ShoppingCarTable();
                shoppingCar.ID = Convert.ToInt32(sdr["ID"]);
                shoppingCar.GoodsID = Convert.ToInt32(sdr["GoodsID"]);
                shoppingCar.GoodsNumber = Convert.ToInt32(sdr["GoodsNumber"]);
                shoppingCar.UserID = Convert.ToInt32(sdr["UserID"]);
                shoppingCar.ThisTime = Convert.ToDateTime(sdr["ThisTime"]);
                list.Add(shoppingCar);
            }
	        return list;
	    } 
	}
}

