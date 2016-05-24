using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaiCongModel;

namespace CaiCong.DAL
{
    public class HomeTableDAL
    {
        /// <summary>
        /// 添加一个HomeTable对象
        /// </summary>
        /// <param name="home">一个HomeTable对象</param>
        /// <returns>是否操作成功</returns>
        public bool Add(HomeTable home)
        {
            string sql = "INSERT INTO [dbo].[HomeTable] ([ThisKey] ,[ThisValue]) VALUES (@ThisKey ,@ThisValue)";
            SqlParameter[] sqlParameter =
            {
                new SqlParameter("@ThisKey", home.ThisKey),
                new SqlParameter("@ThisValue", home.ThisValue)
            };

            int num= SqlHelper.SqlHelper.ExecuteNonQuery(sql, CommandType.Text, sqlParameter);
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
        /// 删除一个HomeTable对象
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>是否操作成功</returns>
        public bool Del(int ID)
        {
            string sql = "DELETE FROM [dbo].[HomeTable] where ID=@ID";
            SqlParameter[] sqlParameter =
            {
                new SqlParameter("@ID",ID)
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
        /// <summary>
        /// 更改一个HomeTable对象
        /// </summary>
        /// <param name="home">一个HomeTable对象</param>
        /// <returns>是否操作成功</returns>
        public bool Updata(HomeTable home)
        {
            //判断是否哪个的值是不是为空，为空就不修改
            List<SqlParameter> sqlParameters=new List<SqlParameter>();
            List<String> stringsList=new List<String>();
            StringBuilder stringBuilder=new StringBuilder();
            stringBuilder.Append("UPDATE [dbo].[HomeTable] SET ");
            if (home.ThisKey!=null)
            {
                stringsList.Add(" [ThisKey] = @ThisKey ");
                sqlParameters.Add(new SqlParameter("@ThisKey", home.ThisKey));
            }else if (home.ThisValue!=null)
            {
                stringsList.Add(" [ThisValue] = @ThisValue ");
                sqlParameters.Add(new SqlParameter("@ThisValue", home.ThisValue));
            }
            string sql = "";
            string.Join(sql, stringsList, ",");
            sql = stringBuilder + sql + " WHERE ID=@ID";
            SqlParameter[] sps=new SqlParameter[sqlParameters.Count];
            sqlParameters.CopyTo(sps,0);
            
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
        /// 查询一个HomeTable对象,可以根据ID或ThisKey或ThisValue
        /// </summary>
        /// <param name="home">一个HomeTable对象</param>
        /// <returns>是否操作成功</returns>
        public List<HomeTable> Select(HomeTable home)
        {
            string sql = "SELECT [ID],[ThisKey],[ThisValue] FROM [dbo].[HomeTable] WHERE ";
            List<SqlParameter> sqlParameters=new List<SqlParameter>();

            //判断是根据ID或ThisKey或ThisValue查询
            if (home.ThisKey!=null)
            {
                sql += "ThisKey=@ThisKey";
                sqlParameters.Add(new SqlParameter("@ThisKey", home.ThisKey));
            }
            else if (home.ThisValue!=null)
            {
                sql += "ThisValue=@ThisValue";
                sqlParameters.Add(new SqlParameter("@ThisValue", home.ThisValue));
            }
            else if (home.ID >0)
            {
                sql += "ID=@ID";
                sqlParameters.Add(new SqlParameter("@ID", home.ID));
            }
            else
            {
                return new List<HomeTable>();
            }
            SqlParameter[] sqlParameter =new SqlParameter[sqlParameters.Count];
            sqlParameters.CopyTo(sqlParameter,0);
            SqlDataReader sdr = SqlHelper.SqlHelper.ExecuteReader(sql, CommandType.Text, sqlParameter);
            List<HomeTable> homeTables=new List<HomeTable>();
            
            while (sdr.Read())
            {
                HomeTable homgTable = new HomeTable();
                homgTable.ID = Convert.ToInt32(sdr["ID"]);
                homgTable.ThisKey = sdr["ID"].ToString();
                homgTable.ThisValue = sdr["ID"].ToString();
            }
            //若为空，返回的也是一个空的对象
            return homeTables;
        }
    }
}
