﻿using System.Runtime.Serialization;

namespace SinoSZJS.Base.V2.MetaData.QueryModel
{
	[DataContract]
	public class MDModel_View2GL
	{
		public MDModel_View2GL(string id, string glid, string viewid, int order, string title, string param)
		{
			ID = id;
			DisplayOrder = order;
			DisplayTitle = title;
			ViewID = viewid;
			TargetGuideLineID = glid;
			RelationParam = param;
		}
		[DataMember]
		public string ID { get; set; }
		[DataMember]
		public int DisplayOrder { get; set; }
		[DataMember]
		public string DisplayTitle { get; set; }
		[DataMember]
		public string ViewID { get; set; }
		[DataMember]
		public string TargetGuideLineID { get; set; }
		[DataMember]
		public string RelationParam { get; set; }
	}
}
