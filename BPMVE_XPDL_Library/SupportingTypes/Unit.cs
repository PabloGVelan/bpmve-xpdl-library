using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// Units used in Simulation Data (Usually expressed in terms of a currency). 
    /// The currency codes specified by ISO 4217 are recommended.
    /// </summary>
    public class Unit : SimpleType
    {
        public Unit()
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