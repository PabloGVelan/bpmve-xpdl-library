using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class ValidTo : SimpleType
    {
        public ValidTo()
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