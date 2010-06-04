using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// Defines the origin of this model definition AND contains vendor's name, 
    /// vendor's product name AND product's release number.
    /// </summary>
    public class Vendor : SimpleType
    {
        public Vendor()
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