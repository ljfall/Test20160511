using System;
namespace CaiCongModel
{
	/// <summary>
	/// ShoppingCarTable:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ShoppingCarTable
	{
		public ShoppingCarTable()
		{}
		#region Model
		private int _id;
		private int _userid;
		private int _goodsid;
		private int _goodsnumber;
		private int _isdel=1;
		private DateTime _thistime;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 所属用户
		/// </summary>
		public int UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 商品ID
		/// </summary>
		public int GoodsID
		{
			set{ _goodsid=value;}
			get{return _goodsid;}
		}
		/// <summary>
		/// 商品数量
		/// </summary>
		public int GoodsNumber
		{
			set{ _goodsnumber=value;}
			get{return _goodsnumber;}
		}
		/// <summary>
		/// 1：存在，0：已删除
		/// </summary>
		public int IsDel
		{
			set{ _isdel=value;}
			get{return _isdel;}
		}
		/// <summary>
		/// 加入时间
		/// </summary>
		public DateTime ThisTime
		{
			set{ _thistime=value;}
			get{return _thistime;}
		}
		#endregion Model

	}
}

