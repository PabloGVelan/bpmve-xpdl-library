using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// This is an empty class to be used as an element of Implementation.
    /// </summary>
    [XmlType("No")]
    public class NoImplementation : IValidate
    {
        public NoImplementation()
        {
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

		public override bool Equals (object obj)
		{
			NoImplementation value = obj as NoImplementation;
            if (value != null)
			{
				return true;
			}
			
			return false;
		}

        #region IValidate Members

        public bool Validate()
        {
            return true;
        }

        #endregion
    }
}
