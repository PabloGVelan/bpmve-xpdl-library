using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.5.3.4. TaskReceive
    /// A TaskType of Receive MUST NOT have an outgoing Message Flow.
    /// A Receive Task is a Simple Task that is designed To wait for a Message To arrive From an 
    /// external participant (relative To the Business Process). Once the Message has been received,
    /// the Task is Completed. A Receive Task is often used To Start a Process. In a sense, the 
    /// Process is bootstrapped by the receipt of the Message. In order for the Task To Instantiate 
    /// the Process it must meet One of the following conditions:
    /// The Process does not have a Start Event AND the Receive Task has no incoming Sequence Flow 
    /// The Incoming Sequence Flow for the Receive Task has a source of a Start Event.
    /// o	Note that no Other incoming Sequence Flows are allowed for the Receive Task (in particular, 
    /// a loop connection From a downstream object).
    /// </summary>
    public class TaskReceive : IValidate
    {
        /// <summary>
        /// A Message for the Message attribute Should be entered as an implementation detail. 
        /// This indicates that the Message will be received by the Task. The Message in this
        /// context is equivalent To an in-only Message pattern (Web Service). One OR more 
        /// corresponding incoming Message Flows MAY be shown on the diagram. However, the
        /// display of the Message Flow is not required. The Message is applied To All incoming
        /// Message Flow, but can arrive for only One of the incoming Message Flow for a single 
        /// instance of the Task. See section 7.9.4.
        /// </summary>
        [XmlElement("Message")]
        public Message Message { get; set; }
		[XmlIgnore]
		public bool MessageSpecified { get { return Message != null; } }

        /// <summary>
        /// Describes the web Service operation To be used by this task. (See section 7.9.6)
        /// </summary>
        [XmlElement("WebServiceOperation")]
        public WebServiceOperation WebserviceOperation { get; set; }
		[XmlIgnore]
		public bool WebserviceOperationSpecified { get { return WebserviceOperation != null; } }

        /// <summary>
        /// Receive Tasks can be defined as the instantiation mechanism for the Process with the
        /// Instantiate attribute. This attribute MAY be set To true if the Task is the first 
        /// activity After the Start Event OR a starting Task if there is no Start Event. Multiple
        /// Tasks MAY have this attribute set To True.
        /// </summary>
        [XmlAttribute("Instantiate")]
        [DefaultValue(false)]
        public bool IsInstantiate { get; set; }
        //[XmlIgnore]
        //public bool IsInstantiateSpecified { get { return IsInstantiate != null; } }

        /// <summary>
        /// WebService | Other | Unspecified
        /// </summary>
        [XmlAttribute("Implementation")]
        [DefaultValue(ImplementationEnum.WebService)]
        public ImplementationEnum Implementation { get; set; }
        //[XmlIgnore]
        //public bool ImplementationSpecified { get { return Implementation != null; } }



        public TaskReceive()
        {
            IsInstantiate = false;
            Implementation = ImplementationEnum.WebService;
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            TaskReceive value = obj as TaskReceive;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Implementation, this.Message, this.WebserviceOperation, this.IsInstantiate
                };

                List<object> listB = new List<object>
                {
                    value.Implementation, value.Message, value.WebserviceOperation, value.IsInstantiate
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