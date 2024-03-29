using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.3.2.5. Web Service
    /// Application that invokes a Web Service. All IN formal parameters should be mapped into 
    /// content of the input Message; All OUT formal parameters should be mapped To parts of 
    /// the output Message.
    /// </summary>
    public class ApplicationType_WebService : IValidate
    {
        /// <summary>
        /// The web Service operation used To invoke this application.
        /// </summary>
        [XmlElement("WebServiceOperation")]
        public WebServiceOperation WebServiceOperation{ get; set; }
		[XmlIgnore]
		public bool WebServiceOperationSpecified { get { return WebServiceOperation != null; } }

        /// <summary>
        /// Provides a way To catch faults generated by the application.
        /// </summary>
        [XmlElement("WebServiceFaultCatch")]
        public WebServiceFaultCatch WebserviceFaultCatch { get; set; }
		[XmlIgnore]
		public bool WebserviceFaultCatchSpecified { get { return WebserviceFaultCatch != null; } }

        /// <summary>
        /// The name of inputMessage as defined in the WSDL which will help in uniquely 
        /// identifying the operation To be invoked.
        /// </summary>
        [XmlAttribute("InputMsgName")]
        public string InputMsgName { get; set; }
        [XmlIgnore]
        public bool InputMsgNameSpecified { get { return InputMsgName != null; } }

        /// <summary>
        /// The name of outputMessage as defined in the WSDL which will help in uniquely 
        /// identifying the operation To be invoked.
        /// </summary>
        [XmlAttribute("OutputMsgName")]
        public string OutputMsgName { get; set; }
        [XmlIgnore]
        public bool OutputMsgNameSpecified { get { return OutputMsgName != null; } }



        public ApplicationType_WebService()
        {
        }
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            ApplicationType_WebService value = obj as ApplicationType_WebService;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.WebServiceOperation, this.WebserviceFaultCatch, this.InputMsgName, this.OutputMsgName
                };

                List<object> listB = new List<object>
                {
                    value.WebServiceOperation, value.WebserviceFaultCatch, value.InputMsgName, value.OutputMsgName
                };

                return (Utilities.IsEqual(listA, listB));
            }

            return false;
        }

        #region IValidate Members

        public bool Validate()
        {
            if (string.IsNullOrEmpty(InputMsgName))
                return false;
            return true;
        }

        #endregion
    }
}