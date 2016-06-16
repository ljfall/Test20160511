using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaiCongModel;
using CaiCong.DAL;

namespace CaiCong.BLL
{
    public class RecordBLL
    {
        RecordDAL rDal=new RecordDAL();
        /// <summary>
        /// 添加一个日志文件
        /// </summary>
        /// <param name="record">日志对象</param>
        /// <returns>是否成功</returns>
        public bool Add(Record record)
        {
            return rDal.Add(record);
        }
        /// <summary>
        /// 查询日志文件
        /// </summary>
        /// <returns></returns>
        public List<Record> SelectList()
        {
            return rDal.SelectList();
        }
    }
}
