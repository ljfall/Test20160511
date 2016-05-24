using System;
using System.Data;
using System.Collections.Generic;
using CaiCong.DAL;
using CaiCongModel;
namespace CaiCong.BLL
{
    /// <summary>
    /// SensitiveWordTable
    /// </summary>
    public partial class SensitiveWordTableBLL
    {
        SensitiveWordTableDAL swDal = new SensitiveWordTableDAL();

        /// <summary>
        /// 添加一个敏感词
        /// </summary>
        /// <param name="collect">敏感词对象</param>
        /// <returns>是否成功</returns>
        public bool Add(SensitiveWordTable sensitiveWord)
        {
            return swDal.Add(sensitiveWord);
        }

        /// <summary>
        /// 根据ID删除一个敏感词
        /// </summary>
        /// <param name="ID"></param>
        /// <returns></returns>
        public bool Del(int ID)
        {
            return swDal.Del(ID);
        }

        /// <summary>
        /// 更改一个敏感字
        /// </summary>
        /// <param name="collect">敏感字对象</param>
        /// <returns>是否成功</returns>
        public bool Update(SensitiveWordTable sensitiveWord)
        {
            return swDal.Update(sensitiveWord);
        }

        /// <summary>
        /// 精确查询
        /// </summary>
        /// <param name="word">查询的关键字</param>
        /// <returns>敏感词对象</returns>
        public SensitiveWordTable SelectPrecise(string word)
        {
            return swDal.SelectPrecise(word);
        }

        /// <summary>
        /// 模糊查询
        /// </summary>
        /// <param name="word">查询的关键字</param>
        /// <returns>敏感词对象的集合</returns>
        public List<SensitiveWordTable> SelectVague(string word)
        {
            return swDal.SelectVague(word);
        }

        /// <summary>
        /// 根据敏感词等级查询
        /// </summary>
        /// <param name="num">敏感词等级</param>
        /// <returns>敏感词对象的集合</returns>
        public List<SensitiveWordTable> SelectByGrade(int num)
        {
            return swDal.SelectByGrade(num);
        }

    }
}

