using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.3.2.1. EJB
    /// Application type that defines information required To call a method of an EJB component. 
    /// An EJB application has additional restrictions for formal parameters: there can be a 
    /// maximum of One OUT formal parameter, AND if it exists it has To be the last formal 
    /// parameter, also there should be no INOUT formal parameters. With these restrictions 
    /// IN formal parameters map directly To arguments of the method AND the optional last 
    /// OUT formal parameter becomes the return value of the method.
    /// </summary>
    [XmlType("Ejb")]
    public class ApplicationType_EJB : IValidate
    {
        [XmlElement("JndiName")]
        public string JndiName { get; set; }
        [XmlIgnore]
        public bool JndiNameSpecified { get { return JndiName != ""; } }

        [XmlElement("HomeClass")]
        public string HomeClass { get; set; }
        [XmlIgnore]
        public bool HomeClassSpecified { get { return HomeClass != ""; } }

        [XmlElement("Method")]
        public string Method { get; set; }
        [XmlIgnore]
        public bool MethodSpecified { get { return Method != ""; } }



        public ApplicationType_EJB()
        {
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            ApplicationType_EJB value = obj as ApplicationType_EJB;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.JndiName, this.HomeClass, this.Method
                };

                List<object> listB = new List<object>
                {
                    value.JndiName, value.HomeClass, value.Method
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