using System;
namespace CaiCongModel
{
    /// <summary>
    /// CollectTable:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
	public partial class CollectTable
	{
		public CollectTable()
		{}
		#region Model
		private int _id;
		private int? _collectuserid;
		private int? _goodsid;
		private DateTime? _collecttime;
		private int? _isdel=1;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 收藏的用户的ID
		/// </summary>
		public int? CollectUserID
		{
			set{ _collectuserid=value;}
			get{return _collectuserid;}
		}
		/// <summary>
		/// 收藏的商品的ID
		/// </summary>
		public int? GoodsID
		{
			set{ _goodsid=value;}
			get{return _goodsid;}
		}
		/// <summary>
		/// 收藏的时间
		/// </summary>
		public DateTime? CollectTime
		{
			set{ _collecttime=value;}
			get{return _collecttime;}
		}
		/// <summary>
		/// 1：存在，0：删除
		/// </summary>
		public int? IsDel
		{
			set{ _isdel=value;}
			get{return _isdel;}
		}
		#endregion Model

	}
}

