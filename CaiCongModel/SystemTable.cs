using System;
namespace CaiCongModel
{
	/// <summary>
	/// 1
	/// </summary>
	[Serializable]
	public partial class SystemTable
	{
		public SystemTable()
		{}
		#region Model
		private int _id;
		private string _thiskey;
		private string _thisvalue;
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
		/// 
		/// </summary>
		public string ThisKey
		{
			set{ _thiskey=value;}
			get{return _thiskey;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ThisValue
		{
			set{ _thisvalue=value;}
			get{return _thisvalue;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int IsDel
		{
			set{ _isdel=value;}
			get{return _isdel;}
		}
		#endregion Model

	}
}

