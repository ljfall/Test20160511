using System;
namespace CaiCongModel
{
	/// <summary>
	/// GoodsTable:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class GoodsTable
	{
		public GoodsTable()
		{}
		#region Model
		private int _id;
		private string _goodsname;
		private string _goodstxt;
		private string _goodsjianjie;
		private int? _shopid;
		private int _goodsnumber;
		private int _salesnumber;
		private int? _collectnumber=0;
		private decimal? _original;
		private decimal _price;
		private int? _appraisenumber;
		private int _isdel=1;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 商品名
		/// </summary>
		public string GoodsName
		{
			set{ _goodsname=value;}
			get{return _goodsname;}
		}
		/// <summary>
		/// 商品介绍
		/// </summary>
		public string GoodsTxt
		{
			set{ _goodstxt=value;}
			get{return _goodstxt;}
		}
        /// <summary>
        /// 商品简介
        /// </summary>
        public string GoodsJianJie
        {
            set { _goodsjianjie = value; }
            get { return _goodsjianjie; }
        }
        /// <summary>
        /// 对应店铺ID
        /// </summary>
        public int? ShopID
		{
			set{ _shopid=value;}
			get{return _shopid;}
		}
		/// <summary>
		/// 库存
		/// </summary>
		public int GoodsNumber
		{
			set{ _goodsnumber=value;}
			get{return _goodsnumber;}
		}
		/// <summary>
		/// 已经销售个数
		/// </summary>
		public int SalesNumber
		{
			set{ _salesnumber=value;}
			get{return _salesnumber;}
		}
		/// <summary>
		/// 收藏个数
		/// </summary>
		public int? CollectNumber
		{
			set{ _collectnumber=value;}
			get{return _collectnumber;}
		}
		/// <summary>
		/// 原价
		/// </summary>
		public decimal? Original
		{
			set{ _original=value;}
			get{return _original;}
		}
		/// <summary>
		/// 现价
		/// </summary>
		public decimal Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 评价分数
		/// </summary>
		public int? AppraiseNumber
		{
			set{ _appraisenumber=value;}
			get{return _appraisenumber;}
		}
		/// <summary>
		/// 1代表存在，0代表已删除
		/// </summary>
		public int IsDel
		{
			set{ _isdel=value;}
			get{return _isdel;}
		}
		#endregion Model

	}
}

