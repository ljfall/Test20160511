using System;
namespace CaiCongModel
{
	/// <summary>
	/// 用户等级表
	/// </summary>
	[Serializable]
	public partial class UserGradeTable
	{
		public UserGradeTable()
		{}
		#region Model
		private int _id;
		private string _usergrade;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 用户等级
		/// </summary>
		public string UserGrade
		{
			set{ _usergrade=value;}
			get{return _usergrade;}
		}
		#endregion Model

	}
}

