using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class ExtendedAttribute : IValidate
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }
		[XmlIgnore]
		public bool NameSpecified { get { return !string.IsNullOrEmpty(Name); } }

        [XmlAttribute("Value")]
        public string Value { get; set; }
		[XmlIgnore]
		public bool ValueSpecified { get { return !string.IsNullOrEmpty(Value); } }



        public ExtendedAttribute()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            ExtendedAttribute value = obj as ExtendedAttribute;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Name, this.Value
                };

                List<object> listB = new List<object>
                {
                    value.Name, value.Value
                };

                return (Utilities.IsEqual(listA, listB));
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