using System;
namespace CaiCongModel
{
	/// <summary>
	/// AppraiseTable:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class AppraiseTable
	{
		public AppraiseTable()
		{}
		#region Model
		private int _id;
		private int _appraise;
		private int _appraisegoodsid;
		private int _appraisegenre;
		private int _isdel=1;
	    private string _appraisetxt;
        /// <summary>
        /// 
        /// </summary>
        public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 评价人
		/// </summary>
		public int Appraise
		{
			set{ _appraise=value;}
			get{return _appraise;}
		}
		/// <summary>
		/// 评价商品ID
		/// </summary>
		public int AppraiseGoodsID
		{
			set{ _appraisegoodsid=value;}
			get{return _appraisegoodsid;}
		}
		/// <summary>
		/// 评价类别在；1：好评，2：中评，3：差评
		/// </summary>
		public int AppraiseGenre
		{
			set{ _appraisegenre=value;}
			get{return _appraisegenre;}
		}
		/// <summary>
		/// 1：存在，0：删除
		/// </summary>
		public int IsDel
		{
			set{ _isdel=value;}
			get{return _isdel;}
		}
        public string AppraiseTxt
        {
            set { _appraisetxt = value; }
            get { return _appraisetxt; }
        }
        
        #endregion Model

    }
}

