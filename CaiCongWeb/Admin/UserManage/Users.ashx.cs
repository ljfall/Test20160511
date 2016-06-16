using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CaiCongModel;
using CaiCong.BLL;

namespace CaiCongWeb.Admin.UserManage
{
    /// <summary>
    /// Users 的摘要说明
    /// </summary>
    public class Users : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            UserTableBLL btBll=new UserTableBLL();
            context.Response.ContentType = "text/plain";
            string action= context.Request["action"];
            if (action=="selectAll")
            {
                
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