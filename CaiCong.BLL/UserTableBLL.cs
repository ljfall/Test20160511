using System;
using System.Data;
using System.Collections.Generic;
using CaiCong.DAL;
using CaiCongModel;
namespace CaiCong.BLL
{
    
    /// <summary>
    /// 用户表BLL层
    /// </summary>
    public partial class UserTableBLL
	{
        UserTableDAL utd = new UserTableDAL();

        /// <summary>
        /// 检查是否存在用户名
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns>是否添加成功，大于1即是成功</returns>
        public bool IsHaveUser(string UserName)
        {
            return utd.IsHaveUser(UserName);
        }

        /// <summary>
        /// 添加一个用户
        /// </summary>
        /// <param name="user">用户对象</param>
        /// <returns>大于1即是成功</returns>
        public int AddUser(UserTable user)
        {
            return utd.AddUser(user);
        }

        /// <summary>
        /// 删除一个用户
        /// </summary>
        /// <param name="ID">用户的ID</param>
        /// <returns>大于1即是成功</returns>
        public int DelUser(int ID)
        {
            return utd.DelUser(ID);
        }

        /// <summary>
        /// 更改一个用户
        /// </summary>
        /// <param name="user"></param>
        /// <returns>大于1即是成功</returns>
        public int Update(UserTable user)
        {
            return utd.Update(user);
        }

        /// <summary>
        /// 登录，检查用户名和密码
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="UserPwd"></param>
        /// <returns>大于1即是成功</returns>
        public int SelectUser(string UserName, string UserPwd)
        {
            return utd.SelectUser(UserName, UserPwd);
        }

        /// <summary>
        /// 软删除一个数据
        /// </summary>
        /// <param name="ID">要删除对象的ID</param>
        /// <returns>int,大于零就是成功</returns>
        public int DelUser(string UserName)
        {
            return utd.DelUser(UserName);
        }


	}
}

