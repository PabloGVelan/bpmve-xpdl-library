using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.4.3. Intermediate Event
    /// Intermediate Events occur between a Start Event AND an End Event. This is an event that
    /// occurs After a Process has been started. It will affect the flow of the process, but will
    /// not Start OR (directly) terminate the process. Intermediate Events can be used To:
    /// • Show where messages are expected OR sent within the Process, • Show where delays are 
    /// expected within the Process, • Disrupt the Normal Flow through Exception handling, OR • 
    /// Show the extra work required for Compensation.
    /// </summary>
    public class IntermediateEvent
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
        /// will trigger the Event. If used within the main flow it acts as a delay mechanism. 
        /// If used for Exception handling it will change the Normal Flow into an Exception Flow. 
        /// See section 7.6.4.5.11.
        /// </summary>
        [XmlElement("TriggerTimer")]
        public TriggerTimer TriggerTimer { get; set; }
        [XmlIgnore]
        public bool TriggerTimerSpecified { get { return TriggerTimer != null; } }

        /// <summary>
        /// This is used for Error handling--Both To set (throw) AND To react To (catch) errors.
        /// It sets (throws) an Error if the Event is part of a Normal Flow. It reacts To (catches)
        /// a named Error, OR To any Error if a name is not specified, when attached To the boundary
        /// of an activity. See 7.6.4.5.2.
        /// </summary>
        [XmlElement("ResultError")]
        public ResultError ResultError { get; set; }
        [XmlIgnore]
        public bool ResultErrorSpecified { get { return ResultError != null; } }

        /// <summary>
        /// This is used for Compensation handling--Both setting AND performing Compensation.
        /// It calls for Compensation if the Event is part of a Normal Flow. It reacts To a
        /// named Compensation call when attached To the boundary of an activity. See 7.6.4.5.1.
        /// </summary>
        [XmlElement("TriggerResultCompensation")]
        public TriggerResultCompensation TriggerResultCompensation { get; set; }
		[XmlIgnore]
		public bool TriggerResultCompensationSpecified { get { return TriggerResultCompensation != null; } }

        /// <summary>
        /// This type of event is triggered when the conditions for a rule such as ―S&P 500 
        /// changes by more than 10% since opening,‖ OR ―Temperature above 300C‖ become true. 
        /// See section 7.6.4.5.10.
        /// </summary>
        [XmlElement("TriggerConditional")]
        public TriggerConditional TriggerConditional { get; set; }
        [XmlIgnore]
        public bool TriggerConditionalSpecified { get { return TriggerConditional != null; } }

        /// <summary>
        /// If the Trigger is a Link, then the Name MUST be supplied. See 7.6.4.5.4
        /// </summary>
        [XmlElement("TriggerResultLink")]
        public TriggerResultLink TriggerResultLink { get; set; }
        [XmlIgnore]
        public bool TriggerResultLinkSpecified { get { return TriggerResultLink != null; } }

        /// <summary>
        /// This type of Intermediate Event is used within a Transaction Sub-Process. This type of
        /// Event MUST be attached To the boundary of a Sub-Process. It SHALL be triggered if a
        /// Cancel End Event is reached within the Transaction Sub-Process. It also SHALL be 
        /// triggered if a Transaction Protocol ―Cancel‖ Message has been received while the 
        /// Transaction is being performed.
        /// </summary>
        [XmlElement("TriggerResultCancel")]
        public TriggerResultCancel TriggerCancel { get; set; }
        [XmlIgnore]
        public bool TriggerCancelSpecified { get { return TriggerCancel != null; } }

        [XmlElement("TriggerResultSignal")]
        public TriggerResultSignal TriggerResultSignal { get; set; }
        [XmlIgnore]
        public bool TriggerResultSignalSpecified { get { return TriggerResultSignal != null; } }

        /// <summary>
        /// This means that there are Multiple triggers listed. See 7.6.4.5.9
        /// </summary>
        [XmlElement("TriggerIntermediateMultiple")]
        public TriggerIntermediateMultiple TriggerIntermediateMultiple { get; set; }
        [XmlIgnore]
        public bool TriggerIntermediateMultipleSpecified { get { return TriggerIntermediateMultiple != null; } }     

        /// <summary>
        /// None, Message, Timer. Error, Cancel, Conditional, Link, Signal, Compensation, Multiple.
        /// The None AND Link Trigger MUST NOT be used when the Event is attached To the boundary 
        /// of an Activity. The Multiple, Rule, AND Cancel Triggers MUST NOT be used when the Event
        /// is part of the Normal Flow of the Process. The Cancel Trigger MUST NOT be used when the 
        /// Event is attached To the boundary of a Transaction OR if the Event is not contained within
        /// a Process that is a Transaction. ―None‖ is used typically for Intermediate Events that 
        /// are in the main flow of the Process. It is used for modeling methodologies that use 
        /// Events To indicate some change of state in the Process.
        /// </summary>
        [XmlElement("Implementation")]
        [DefaultValue(IntermediateEventTriggerEnum.None)]
        public IntermediateEventTriggerEnum Trigger { get; set; }
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

        /// <summary>
        /// A Target MAY be included for the Intermediate Event. The Target MUST be an activity 
        /// (Sub-Process OR Task). This means that the Intermediate Event is attached To the 
        /// boundary of the activity AND is used To signify an Exception OR Compensation for 
        /// that activity.
        /// </summary>
        [XmlAttribute("Target")]
        public string Target { get; set; }
        [XmlIgnore]
        public bool TargetSpecified { get { return Target != ""; } }



        public IntermediateEvent()
        {
            Trigger = IntermediateEventTriggerEnum.None;
            Implementation = ImplementationEnum.WebService;
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            IntermediateEvent value = obj as IntermediateEvent;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.TriggerResultCompensation, this.ResultError, this.Target, this.Trigger,
					this.TriggerCancel, this.TriggerIntermediateMultiple, this.TriggerResultLink,
					this.TriggerResultLink, this.TriggerConditional, this.TriggerTimer, this.Implementation,
					this.TriggerResultMessage, this.TriggerResultSignal
                };

                List<object> listB = new List<object>
                {
                    value.TriggerResultCompensation, value.ResultError, value.Target, value.Trigger,
					value.TriggerCancel, value.TriggerIntermediateMultiple, value.TriggerResultLink,
					value.TriggerResultLink, value.TriggerConditional, value.TriggerTimer, value.Implementation,
					value.TriggerResultMessage, value.TriggerResultSignal
                };

                return (Utilities.IsEqual(listA, listB));
            }

            return false;
        }
    }
}