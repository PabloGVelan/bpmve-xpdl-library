using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.4.5.8. TriggerIntermediateMultiple 
    /// If the Trigger is a Multiple, then each Trigger on the list MUST have the appropriate 
    /// Data as specified for the attributes. The Trigger MUST NOT be of type None OR Multiple.
    /// </summary>
    public class TriggerIntermediateMultiple : TriggerResult, IValidate
    {
        [XmlElement("TriggerResultMessage")]
        public TriggerResultMessage TriggerResultMessage { get; set; }
		[XmlIgnore]
		public bool TriggerResultMessageSpecified { get { return TriggerResultMessage != null; } }

        [XmlElement("TriggerTimer")]
        public TriggerTimer TriggerTimer { get; set; }
		[XmlIgnore]
		public bool TriggerTimerSpecified { get { return TriggerTimer != null; } }

        [XmlElement("ResultError")]
        public ResultError ResultError { get; set; }
		[XmlIgnore]
		public bool ResultErrorSpecified { get { return ResultError != null; } }

        [XmlElement("TriggerResultCompensation")]
        public TriggerResultCompensation TriggerResultCompensation { get; set; }
		[XmlIgnore]
		public bool TriggerResultCompensationSpecified { get { return TriggerResultCompensation != null; } }

        [XmlElement("TriggerConditional")]
        public TriggerConditional TriggerConditional { get; set; }
		[XmlIgnore]
		public bool TriggerConditionalSpecified { get { return TriggerConditional != null; } }

        [XmlElement("TriggerResultLink")]
        public TriggerResultLink TriggerResultLink { get; set; }
		[XmlIgnore]
		public bool TriggerResultLinkSpecified { get { return TriggerResultLink != null; } }



        public TriggerIntermediateMultiple()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            TriggerIntermediateMultiple value = obj as TriggerIntermediateMultiple;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.TriggerResultMessage, this.TriggerTimer, this.TriggerResultCompensation, 
                    this.ResultError, this.TriggerConditional, this.TriggerResultLink
                };

                List<object> listB = new List<object>
                {
                    value.TriggerResultMessage, value.TriggerTimer, value.TriggerResultCompensation,
                    value.ResultError, value.TriggerConditional, value.TriggerResultLink
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