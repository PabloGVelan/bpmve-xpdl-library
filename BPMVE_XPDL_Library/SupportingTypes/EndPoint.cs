using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class EndPoint : IValidate
    {
        [XmlElement("ExternalReference")]
        public ExternalReference ExternalReference { get; set; }
		[XmlIgnore]
		public bool ExternalReferenceSpecified { get { return ExternalReference != null; } }

        [XmlAttribute("EndPointType")]
        [DefaultValue(EndPointTypeEnum.WSDL)]
        public EndPointTypeEnum EndPointType { get; set; }
        //[XmlIgnore]
        //public bool EndPointTypeSpecified { get { return EndPointType != null; } }



        public EndPoint()
        {
            EndPointType = EndPointTypeEnum.WSDL;
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            EndPoint value = obj as EndPoint;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.ExternalReference, this.EndPointType
                };

                List<object> listB = new List<object>
                {
                    value.ExternalReference, value.EndPointType
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