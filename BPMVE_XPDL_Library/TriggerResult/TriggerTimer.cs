using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.4.5.11. Trigger Timer
    /// If the Trigger is a Timer, then a TimeDate MAY be entered. If a TimeDate is not entered, 
    /// then a TimeCycle MUST be entered (see the elements below).
    /// </summary>
    public class TriggerTimer : TriggerResult, IValidate
    {
        /// <summary>
        /// Expression. Should evaluate To One of the Basic Types: DATETIME, DATE OR TIME. 
        /// (See section 7.13.1).
        /// </summary>
        [XmlElement("TimeDate")]
        public Expression TimeDate { get; set; }
		[XmlIgnore]
		public bool TimeDateSpecified { get { return TimeDate != null; } }

        /// <summary>
        /// Expression. Should evaluate To an INTEGER representing the milliseconds duration 
        /// of the cycle.
        /// </summary>
        [XmlElement("TimeCycle")]
        public Expression TimeCycle { get; set; }
		[XmlIgnore]
		public bool TimeCycleSpecified { get { return TimeCycle != null; } }


        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            TriggerTimer value = obj as TriggerTimer;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.TimeDate, this.TimeCycle
                };

                List<object> listB = new List<object>
                {
                    value.TimeDate, value.TimeCycle
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