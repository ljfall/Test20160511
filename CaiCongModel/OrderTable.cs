using System;
namespace CaiCongModel
{
	/// <summary>
	/// OrderTable:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OrderTable
	{
		public OrderTable()
		{}
		#region Model
		private int _id;
		private DateTime _ordertime;
		private string _orderserial;
		private int _goodsid;
		private decimal _price;
		private int _goodsnumber;
		private int _receivingmanagementid;
		private int _isdel=1;
		private int _orderstateid;
	    private int _userid;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
        /// <summary>
        /// 用户ID
        /// </summary>
        public int UserID
        {
            set { _userid = value; }
            get { return _userid; }
        }
        /// <summary>
        /// 下订单时间
        /// </summary>
        public DateTime OrderTime
		{
			set{ _ordertime=value;}
			get{return _ordertime;}
		}
		/// <summary>
		/// 订单流水号
		/// </summary>
		public string OrderSerial
		{
			set{ _orderserial=value;}
			get{return _orderserial;}
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
		/// 价格
		/// </summary>
		public decimal Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 购买个数
		/// </summary>
		public int GoodsNumber
		{
			set{ _goodsnumber=value;}
			get{return _goodsnumber;}
		}
		/// <summary>
		/// 收货地址对应ID
		/// </summary>
		public int ReceivingManagementID
		{
			set{ _receivingmanagementid=value;}
			get{return _receivingmanagementid;}
		}
		/// <summary>
		/// 是否删除，1代表存在，0代表删除
		/// </summary>
		public int IsDel
		{
			set{ _isdel=value;}
			get{return _isdel;}
		}
		/// <summary>
		/// 订单状态对应ID
		/// </summary>
		public int OrderStateID
		{
			set{ _orderstateid=value;}
			get{return _orderstateid;}
		}
		#endregion Model

	}
}

