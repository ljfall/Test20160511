using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaiCongModel;

namespace CaiCong.DAL
{
    public class SearchGoodsDAL
    {
        /// <summary>
        /// 根据传过来的关键字查询对应的商品和店铺
        /// </summary>
        /// <param name="word">关键字</param>
        /// <returns>SearchGoods对象</returns>
        public SearchGoods SelectGoods(string word)
        {
            SearchGoods searchGoods=new SearchGoods();


            return searchGoods;
        }
    }
}
