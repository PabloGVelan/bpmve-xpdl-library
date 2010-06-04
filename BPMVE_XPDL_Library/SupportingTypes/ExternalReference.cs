using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class ExternalReference : IValidate
    {
        [XmlAttribute("xref")]
        public string Xref { get; set; }
        [XmlIgnore]
        public bool XrefSpecified { get { return Xref != ""; } }

        [XmlAttribute("location")]
        public string Location { get; set; }
        [XmlIgnore]
        public bool LocationSpecified { get { return Location != ""; } }

        [XmlAttribute("namespace")]
        public string Namespace_XPDL { get; set; }
        [XmlIgnore]
        public bool Namespace_XPDLSpecified { get { return Namespace_XPDL != ""; } }



        public ExternalReference()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            ExternalReference value = obj as ExternalReference;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Xref, this.Location, this.Namespace_XPDL
                };

                List<object> listB = new List<object>
                {
                    value.Xref, value.Location, value.Namespace_XPDL
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