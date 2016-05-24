using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Common;
using CaiCongModel;
using System.Collections.Generic;

namespace CaiCong.DAL
{
	/// <summary>
	/// 数据访问类:SensitiveWordTable敏感词表
	/// </summary>
	public partial class SensitiveWordTableDAL
	{
        /// <summary>
        /// 添加一个敏感词
        /// </summary>
        /// <param name="collect">敏感词对象</param>
        /// <returns>是否成功</returns>
        public bool Add(SensitiveWordTable sensitiveWord)
        {
            string sql = "INSERT INTO [dbo].[SensitiveWordTable]([SensitiveWord],[SensitiveWordGenre],[Substitutes],[IsDel])VALUES(@SensitiveWord,@SensitiveWordGenre,@Substitutes,1)";
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@CollectUserID",sensitiveWord.SensitiveWord),
                new SqlParameter("@GoodsID",sensitiveWord.SensitiveWordGenre),
                new SqlParameter("@CollectTime",sensitiveWord.Substitutes),
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
        /// 根据ID删除一个敏感词
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
	    public bool Del(int ID)
        {
            string sql = "UPDATE [dbo].[SensitiveWordTable] SET [IsDel] = 0 WHERE  ID=@ID";
            SqlParameter sqlParameters = new SqlParameter("ID", ID);
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
        /// 更改一个敏感字
        /// </summary>
        /// <param name="collect">敏感字对象</param>
        /// <returns>是否成功</returns>
	    public bool Update(SensitiveWordTable sensitiveWord)
        {
            if (sensitiveWord.ID < 0)
            {
                return false;
            }
            string sql = "UPDATE [dbo].[SensitiveWordTable] SET [SensitiveWord] = @SensitiveWord WHERE  ID=@ID";

            SqlParameter[] sqlParameters =
            {
                new SqlParameter("ID", sensitiveWord.ID),
                new SqlParameter("ID", sensitiveWord.SensitiveWord),

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
        /// 精确查询
        /// </summary>
        /// <param name="word">查询的关键字</param>
        /// <returns>敏感词对象</returns>
	    public SensitiveWordTable SelectPrecise(string word)
        {
            SensitiveWordTable sensitiveWord = new SensitiveWordTable();
            string sql = "SELECT [ID],[SensitiveWord],[SensitiveWordGenre],[Substitutes],[IsDel] FROM [dbo].[SensitiveWordTable] where SensitiveWord=@SensitiveWord";
            SqlParameter sqlParameter=new SqlParameter("@SensitiveWord", word);
            SqlDataReader sdr= SqlHelper.SqlHelper.ExecuteReader(sql, CommandType.Text, sqlParameter);
            if (sdr.Read())
            {
                sensitiveWord.ID = Convert.ToInt32(sdr["ID"]);
                sensitiveWord.SensitiveWordGenre = Convert.ToInt32(sdr["SensitiveWordGenre"]);
                sensitiveWord.SensitiveWord = sdr["SensitiveWord"].ToString();
                sensitiveWord.Substitutes = sdr["Substitutes"].ToString();
            }

            return sensitiveWord;
        }
        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="word">查询的关键字</param>
        /// <returns>敏感词对象的集合</returns>
	    public List<SensitiveWordTable> SelectVague(string word)
        {
            List<SensitiveWordTable> sensitiveWordList = new List<SensitiveWordTable>();
            string sql = "SELECT [ID],[SensitiveWord],[SensitiveWordGenre],[Substitutes],[IsDel] FROM [dbo].[SensitiveWordTable] where SensitiveWord=@SensitiveWord";
            SqlParameter sqlParameter = new SqlParameter("@SensitiveWord", "%" + word + "%");
            SqlDataReader sdr = SqlHelper.SqlHelper.ExecuteReader(sql, CommandType.Text, sqlParameter);
            while (sdr.Read())
            {
                SensitiveWordTable sensitiveWord = new SensitiveWordTable();

                sensitiveWord.ID = Convert.ToInt32(sdr["ID"]);
                sensitiveWord.SensitiveWordGenre = Convert.ToInt32(sdr["SensitiveWordGenre"]);
                sensitiveWord.SensitiveWord = sdr["SensitiveWord"].ToString();
                sensitiveWord.Substitutes = sdr["Substitutes"].ToString();
                sensitiveWordList.Add(sensitiveWord);
            }
            return sensitiveWordList;
        }
        /// <summary>
        /// 根据敏感词等级查询
        /// </summary>
        /// <param name="num">敏感词等级</param>
        /// <returns>敏感词对象的集合</returns>
	    public List<SensitiveWordTable> SelectByGrade(int num)
        {
            List<SensitiveWordTable> sensitiveWordList = new List<SensitiveWordTable>();
            string sql = "SELECT [ID],[SensitiveWord],[SensitiveWordGenre],[Substitutes],[IsDel] FROM [dbo].[SensitiveWordTable] where SensitiveWordGenre<=@SensitiveWordGenre";
            SqlParameter sqlParameter = new SqlParameter("@SensitiveWord", num);
            SqlDataReader sdr = SqlHelper.SqlHelper.ExecuteReader(sql, CommandType.Text, sqlParameter);
            while (sdr.Read())
            {
                SensitiveWordTable sensitiveWord = new SensitiveWordTable();

                sensitiveWord.ID = Convert.ToInt32(sdr["ID"]);
                sensitiveWord.SensitiveWordGenre = Convert.ToInt32(sdr["SensitiveWordGenre"]);
                sensitiveWord.SensitiveWord = sdr["SensitiveWord"].ToString();
                sensitiveWord.Substitutes = sdr["Substitutes"].ToString();
                sensitiveWordList.Add(sensitiveWord);
            }
            return sensitiveWordList;
        }
    }
}

