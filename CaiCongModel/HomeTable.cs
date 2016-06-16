using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiCongModel
{
    public class HomeTable
    {
        private int _id;
        private string _thiskey;
        private string _imgurl;
        private int _thisshopid;
        private int _isdel;
        public int ID
        {
            set { _id = value; }
            get { return _id; }
        }
        /// <summary>
        /// key
        /// </summary>
        public string ThisKey
        {
            set { _thiskey = value; }
            get { return _thiskey; }
        }
        /// <summary>
        /// 对应商品的ID
        /// </summary>
        public int ThisShopID
        {
            set { _thisshopid = value; }
            get { return _thisshopid; }
        }
        /// <summary>
        /// 专门用于首页的图片
        /// </summary>
        public string ImgUrl
        {
            set { _imgurl = value; }
            get { return _imgurl; }
        }
        /// <summary>
        /// 是否删除
        /// </summary>
        public int IsDel
        {
            set { _isdel = value; }
            get { return _isdel; }
        }
    }
}
