using System;
namespace CaiCongModel
{
	/// <summary>
	/// SensitiveWordTable:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SensitiveWordTable
	{
		public SensitiveWordTable()
		{}
		#region Model
		private int _id;
		private string _sensitiveword;
		private int? _sensitivewordgenre;
		private string _substitutes;
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
		/// 敏感词
		/// </summary>
		public string SensitiveWord
		{
			set{ _sensitiveword=value;}
			get{return _sensitiveword;}
		}
		/// <summary>
		/// 敏感等级
		/// </summary>
		public int? SensitiveWordGenre
		{
			set{ _sensitivewordgenre=value;}
			get{return _sensitivewordgenre;}
		}
		/// <summary>
		/// 敏感词替代用词
		/// </summary>
		public string Substitutes
		{
			set{ _substitutes=value;}
			get{return _substitutes;}
		}
		/// <summary>
		/// 是否删除
		/// </summary>
		public int IsDel
		{
			set{ _isdel=value;}
			get{return _isdel;}
		}
		#endregion Model

	}
}

