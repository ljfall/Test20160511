using System;
namespace CaiCongModel
{
	/// <summary>
	/// StatusTable:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class StatusTable
	{
		public StatusTable()
		{}
		#region Model
		private int _id;
		private string _userstatus;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 用户身份表
		/// </summary>
		public string UserStatus
		{
			set{ _userstatus=value;}
			get{return _userstatus;}
		}
		#endregion Model

	}
}

