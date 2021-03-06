﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.Serialization;

namespace SinoSZJS.Base.V2.RefCode
{
    [DataContract]
    public class RefCodeModel
    {
        /// <summary>
        /// 下拉菜单Name
        /// </summary>
        [DataMember]
        public string DropDownEditName { set; get; }

        /// <summary>
        /// 下拉菜单的默认值Value
        /// </summary>
        [DataMember]
        public string DefaultValue { set; get; }

        /// <summary>
        /// 下拉菜单下拉后树的Name
        /// </summary>
        [DataMember]
        public string TreeViewName { set; get; }

        /// <summary>
        /// 代码表的表名Name
        /// </summary>
        [DataMember]
        public string RefCodeName { set; get; }

        /// <summary>
        /// 下载模式 true为一次性全部下载  false为分级下载
        /// </summary>
        [DataMember]
        public bool DownloadMode { set; get; }
        /// <summary>
        /// 是否允许多选
        /// </summary>
        [DataMember]
        public RefCodeMulti RefMulti { set; get; }

        /// <summary>
        /// TreeView列表
        /// </summary>
        [DataMember]
        public List<RefCodeData> RefCodeList { set; get; }

        [DataMember]
        public string LevelFormat { set; get; }
        /// <summary>
        /// 设置代码表下拉是否为空
        /// </summary>
        [DataMember]
        public bool DropDownReadOnly { get; set; }

        public RefCodeModel() { }

        public RefCodeModel(string dropDownEditName, string defaultValue, string treeViewName, string refCodeName, RefCodeMulti refMulti, string popWinName, List<RefCodeData> refCodeList)
        {
            this.DropDownEditName = dropDownEditName;
            this.DefaultValue = defaultValue;
            this.TreeViewName = treeViewName;
            this.RefCodeName = refCodeName;
            this.RefMulti = refMulti;
            this.RefCodeList = refCodeList;
        }
    }
}
