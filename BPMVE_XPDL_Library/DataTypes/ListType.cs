using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.13.2.6. List Type
    /// </summary>
    public class ListType : ComplexType
    {
        /// <summary>
        /// The Data type of list entries. See Table 90: Standard Data Types.
        /// </summary>
        public DataType DataType { get; set; }
		[XmlIgnore]
		public bool DataTypeSpecified { get { return DataType != null; } }
    }
}