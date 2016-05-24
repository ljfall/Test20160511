using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaiCongModel;
using CaiCong.DAL;

namespace CaiCong.BLL
{
    public class SearchGoodsBLL
    {
        SearchGoodsDAL sgDal=new SearchGoodsDAL();
        /// <summary>
        /// 根据传过来的关键字查询对应的商品和店铺
        /// </summary>
        /// <param name="word">关键字</param>
        /// <returns>SearchGoods对象</returns>
        public SearchGoods SelectGoods(string word)
        {
            return sgDal.SelectGoods(word);
        }
    }
}
