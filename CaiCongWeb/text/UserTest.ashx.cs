using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using CaiCong.BLL;
using CaiCongModel;
namespace CaiCongWeb.text
{
    /// <summary>
    /// UserTest 的摘要说明
    /// </summary>
    public class UserTest : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            UserTableBLL utb=new UserTableBLL();
            context.Response.ContentType = "text/plain";
            string action= context.Request["action"];
            if (action=="zuce")
            {
                //注册
                UserTable user = new UserTable();

                user.UserName = context.Request["UserName"];
                user.UserPwd = context.Request["UserPwd"];
                user.UserIP=  context.Request.UserHostAddress;
                user.UserEmail = "12345678";
                user.RegisterTime=DateTime.Now;
                context.Response.Write(utb.AddUser(user)); 
            }
            else if(action== "selectName")
            {
                string UserName = context.Request["UserName"];
                if (utb.IsHaveUser(UserName))
                {
                    context.Response.Write("1"); 
                }
                else
                {
                    context.Response.Write("0");
                }
                
            }else if (action=="del")
            {
                //根据用户名软删除该用户
                string UserName = context.Request["UserName"];
                if (utb.DelUser(UserName) >0)
                {
                    context.Response.Write("1");
                }
                else
                {
                    context.Response.Write("0");
                }

            }
            else if (action=="login")
            {
                //登录
                string UserName = context.Request["UserName"];
                string UserPwd = context.Request["UserPwd"];
                if (utb.SelectUser(UserName, UserPwd)>0)
                {
                    context.Response.Write("1");
                }
                else
                {
                    context.Response.Write("0");
                }
                
            }
            else if (action=="updatePwd")
            {
                //修改密码
                UserTable user=new UserTable();
                user.UserName = context.Request["UserName"];
                user.UserPwd = context.Request["UserPwd"];
                if (utb.Update(user)>0)
                {
                    context.Response.Write("1");
                }
                else
                {
                    context.Response.Write("0");
                }
                
            }
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}