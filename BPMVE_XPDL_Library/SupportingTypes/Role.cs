using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class Role : IValidate
    {
        [XmlAttribute("portType")]
        public string PortType { get; set; }
        [XmlIgnore]
        public bool PortTypeSpecified { get { return PortType != ""; } }

        [XmlAttribute("Name")]
        public string Name { get; set; }
		[XmlIgnore]
		public bool NameSpecified { get { return Name != ""; } }



        public Role()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Role value = obj as Role;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Name, this.PortType
                };

                List<object> listB = new List<object>
                {
                    value.Name, value.PortType
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