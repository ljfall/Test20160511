using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using NVelocity;
using NVelocity.App;
using NVelocity.Runtime;

namespace Common
{
    public class NVelocityHelper
    {
        private VelocityEngine velocityEngine = null;
        private VelocityContext vc = new VelocityContext();
        /// <summary>
        /// 1，新建一个NVelocityHelper对象
        /// </summary>
        /// <param name="templatePath"></param>
        public NVelocityHelper(string templatePath)
        {
            //创建Velocity引擎，并设置属性
            velocityEngine = new VelocityEngine();
            velocityEngine.AddProperty(RuntimeConstants.RESOURCE_LOADER, "file");           // Velocity加载类型
            velocityEngine.AddProperty(RuntimeConstants.FILE_RESOURCE_LOADER_PATH,          // Velocity加载文件路径
               HttpContext.Current.Server.MapPath("~/"+ templatePath + "/"));
            velocityEngine.AddProperty(RuntimeConstants.INPUT_ENCODING, "utf-8");          // 输入编码格式设置
            velocityEngine.AddProperty(RuntimeConstants.OUTPUT_ENCODING, "utf-8");         // 输出编码格式设置
            velocityEngine.Init();
        }
        /// <summary>
        /// 2，设置上下文对象
        /// </summary>
        /// <param name="name">上下文的key</param>
        /// <param name="obj">key对应的值</param>
        public void Put(string name,object obj)
        {
            vc.Put(name, obj);
        }
        /// <summary>
        /// 3，合并模板，生成静态页
        /// </summary>
        /// <param name="name">静态页的路径和名字</param>
        /// <returns></returns>
        public bool GetHtml(string name)
        {
            //创建模板
            Template template = velocityEngine.GetTemplate("HtmlPage1.html");
            //合并模板和上下文对象，输出
            StringWriter writer = new StringWriter();
            template.Merge(vc, writer);
            
            using (StreamWriter writer2 = new StreamWriter(HttpContext.Current.Server.MapPath("/") + name))
            {
                writer2.Write(writer);
                writer2.Flush();
                writer2.Close();
            }

            return true;
        }
        /// <summary>
        ///3，合并模板并输出
        /// </summary>
        /// <param name="templateName">模板的名字</param>
        public void Render(string templateName)
        {
            //创建模板
            Template template = velocityEngine.GetTemplate(templateName);
            //合并模板和上下文对象，输出
            StringWriter writer = new StringWriter();
            template.Merge(vc, writer);
            HttpContext.Current.Response.Write(writer.ToString());
            HttpContext.Current.Response.End();
        }
    }
}