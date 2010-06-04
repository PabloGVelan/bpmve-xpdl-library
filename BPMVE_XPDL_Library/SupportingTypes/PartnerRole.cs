using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class PartnerRole : IValidate
    {
        [XmlElement("EndPoint")]
        public EndPoint EndPoint { get; set; }
		[XmlIgnore]
		public bool EndPointSpecified { get { return EndPoint != null; } }

        [XmlAttribute("RoleName")]
        public string RoleName { get; set; }
		[XmlIgnore]
		public bool RoleNameSpecified { get { return RoleName != ""; } }

        [XmlAttribute("ServiceName")]
        public string ServiceName { get; set; }
		[XmlIgnore]
		public bool ServiceNameSpecified { get { return ServiceName != ""; } }

        [XmlAttribute("PortName")]
        public string PortName { get; set; }
		[XmlIgnore]
		public bool PortNameSpecified { get { return PortName != ""; } }



        public PartnerRole()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            PartnerRole value = obj as PartnerRole;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.EndPoint, this.RoleName, this.ServiceName, this.PortName
                };

                List<object> listB = new List<object>
                {
                    value.EndPoint, value.RoleName, value.ServiceName, value.PortName
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