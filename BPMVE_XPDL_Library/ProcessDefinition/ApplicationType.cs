using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.3.2. Application Types
    /// Application Type contains several pieces of information required by common applications such as calling an EJB component OR invoking a WebService. Support for a particular application type is not mandatory for the engine, but if the engine makes use of the listed technologies the additional information should be provided by Application Type.
    /// </summary>
    public class ApplicationType : IValidate
    {
        [XmlElement("Ejb")]
        public ApplicationType_EJB EJB { get; set; }
        [XmlIgnore]
        public bool EJBSpecified { get { return EJB != null; } }

        [XmlElement("Pojo")]
        public ApplicationType_POJO POJO { get; set; }
        [XmlIgnore]
        public bool POJOSpecified { get { return POJO != null; } }

        [XmlElement("Xslt")]
        public ApplicationType_XSLT XSLT { get; set; }
        [XmlIgnore]
        public bool XSLTSpecified { get { return XSLT != null; } }

        [XmlElement("Script")]
        public ApplicationType_Script Script { get; set; }
        [XmlIgnore]
        public bool ScriptSpecified { get { return Script != null; } }

        [XmlElement("WebService")]
        public ApplicationType_WebService WebService { get; set; }
        [XmlIgnore]
        public bool WebServiceSpecified { get { return WebService != null; } }

        [XmlElement("BusinessRule")]
        public ApplicationType_BusinessRule BusinessRule { get; set; }
        [XmlIgnore]
        public bool BusinessRuleSpecified { get { return BusinessRule != null; } }

        [XmlElement("Form")]
        public ApplicationType_Form Form { get; set; }
        [XmlIgnore]
        public bool FormSpecified { get { return Form != null; } }



        public ApplicationType()
        {
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            ApplicationType value = obj as ApplicationType;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.EJB, this.WebService, this.POJO, this.BusinessRule, 
					this.Script, this.Form, this.XSLT
                };

                List<object> listB = new List<object>
                {
                    value.EJB, value.WebService, value.POJO, value.BusinessRule, 
					value.Script, value.Form, value.XSLT
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