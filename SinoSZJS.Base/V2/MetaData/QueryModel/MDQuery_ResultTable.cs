﻿using System.Collections.Generic;
using System.Runtime.Serialization;

namespace SinoSZJS.Base.V2.MetaData.QueryModel
{

	[DataContract]
	public class MDQuery_ResultTable
	{

		/// <summary>
		/// 表的显示名称
		/// </summary>
		/// 
		[DataMember]
		public string DisplayTitle { get; set; }

		/// <summary>
		/// 结果表名
		/// </summary>
		/// 
		[DataMember]
		public string TableName { get; set; }

		/// <summary>
		/// 字段列表
		/// </summary>
		/// 
		[DataMember]
		public List<MDQuery_TableColumn> Columns { get; set; }


	}
}
