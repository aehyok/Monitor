﻿using System.Runtime.Serialization;

namespace SinoSZJS.Base.V2.MetaData.QueryModel
{
	[DataContract]
	public enum QueryColumnType
	{
		/// <summary>
		/// 表字段
		/// </summary>
		/// 
		[EnumMember]
		TableColumn = 0,
		/// <summary>
		/// 计算字段　(指加减乘除及函数计算)
		/// </summary>
		[EnumMember]
		CalculationColumn = 1,
		/// <summary>
		/// 统计字段　(指对主表对子表记录的求和\求平均值\求最大值等统计,并在统计基础上可计算)
		/// </summary>
		[EnumMember]
		StatisticsColumn = 2
	}
}
