using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CaiCong.DAL;
using CaiCongModel;

namespace CaiCong.BLL
{
    public class HomeTableBLL
    {
        HomeTableDAL hbll=new HomeTableDAL();

        /// <summary>
        /// 添加一个HomeTable对象
        /// </summary>
        /// <param name="home">一个HomeTable对象</param>
        /// <returns>是否操作成功</returns>
        public bool Add(HomeTable home)
        {
            return hbll.Add(home);
        }

        /// <summary>
        /// 删除一个HomeTable对象
        /// </summary>
        /// <param name="ID"></param>
        /// <returns>是否操作成功</returns>
        public bool Del(int ID)
        {
            return hbll.Del(ID);
        }

        /// <summary>
        /// 更改一个HomeTable对象
        /// </summary>
        /// <param name="home">一个HomeTable对象</param>
        /// <returns>是否操作成功</returns>
        public bool Updata(HomeTable home)
        {
            return hbll.Updata(home);
        }

        /// <summary>
        /// 查询一个HomeTable对象,可以根据ID或ThisKey或ThisValue
        /// </summary>
        /// <param name="home">一个HomeTable对象</param>
        /// <returns>是否操作成功</returns>
        public List<HomeTable> Select(HomeTable home)
        {
            return hbll.Select(home);
        }
    }
}
