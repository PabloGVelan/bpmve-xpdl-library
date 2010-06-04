using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class PropertyInput : IValidate
    {
        [XmlAttribute("PropertyId")]
        public string PropertyId { get; set; }
		[XmlIgnore]
		public bool PropertyIdSpecified { get { return PropertyId != ""; } }



        public PropertyInput()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            PropertyInput value = obj as PropertyInput;
            if (value != null)
            {
                if (this.PropertyId != null &&
                    value.PropertyId != null)
                    return (value.PropertyId == this.PropertyId);
            }

            return false;
        }

        #region IValidate Members

        public bool Validate()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}