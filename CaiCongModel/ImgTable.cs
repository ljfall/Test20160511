using System;
namespace CaiCongModel
{
	/// <summary>
	/// ImgTable:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class ImgTable
	{
		public ImgTable()
		{}
		#region Model
		private int _id;
		private int? _goodsid;
		private string _imgpath;
		private int _isdel=1;
		private DateTime? _updatetime;
		private int? _isok;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 商品ID
		/// </summary>
		public int? GoodsID
		{
			set{ _goodsid=value;}
			get{return _goodsid;}
		}
		/// <summary>
		/// 图片路径
		/// </summary>
		public string ImgPath
		{
			set{ _imgpath=value;}
			get{return _imgpath;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int IsDel
		{
			set{ _isdel=value;}
			get{return _isdel;}
		}
		/// <summary>
		/// 上传时间
		/// </summary>
		public DateTime? UpdateTime
		{
			set{ _updatetime=value;}
			get{return _updatetime;}
		}
		/// <summary>
		/// 0：表示未审核，1：审核成功，2：表示审核拒绝
		/// </summary>
		public int? IsOK
		{
			set{ _isok=value;}
			get{return _isok;}
		}
		#endregion Model

	}
}

