using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.4.4. End Event
    /// As the name implies, the End Event indicates where a process will End. In terms of Sequence 
    /// Flow, the End Event ends the flow of the Process, AND thus, will not have any outgoing
    /// Sequence Flow—no Sequence Flow can connect From an End Event.
    /// An End Event consumes a Token that had been generated From a Start Event within the same 
    /// level of Process. If Parallel Sequence Flows target the End Event, then the Tokens will be
    /// consumed as they arrive. All the Tokens that were generated within the Process must be 
    /// consumed by an End Event Before the Process has been Completed. In Other circumstances, 
    /// if the Process is a Sub-Process, it can be stopped prior To normal completion through 
    /// interrupting Intermediate Events. In this situation the Tokens will be consumed by an
    /// Intermediate Event attached To the boundary of the Sub-Process.
    /// </summary>
    public class EndEvent : IValidate
    {
        /// <summary>
        /// See section 7.6.4.5.5.
        /// </summary>
        [XmlElement("TriggerResultMessage")]
        public TriggerResultMessage TriggerResultMessage { get; set; }
        [XmlIgnore]
        public bool TriggerResultMessageSpecified { get { return TriggerResultMessage != null; } }

        /// <summary>
        /// This type of End indicates that a named Error should be generated. This Error will 
        /// be caught by an Intermediate Event within the Event Context. See section 7.6.4.5.2.
        /// </summary>
        [XmlElement("ResultError")]
        public ResultError ResultError { get; set; }
        [XmlIgnore]
        public bool ResultErrorSpecified { get { return ResultError != null; } }

        /// <summary>
        /// This type of End will indicate that a Compensation is necessary. The Compensation
        /// identifier will trigger an Intermediate Event when the Process is rolling back. 
        /// See section 7.6.4.5.1,
        /// </summary>
        [XmlElement("TriggerResultCompensation")]
        public TriggerResultCompensation TriggerResultCompensation { get; set; }
        [XmlIgnore]
        public bool TriggerResultCompensationSpecified { get { return TriggerResultCompensation != null; } }

        [XmlElement("TriggerResultSignal")]
        public TriggerResultSignal TriggerResultSignal { get; set; }
        [XmlIgnore]
        public bool TriggerResultSignalSpecified { get { return TriggerResultSignal != null; } }

        /// <summary>
        /// This means that there are Multiple consequences of ending the Process. All of them 
        /// will occur (e.g., there might be Multiple messages sent). The attributes of the End 
        /// Event will define which of the Other types of Results apply.See section 7.6.4.5.3.
        /// </summary>
        [XmlElement("ResultMultiple")]
        public ResultMultiple ResultMultiple { get; set; }
        [XmlIgnore]
        public bool ResultMultipleSpecified { get { return ResultMultiple != null; } }

        /// <summary>
        /// None, Message, Error, Cancel, Compensation, Signal, Terminate, Multiple.
        ///  None‘ is used when the modeler does not display the type of Event. It is also used 
        ///  To show the End of a Sub-Process that ends, which causes the flow goes back To its 
        ///  Parent Process.
        /// ―Terminate‖ indicates that All activities in the Process should be immediately ended. 
        /// This includes All instances of Multi-Instances. The Process is ended without 
        /// Compensation OR event handling.
        /// </summary>
        [XmlAttribute("Result")]
        [DefaultValue(EndEventTriggerEnum.None)]
        public EndEventTriggerEnum Result { get; set; }
        //[XmlIgnore]
        //public bool ResultSpecified { get { return Result != null; } }
        
        /// <summary>
        /// WebService | Other | Unspecified	See 7.9.6.
        /// </summary>
        [XmlAttribute("Implementation")]
        [DefaultValue(ImplementationEnum.WebService)]
        public ImplementationEnum Implementation { get; set; }
        //[XmlIgnore]
        //public bool ImplementationSpecified { get { return Implementation != null; } }



        public EndEvent()
        {
            Result = EndEventTriggerEnum.None;
            Implementation = ImplementationEnum.WebService;
        }
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            EndEvent value = obj as EndEvent;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Result, this.TriggerResultCompensation, this.ResultError, this.ResultMultiple, 
                    this.Implementation, this.TriggerResultMessage, this.TriggerResultSignal
                };

                List<object> listB = new List<object>
                {
                    value.Result, value.TriggerResultCompensation, value.ResultError, value.ResultMultiple, 
                    value.Implementation, value.TriggerResultMessage, value.TriggerResultSignal
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