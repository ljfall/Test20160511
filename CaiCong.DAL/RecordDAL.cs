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
    public class RecordDAL
    {
        /// <summary>
        /// 添加一个日志文件
        /// </summary>
        /// <param name="record">日志对象</param>
        /// <returns>是否成功</returns>
        public bool Add(Record record)
        {
            string sql = "INSERT INTO [dbo].[Record]([Name],[Txt],[Time])VALUES(@Name,@Txt,@Time)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("Id",record.Id), 
                new SqlParameter("Name",record.Name), 
                new SqlParameter("Time",record.Time), 
                new SqlParameter("Txt",record.Txt), 
            };
            int num=SqlHelper.SqlHelper.ExecuteNonQuery(sql, CommandType.Text, sqlParameters);
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
        /// 查询日志文件
        /// </summary>
        /// <returns></returns>
        public List<Record> SelectList()
        {
            List<Record> recordList=new List<Record>();
            //现在日志文件较少，先查询所有，以后再添加分页等功能
            string sql = "select * from Record";
            SqlDataReader sdr= SqlHelper.SqlHelper.ExecuteReader(sql, CommandType.Text);
            while (sdr.Read())
            {
                Record record=new Record();
                record.Id = Convert.ToInt32(sdr["Id"]);
                record.Name = sdr["Name"].ToString();
                record.Time = sdr["Time"].ToString();
                record.Txt = sdr["Txt"].ToString();
                recordList.Add(record);
            }

            return recordList;
        }
    }
}
