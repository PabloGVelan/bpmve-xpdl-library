using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.4.5.5. TriggerResultMessage
    /// For Start Event:A Message arrives [CATCH] AND starts the Process.
    /// For End Event: This type of End indicates that a Message is sent [THROW] at the conclusion
    /// of the Process.
    /// For Intermediate Event: A Message arrives From a participant AND triggers the Event. This
    /// causes the Process To continue if it was waiting for the Message, OR changes the flow for 
    /// Exception handling. In Normal Flow, Message Intermediate Events can be used for sending 
    /// messages To a participant. If used for Exception handling it will change the Normal Flow 
    /// into an Exception Flow.
    /// </summary>
    public class TriggerResultMessage : TriggerResult, IValidate
    {
        /// <summary>
        /// Describes the Message (See section 7.9.4).
        /// </summary>
        [XmlElement("Message")]
        public Message Message { get; set; }
		[XmlIgnore]
		public bool MessageSpecified { get { return Message != null; } }

        /// <summary>
        /// Describes the web services operation (See section 7.9.6)
        /// </summary>
        [XmlElement("ExtendedAttributes")]
        public WebServiceOperation WebServiceOperation{ get; set; }
		[XmlIgnore]
		public bool WebServiceOperationSpecified { get { return WebServiceOperation != null; } }

        [XmlAttribute("CatchThrow")]
        [DefaultValue(CatchThrowEnum.Catch)]
        public CatchThrowEnum CatchThrow { get; set; }
        //[XmlIgnore]
        //public bool CatchThrowSpecified { get { return CatchThrow != null; } }


        public TriggerResultMessage()
        {
            CatchThrow = CatchThrowEnum.Catch;
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            TriggerResultMessage value = obj as TriggerResultMessage;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Message, this.WebServiceOperation, this.CatchThrow
                };

                List<object> listB = new List<object>
                {
                    value.Message, value.WebServiceOperation, value.CatchThrow
                };

                return (Utilities.IsEqual(listA, listB));
            }

            return false;
        }

        #region IValidate Members

        public bool Validate()
        {
            return true;
        }

        #endregion
    }
}