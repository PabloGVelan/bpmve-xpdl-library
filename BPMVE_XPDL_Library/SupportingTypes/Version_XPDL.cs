using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// Version of this specification. The current value, for this specification, is 2.1.
    /// </summary>
    [XmlType("Version")]
    public class Version_XPDL : SimpleType
    {
        public Version_XPDL()
        {
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }
    }
}