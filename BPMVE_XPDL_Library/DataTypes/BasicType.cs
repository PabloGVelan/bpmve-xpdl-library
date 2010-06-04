using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.13.1. Basic Data Types
    /// A Simple type: STRING, INTEGER, FLOAT, DATETIME, DATE, TIME, REFERENCE, BOOL, OR PERFORMER.
    /// </summary>
    public class BasicType : DataType
    {
        public string Length { get; set; }
		[XmlIgnore]
		public bool LengthSpecified { get { return Length != ""; } }

        public short Precision { get; set; }

        public short Scale { get; set; }

        public BasicTypeEnum Type { get; set; }
    }
}