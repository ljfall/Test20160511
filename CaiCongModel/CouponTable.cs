using System;
namespace CaiCongModel
{
	/// <summary>
	/// CouponTable:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class CouponTable
	{
		public CouponTable()
		{}
		#region Model
		private int _id;
		private int? _userid;
		private int? _shopid;
		private decimal? _usemoney;
		private decimal? _subduction;
		private DateTime? _gettime;
		private DateTime? _overtime;
		private int? _isdel=1;
		/// <summary>
		/// 
		/// </summary>
		public int SubductionID
        {
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 优惠券所属用户
		/// </summary>
		public int? UserID
		{
			set{ _userid=value;}
			get{return _userid;}
		}
		/// <summary>
		/// 优惠券所属店铺ID
		/// </summary>
		public int? ShopID
		{
			set{ _shopid=value;}
			get{return _shopid;}
		}
		/// <summary>
		/// 优惠券满足值
		/// </summary>
		public decimal? UseMoney
		{
			set{ _usemoney=value;}
			get{return _usemoney;}
		}
		/// <summary>
		/// 优惠券消减值
		/// </summary>
		public decimal? Subduction
		{
			set{ _subduction=value;}
			get{return _subduction;}
		}
		/// <summary>
		/// 领取时间
		/// </summary>
		public DateTime? GetTime
		{
			set{ _gettime=value;}
			get{return _gettime;}
		}
		/// <summary>
		/// 过期时间
		/// </summary>
		public DateTime? OverTime
		{
			set{ _overtime=value;}
			get{return _overtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? IsDel
		{
			set{ _isdel=value;}
			get{return _isdel;}
		}
		#endregion Model

	}
}

