using System;
using System.Diagnostics;

namespace CaiCongModel
{
	/// <summary>
	/// ShopTable:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ShopTable
	{
		public ShopTable()
		{}
		#region Model
		private int _id;
		private string _shopname;
		private int? _shopuserid;
		private int? _shopgenre;
		private DateTime? _registertime;
		private decimal? _shopappraise;
		private int? _isdel=1;
	    private int? _shopappraisenumber;
        /// <summary>
        /// 
        /// </summary>
        public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 店铺名
		/// </summary>
		public string ShopName
		{
			set{ _shopname=value;}
			get{return _shopname;}
		}
		/// <summary>
		/// 掌柜的用户i、ID
		/// </summary>
		public int? ShopUserID
		{
			set{ _shopuserid=value;}
			get{return _shopuserid;}
		}
		/// <summary>
		/// 店铺等级
		/// </summary>
		public int? ShopGenre
		{
			set{ _shopgenre=value;}
			get{return _shopgenre;}
		}
		/// <summary>
		/// 店铺注册时间
		/// </summary>
		public DateTime? RegisterTime
		{
			set{ _registertime=value;}
			get{return _registertime;}
		}
		/// <summary>
		/// 店铺评价总分数
		/// </summary>
		public decimal? ShopAppraise
		{
			set{ _shopappraise=value;}
			get{return _shopappraise;}
		}
        
        /// <summary>
        /// 评价人数
        /// </summary>
	    public int? ShopAppraiseNumber
	    {
	        set { _shopappraisenumber = value; }
	        get { return _shopappraisenumber; }
	    }

	    #endregion Model

    }
}

