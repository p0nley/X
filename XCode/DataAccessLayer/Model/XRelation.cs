﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;

namespace XCode.DataAccessLayer
{
    /// <summary>
    /// 数据关系
    /// </summary>
    [Serializable]
    [XmlRoot("Relation")]
    class XRelation : SerializableDataMember, IDataRelation
    {
        #region 属性
        private String _Column;
        /// <summary>数据列</summary>
        public String Column
        {
            get { return _Column; }
            set { _Column = value; }
        }

        private String _RelationTable;
        /// <summary>引用表</summary>
        public String RelationTable
        {
            get { return _RelationTable; }
            set { _RelationTable = value; }
        }

        private String _RelationColumn;
        /// <summary>引用列</summary>
        public String RelationColumn
        {
            get { return _RelationColumn; }
            set { _RelationColumn = value; }
        }

        private Boolean _Unique;
        /// <summary>是否唯一</summary>
        public Boolean Unique
        {
            get { return _Unique; }
            set { _Unique = value; }
        }

        [NonSerialized]
        private IDataTable _Table;
        /// <summary>表</summary>
        [XmlIgnore]
        public IDataTable Table
        {
            get { return _Table; }
            set { _Table = value; }
        }
        #endregion

        #region 辅助
        /// <summary>
        /// 已重载。
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return String.Format("{0}=>{1}.{2} {3}", Column, RelationTable, RelationColumn, Unique ? "U" : "");
        }
        #endregion
    }
}