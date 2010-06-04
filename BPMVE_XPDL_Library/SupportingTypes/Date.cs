using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// Extra class created to encapsulate information.
    /// Should be stored in either the Basic OR Extended forms specified by ISO 8601. 
    /// For example: 1985-04-12T10:15:30Z is the extended form of the 3:30 pm on the 
    /// 12th April 1985 GMT.
    /// </summary>
    public class Date : SimpleType
    {
        public Date()
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