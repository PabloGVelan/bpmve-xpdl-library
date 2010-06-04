using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class PartnerLink : IValidate
    {
        [XmlElement("MyRole")]
        public MyRole MyRole { get; set; }
		[XmlIgnore]
		public bool MyRoleSpecified { get { return MyRole != null; } }

        [XmlElement("PartnerRole")]
        public PartnerRole PartnerRole { get; set; }
		[XmlIgnore]
		public bool PartnerRoleSpecified { get { return PartnerRole != null; } }

        [XmlAttribute("name")]
        public string Name { get; set; }
		[XmlIgnore]
		public bool NameSpecified { get { return Name != ""; } }

        [XmlAttribute("Id")]
        public string Id { get; set; }

        [XmlAttribute("PartnerLinkTypeId")]
        public string PartnerLinkTypeId { get; set; }
		[XmlIgnore]
		public bool PartnerLinkTypeIdSpecified { get { return PartnerLinkTypeId != ""; } }


        public PartnerLink()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            PartnerLink value = obj as PartnerLink;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.MyRole, this.Id, this.Name, this.PartnerRole, this.PartnerLinkTypeId
                };

                List<object> listB = new List<object>
                {
                    value.MyRole, value.Id, value.Name, value.PartnerRole, value.PartnerLinkTypeId
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