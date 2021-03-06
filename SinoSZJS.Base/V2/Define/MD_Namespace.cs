using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SinoSZJS.Base.V2.MetaData.Define
{
	/// <summary>
	/// 命名空间元数据定义
	/// </summary>
	/// 
	[DataContract]
	public class MD_Namespace
	{

		/// <summary>
		/// 命名空间名
		/// </summary>
		[DataMember]
		public string NameSpace { get; set; }

		/// <summary>
		/// 描述
		/// </summary>
		[DataMember]
		public string Description { get; set; }

		/// <summary>
		/// 显示名称
		/// </summary>
		[DataMember]
		public string DisplayTitle { get; set; }

		/// <summary>
		/// 数据在数据库中的名称(此项已无用,保留是为了兼容从前的版本)
		/// </summary>
		[DataMember]
		public string Owner { get; set; }

		/// <summary>
		/// 菜单所在的位置(此项已无用,保留是为了兼容从前的版本)
		/// </summary>
		[DataMember]
		public string MenuPosition { get; set; }

		/// <summary>
		/// 节点代码,指系统所安装的服务器所在的单位编码,可用于区分节点
		/// </summary>
		[DataMember]
		public string DWDM { get; set; }

		/// <summary>
		/// 本空间所含的概念组(此项已无用,保留是为了兼容从前的版本)
		/// </summary>
		[DataMember]
		public string Concepts { get; set; }

		/// <summary>
		/// 显示顺序
		/// </summary>
		[DataMember]
		public int DisplayOrder { get; set; }

		/// <summary>
		/// 命名空间中的表
		/// </summary>
		[DataMember]
		public IList<MD_Table> TableList { get; set; }

		/// <summary>
		/// 命名空间的查询模型
		/// </summary>
		[DataMember]
		public IList<MD_QueryModel> QueryModelList { get; set; }


		[DataMember]
		public IList<MD_RefTable> RefTableList { get; set; }

		/// <summary>
		/// 命名空间所在节点
		/// </summary>
		[DataMember]
		public MD_Nodes Nodes { get; set; }


		public override string ToString()
		{
			return string.Format("命名空间[{0}]", this.DisplayTitle);
		}



	}
}
