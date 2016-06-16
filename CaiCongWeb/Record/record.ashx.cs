using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using CaiCongModel;
using CaiCong.BLL;

namespace CaiCongWeb.Record
{
    /// <summary>
    /// record 的摘要说明
    /// </summary>
    public class record : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            RecordBLL rBll=new RecordBLL();
            context.Response.ContentType = "text/plain";
            string action= context.Request["action"];
            if (action== "select")
            {
                List<CaiCongModel.Record> records= rBll.SelectList();
                
                JavaScriptSerializer jss=new JavaScriptSerializer();
                string recordList= jss.Serialize(records);
                context.Response.Write(recordList);
            }else if (action== "tijiao")
            {
                CaiCongModel.Record record = new CaiCongModel.Record();
                record.Name = context.Request["Name"];
                record.Txt = context.Request["Txt"];
                record.Time=DateTime.Now.ToString();
                if (rBll.Add(record))
                {
                    context.Response.Write("添加成功！");
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