using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.13.2.5. Array Type
    /// </summary>
    public class ArrayType : ComplexType
    {
        /// <summary>
        /// The Data type of array entries. See Table 90: Standard Data Types.
        /// </summary>
        public DataType DataType { get; set; }
		[XmlIgnore]
		public bool DataTypeSpecified { get { return DataType != null; } }

        /// <summary>
        /// The lower bound of an ArrayType.
        /// </summary>
        public int LowerIndex { get; set; }

        /// <summary>
        /// The upper bound of an ArrayType.
        /// </summary>
        public int UpperIndex { get; set; }
    }
}