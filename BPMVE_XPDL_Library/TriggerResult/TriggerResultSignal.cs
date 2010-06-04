using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.4.5.7. TriggerResultSignal
    /// A Signal is for general communication within AND across Process Levels, across Pools, 
    /// AND between Business Process Diagrams. A BPMN Signal is similar To a Dignal flare tha
    /// t shot into the sky for anyone who might be interested To notice AND then react. Thus,
    /// there is a source of the Signal, but no specific intended target. This is different than
    /// a BPMN Message, which has a specific Source AND a specific Target (which can be an Entity
    /// OR an abstract Role).
    /// For Start Event: A Dignal arrives [CATCH] that has been broadcast From another Process
    /// AND triggers the Start of the Process. Note that the Signal is not a Message, which has
    /// a specific target for the Message. Multiple Processes can have Start Events that are 
    /// triggered From the same broadcasted Signal. For End Event: This type of End indicates
    /// that a Signal will be broadcast [THROW] when the End has been reached. Note that the 
    /// Signal, which is broadcast To any Process that can receive the Signal, can be sent 
    /// across Process levels OR Pools, but is not a Message (which has a specific Source AND
    /// Target).
    /// For Intermediate Event: This type of Intermediate Event can send [THROW] OR receive 
    /// [CATCH] a Signal if the Event is part of a Normal Flow. The Event can only receive a 
    /// Signal when attached To the boundary of an activity. The Signal Event differs From an 
    /// Error Event in that the Signal defines a more general, non-Error Condition for 
    /// interrupting activities (such as the successful completion of another activity) as 
    /// well as having a larger scope than Error Events. When used To ―catch‖ the Dignal, the
    /// Event marker will be unfilled. When used To ―throw‖ the Dignal, the Event marker will 
    /// be filled.
    /// </summary>
    public class TriggerResultSignal : TriggerResult, IValidate
    {
        /// <summary>
        /// Multiple Properties MAY be entered for the Signal
        /// </summary>
        [XmlArray("Properties")]
        public List<Expression> Properties { get; set; }
        [XmlIgnore]
        public bool PropertiesSpecified { get { return Properties == null ? false : Properties.Count != 0; } }

        /// <summary>
        /// Name is an attribute that is text description of the Signal.
        /// </summary>
        [XmlAttribute("Name")]
        public string Name { get; set; }
		[XmlIgnore]
		public bool NameSpecified { get { return Name != ""; } }

        [XmlAttribute("CatchThrow")]
        [DefaultValue(CatchThrowEnum.Catch)]
        public CatchThrowEnum CatchThrow { get; set; }
        //[XmlIgnore]
        //public bool CatchThrowSpecified { get { return CatchThrow != null; } }



        public TriggerResultSignal()
        {
            CatchThrow = CatchThrowEnum.Catch;
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            TriggerResultSignal value = obj as TriggerResultSignal;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Name, this.CatchThrow
                };

                List<object> listB = new List<object>
                {
                    value.Name, value.CatchThrow
                };

                if (!Utilities.IsListEqual<Expression>(this.Properties, value.Properties))
                    return false;

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