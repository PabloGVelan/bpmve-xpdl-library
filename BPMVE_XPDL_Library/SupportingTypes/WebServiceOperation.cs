using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class WebServiceOperation : IValidate
    {
        [XmlElement("Service")]
        public Service Service { get; set; }
        [XmlIgnore]
        public bool ServiceSpecified { get { return Service != null; } }

        [XmlElement("Partner")]
        public Partner Partner { get; set; }
        [XmlIgnore]
        public bool PartnerSpecified { get { return Partner != null; } }

        [XmlAttribute("OperationName")]
        public string OperationName { get; set; }
        [XmlIgnore]
        public bool OperationNameSpecified { get { return !string.IsNullOrEmpty(OperationName); } }



        public WebServiceOperation()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            WebServiceOperation value = obj as WebServiceOperation;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.OperationName, this.Service, this.Partner
                };

                List<object> listB = new List<object>
                {
                    value.OperationName, value.Service, value.Partner
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