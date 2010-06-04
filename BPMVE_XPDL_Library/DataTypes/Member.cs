using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// A Standard in the record.
    /// </summary>
    public class Member
    {
        /// <summary>
        /// Data type of a member. See Table 90: Standard Data Types.
        /// </summary>
        public DataType DataType { get; set; }
		[XmlIgnore]
		public bool DataTypeSpecified { get { return DataType != null; } }
    }
}