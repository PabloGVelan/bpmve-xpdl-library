using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class Time : SimpleType
    {
        public Time()
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
