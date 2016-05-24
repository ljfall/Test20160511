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
	/// 数据访问类:UserTable用户表
	/// </summary>
	public partial class UserTableDAL
	{
        /// <summary>
        /// 检查是否存在用户名
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns>是否添加成功，大于1即是成功</returns>
	    public bool IsHaveUser(string UserName)
        {
            string sql = "select ID FROM UserTable where UserName=@UserName and IsDel=1";
            SqlParameter sqlParameter=new SqlParameter("@UserName",UserName);

            object obj= SqlHelper.SqlHelper.ExecuteScalar(sql, CommandType.Text,sqlParameter);
            if (obj==null)
            {
                return true;
            }
            else
            {
                return false;
            }
            /// <returns>是否添加成功，大于1即是成功</returns>
        }
        /// <summary>
        /// 添加一个用户
        /// </summary>
        /// <param name="user">用户对象</param>
        /// <returns>大于1即是成功</returns>
	    public int AddUser(UserTable user)
        {
            //以后再加一条添加之前在判断一下是否有该用户名
            string sql = @"INSERT INTO [dbo].[UserTable] ([UserName] ,[UserPwd] ,[UserIP] ,[UserEmail] ,[UserGradeID] ,[IsDel] ,[RegisterTime] ,[Status])
     VALUES(@UserName, @UserPwd, @UserIP, @UserEmail, 1, 1,  @RegisterTime, 1)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@UserName",user.UserName), 
                new SqlParameter("@UserPwd",user.UserPwd), 
                new SqlParameter("@UserIP",user.UserIP), 
                new SqlParameter("@UserEmail",user.UserEmail),  
                new SqlParameter("@RegisterTime",user.RegisterTime)
            };
            return SqlHelper.SqlHelper.ExecuteNonQuery(sql, CommandType.Text,sqlParameters);
        }
        /// <summary>
        /// 删除一个用户
        /// </summary>
        /// <param name="ID">用户的ID</param>
        /// <returns>大于1即是成功</returns>
	    public int DelUser(int ID)
        {
            string sql = "UPDATE [dbo].[UserTable] SET  [IsDel] = 0 WHERE ID=@ID";
            SqlParameter sqlParameter=new SqlParameter("@ID",ID);
            return SqlHelper.SqlHelper.ExecuteNonQuery(sql, CommandType.Text, sqlParameter);
        }
        /// <summary>
        /// 更改一个用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns>大于1即是成功</returns>
	    public int Update(UserTable user)
        {
            //判断有哪一个属性，如果不为空就更改，如果没有ID就传回-1

            string sql = "";
            List<SqlParameter> sqlParameters=new List<SqlParameter>();
            StringBuilder stringBuilder=new StringBuilder();
            stringBuilder.Append("UPDATE [dbo].[UserTable] SET ");
            List<String> strList=new List<String>();
            
            if (user.UserPwd!=null)
            {
                strList.Add("[UserPwd] =@UserPwd");
                sqlParameters.Add(new SqlParameter("@UserPwd", user.UserPwd));
            }
            if (user.UserIP != null)
            {
                strList.Add("[UserIP] =@UserIP");
                sqlParameters.Add(new SqlParameter("@UserIP", user.UserIP));

            }
            if (user.UserEmail != null)
            {
                strList.Add("[UserEmail] =@UserEmail");
                sqlParameters.Add(new SqlParameter("@UserEmail", user.UserEmail));

            }
            if (user.RegisterTime != null)
            {
                strList.Add("[RegisterTime] =@RegisterTime");
                sqlParameters.Add(new SqlParameter("@RegisterTime", user.RegisterTime));

            }
            if (user.Phone != null)
            {
                strList.Add("[Phone] =@Phone");
                sqlParameters.Add(new SqlParameter("@Phone", user.Phone));

            }
            sqlParameters.Add(new SqlParameter("@UserName",user.UserName));
            stringBuilder.Append(string.Join(",", strList));
            stringBuilder.Append(" WHERE UserName=@UserName");
            sql = stringBuilder.ToString();
            //sqlParameters由list-》数组
            SqlParameter[] sqlParameterses1 = new SqlParameter[sqlParameters.Count];
            sqlParameters.CopyTo(sqlParameterses1,0);
            return SqlHelper.SqlHelper.ExecuteNonQuery(sql, CommandType.Text, sqlParameterses1);
        }
        /// <summary>
        /// 登录，检查用户名和密码
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="UserPwd"></param>
        /// <returns>大于1即是成功</returns>
	    public int SelectUser(string UserName,string UserPwd)
	    {
            //以后再添加之前先再次检查一下是否存在该用户名

	        string sql = "SELECT * FROM [dbo].[UserTable] WHERE UserName=@UserName and UserPwd=@UserPwd and IsDel=1";
	        SqlParameter[] sqlParameters =
	        {
	            new SqlParameter("@UserName",UserName),
                new SqlParameter("@UserPwd",UserPwd)
	        };
            object obj= SqlHelper.SqlHelper.ExecuteScalar(sql, CommandType.Text, sqlParameters);
            if (obj!=null)
            {
                return 1;
            }
            else
            {
                return 0;
            }
	    }
        /// <summary>
        /// 软删除一个数据
        /// </summary>
        /// <param name="ID">要删除对象的ID</param>
        /// <returns>int,大于零就是成功</returns>
	    public int DelUser(string UserName)
	    {
	        string sql = "UPDATE [dbo].[UserTable] SET [IsDel] = 0  WHERE UserName=@UserName";
            SqlParameter sqlParameter=new SqlParameter("@UserName", UserName);
	        int num=SqlHelper.SqlHelper.ExecuteNonQuery(sql, CommandType.Text, sqlParameter);
            if (num>0)
            {
                return 1;
            }
            else
            {
                return 0;
            }
	    }
	}
}

