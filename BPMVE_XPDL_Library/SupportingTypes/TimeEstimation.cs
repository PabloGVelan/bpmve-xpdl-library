using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class TimeEstimation : IValidate
    {
        /// <summary>
        /// Describes the amount of time, which is needed To prepare the performance of the task 
        /// (time estimation) (waiting time is provided by the analysis environment AND may be 
        /// updated by the runtime environment) in units of DurationUnit.
        /// </summary>
        [XmlElement("WaitingTime")]
        public Time WaitingTime { get; set; }
        [XmlIgnore]
        public bool WaitingTimeSpecified { get { return WaitingTime != null; } }

        /// <summary>
        /// Describes the amount of time the performer of the activity needs To perform the task 
        /// (time estimation) (working time is needed for analysis purposes AND is provided by 
        /// the evaluation of runtime parameters) in units of DurationUnit.
        /// </summary>
        [XmlElement("WorkingTime")]
        public Time WorkingTime { get; set; }
        [XmlIgnore]
        public bool WorkingTimeSpecified { get { return WorkingTime != null; } }

        /// <summary>
        /// Expected duration time To perform a task in units of DurationUnit.
        /// </summary>
        [XmlElement("Duration")]
        public Duration Duration { get; set; }
        [XmlIgnore]
        public bool DurationSpecified { get { return Duration != null; } }



        public TimeEstimation()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            TimeEstimation value = obj as TimeEstimation;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.WaitingTime, this.WorkingTime, this.Duration
                };

                List<object> listB = new List<object>
                {
                    value.WaitingTime, value.WorkingTime, value.Duration
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