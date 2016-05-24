using System;
namespace CaiCongModel
{
	/// <summary>
	/// 1
	/// </summary>
	[Serializable]
	public partial class UserTable
	{
		public UserTable()
		{}
		#region Model
		private int _id;
		private string _username;
		private string _userpwd;
		private string _userip;
		private string _useremail;
		private int? _usergradeid;
		private int _isdel=1;
		private int _integral=0;
		private DateTime? _registertime;
		private byte[] _phone;
		private int _status;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 用户名
		/// </summary>
		public string UserName
		{
			set{ _username=value;}
			get{return _username;}
		}
		/// <summary>
		/// 用户密码
		/// </summary>
		public string UserPwd
		{
			set{ _userpwd=value;}
			get{return _userpwd;}
		}
		/// <summary>
		/// 注册IP
		/// </summary>
		public string UserIP
		{
			set{ _userip=value;}
			get{return _userip;}
		}
		/// <summary>
		/// 绑定邮箱
		/// </summary>
		public string UserEmail
		{
			set{ _useremail=value;}
			get{return _useremail;}
		}
		/// <summary>
		/// 用户等级表对应的ID
		/// </summary>
		public int? UserGradeID
		{
			set{ _usergradeid=value;}
			get{return _usergradeid;}
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
		/// 积分
		/// </summary>
		public int Integral
		{
			set{ _integral=value;}
			get{return _integral;}
		}
		/// <summary>
		/// 注册时间
		/// </summary>
		public DateTime? RegisterTime
		{
			set{ _registertime=value;}
			get{return _registertime;}
		}
		/// <summary>
		/// 联系电话
		/// </summary>
		public byte[] Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 身份表对应的ID
		/// </summary>
		public int Status
		{
			set{ _status=value;}
			get{return _status;}
		}
		#endregion Model

	}
}

