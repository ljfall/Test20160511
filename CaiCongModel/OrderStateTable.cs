using System;
namespace CaiCongModel
{
	/// <summary>
	/// OrderStateTable:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class OrderStateTable
	{
		public OrderStateTable()
		{}
		#region Model
		private int _id;
		private string _orderstate;
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
		/// 订单状态
		/// </summary>
		public string OrderState
		{
			set{ _orderstate=value;}
			get{return _orderstate;}
		}
		/// <summary>
		/// 1代表存在，0：删除
		/// </summary>
		public int IsDel
		{
			set{ _isdel=value;}
			get{return _isdel;}
		}
		#endregion Model

	}
}

