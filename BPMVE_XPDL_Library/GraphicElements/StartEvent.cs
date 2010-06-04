using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.4.2. Start Event
    /// As the name implies, the Start Event indicates where a particular Process will Start. 
    /// In terms of Sequence Flow, the Start Event starts the flow of the Process, AND thus, 
    /// will not have any incoming Sequence Flow—no Sequence Flow can connect To a Start Event.
    /// </summary>
    public class StartEvent : IValidate
    {
        /// <summary>
        /// See section 7.6.4.5.5.
        /// </summary>
        [XmlElement("TriggerResultMessage")]
        public TriggerResultMessage TriggerResultMessage { get; set; }
        [XmlIgnore]
        public bool TriggerResultMessageSpecified { get { return TriggerResultMessage != null; } }

        /// <summary>
        /// A specific time-date OR a specific cycle (e.g., every Monday at 9am) can be set that
        /// will trigger the Start of the Process. See section 7.6.4.5.11.
        /// </summary>
        [XmlElement("TriggerTimer")]
        public TriggerTimer TriggerTimer { get; set; }
        [XmlIgnore]
        public bool TriggerTimerSpecified { get { return TriggerTimer != null; } }

        /// <summary>
        /// This type of event is triggered when the conditions for a rule such as ―S&P 500 changes
        /// by more than 10% since opening,‖ OR ―Temperature above 300C‖ become true. 
        /// See section 7.6.4.5.10.
        /// </summary>
        [XmlElement("TriggerConditional")]
        public TriggerConditional TriggerConditional { get; set; }
        [XmlIgnore]
        public bool TriggerConditionalSpecified { get { return TriggerConditional != null; } }

        [XmlElement("TriggerResultSignal")]
        public TriggerResultSignal TriggerResultSignal { get; set; }
        [XmlIgnore]
        public bool TriggerResultSignalSpecified { get { return TriggerResultSignal != null; } }

        /// <summary>
        /// This means that there are Multiple ways of triggering the Process. Only One of them 
        /// will be required To Start the Process. The attributes of the Start Event will define
        /// which of the Other types of Triggers apply. See section 7.6.4.5.9.
        /// </summary>
        [XmlElement("TriggerMultiple")]
        public TriggerMultiple TriggerMultiple { get; set; }
        [XmlIgnore]
        public bool TriggerMultipleSpecified { get { return TriggerMultiple != null; } }

        /// <summary>
        /// None, Message, Timer. Conditional, Signal, Multiple. ―None‖ is used typically for 
        /// subflow invocations, including embedded subflows.
        /// </summary>
        [XmlAttribute("Trigger")]
        [DefaultValue(StartEventTriggerEnum.None)]
        public StartEventTriggerEnum Trigger { get; set; }
        //[XmlIgnore]
        //public bool TriggerSpecified { get { return Trigger != null; } }

        /// <summary>
        /// WebService | Other | Unspecified	See 7.9.6.
        /// </summary>
        [XmlAttribute("Implementation")]
        [DefaultValue(ImplementationEnum.WebService)]
        public ImplementationEnum Implementation { get; set; }
        //[XmlIgnore]
        //public bool ImplementationSpecified { get { return Implementation != null; } }




        public StartEvent()
        {
            Trigger = StartEventTriggerEnum.None;
            Implementation = ImplementationEnum.WebService;
        }
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            StartEvent value = obj as StartEvent;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Trigger, this.TriggerConditional, this.TriggerMultiple, this.TriggerResultMessage,
					this.TriggerResultSignal, this.TriggerTimer, this.Implementation
                };

                List<object> listB = new List<object>
                {
                    value.Trigger, value.TriggerConditional, value.TriggerMultiple, value.TriggerResultMessage,
					value.TriggerResultSignal, value.TriggerTimer, value.Implementation
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