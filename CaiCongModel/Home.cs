using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaiCongModel
{
    public class Home
    {
        /// <summary>
        /// 轮播图片5个
        /// </summary>
        public string[] Imgs { get; set; }
        /// <summary>
        /// 猜你喜欢图片列表6个
        /// </summary>
        public string[] ImgLike { get; set; }
        /// <summary>
        /// 搜索框后的图片1个
        /// </summary>
        public string SearchImg { get; set; }
        /// <summary>
        /// 轮播图片后面的推荐图片1个
        /// </summary>
        public string ImgsOther { get; set; }
        /// <summary>
        /// 今日推荐1个
        /// </summary>
        public string ImgsToday { get; set; }
        /// <summary>
        /// 其他的10个展示商品10个
        /// </summary>
        public string[] OtherShow { get; set; }
    }
}
