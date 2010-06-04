using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class PartnerLinkType : IValidate
    {
        [XmlElement("Role")]
        public List<Role> Roles { get; set; }
		[XmlIgnore]
		public bool RolesSpecified { get { return Roles == null ? false : Roles.Count != 0; } }

        [XmlAttribute("Id")]
        public string Id { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }
		[XmlIgnore]
		public bool NameSpecified { get { return Name != ""; } }



        public PartnerLinkType()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            PartnerLinkType value = obj as PartnerLinkType;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Id, this.Name
                };

                List<object> listB = new List<object>
                {
                    value.Id, value.Name
                };

                if (!Utilities.IsListEqual<Role>(this.Roles, value.Roles))
                {
                    return false;
                }

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