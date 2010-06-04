using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class Partner : IValidate
    {
        [XmlAttribute("PartnerLinkId")]
        public string PartnerLinkId { get; set; }
		[XmlIgnore]
		public bool PartnerLinkIdSpecified { get { return PartnerLinkId != ""; } }

        [XmlAttribute("RoleType")]
        [DefaultValue(RoleTypeEnum.MyRole)]
        public RoleTypeEnum RoleType { get; set; }
        //[XmlIgnore]
        //public bool RoleTypeSpecified { get { return RoleType != null; } }



        public Partner()
        {
            RoleType = RoleTypeEnum.MyRole;
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Partner value = obj as Partner;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.PartnerLinkId, this.RoleType
                };

                List<object> listB = new List<object>
                {
                    value.PartnerLinkId, value.RoleType
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