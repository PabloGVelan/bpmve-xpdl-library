using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.4.5.1. TriggerResultCompensation
    /// For an End Event: If the Result is a Compensation, then the Activity that needs To be 
    /// compensated MAY be supplied. If an Activity is not supplied, then the Event is broadcast
    /// To All Completed activities in the Process Instance.
    /// For an Intermediate Event within Normal Flow: If the Trigger is a Compensation, then the 
    /// Activity that needs To be compensated MAY be supplied. If an Activity is not supplied, 
    /// then the Event is broadcast To All Completed activities in the Process Instance. This 
    /// ―throws‖ the Compensation.
    /// For an Intermediate Event attached To the boundary of an Activity: This Event ―catches‖ 
    /// the Compensation. No further information is required. The Id of the activity the Event 
    /// is attached To will provide the Id necessary To match the Compensation event with the 
    /// event that ―threw‖ the Compensation.
    /// </summary>
    public class TriggerResultCompensation : TriggerResult, IValidate
    {
        /// <summary>
        /// This supplies the Id of the Activity To be Compensated. Used only for intermediate 
        /// events OR End events in the seuence flow. Events attached To the boundary of an 
        /// activity already know the Id.
        /// </summary>
        [XmlAttribute("ActivityId")]
        public string ActivityId { get; set; }
		[XmlIgnore]
		public bool ActivityIdSpecified { get { return ActivityId != ""; } }


        public TriggerResultCompensation()
        {
        }
        
        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            TriggerResultCompensation value = obj as TriggerResultCompensation;
            if (value != null)
            {
                if (this.ActivityId != null &&
                    value.ActivityId != null)
                    return (value.ActivityId == this.ActivityId);
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