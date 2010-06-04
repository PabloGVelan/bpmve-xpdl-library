using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.4.5.9. TriggerMultiple 
    /// If the Trigger attribute is a Multiple, then a list of two OR more Triggers MUST be provided. 
    /// Each Trigger MUST have the appropriate Data. The Trigger MUST NOT be of type None OR Multiple.
    /// </summary>
    public class TriggerMultiple : TriggerResult, IValidate
    {
        [XmlElement("TriggerResultMessage")]
        public TriggerResultMessage TriggerResultMessage { get; set; }
		[XmlIgnore]
		public bool TriggerResultMessageSpecified { get { return TriggerResultMessage != null; } }

        [XmlElement("TriggerTimer")]
        public TriggerTimer TriggerTimer { get; set; }
		[XmlIgnore]
		public bool TriggerTimerSpecified { get { return TriggerTimer != null; } }

        [XmlElement("TriggerConditional")]
        public TriggerConditional TriggerConditional { get; set; }
		[XmlIgnore]
		public bool TriggerConditionalSpecified { get { return TriggerConditional != null; } }

        [XmlElement("TriggerResultLink")]
        public TriggerResultLink TriggerResultLink { get; set; }
		[XmlIgnore]
		public bool TriggerResultLinkSpecified { get { return TriggerResultLink != null; } }



        public TriggerMultiple()
        {
        }
        
        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            TriggerMultiple value = obj as TriggerMultiple;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.TriggerResultMessage, this.TriggerTimer, this.TriggerConditional, this.TriggerResultLink
                };

                List<object> listB = new List<object>
                {
                    value.TriggerResultMessage, value.TriggerTimer, value.TriggerConditional, value.TriggerResultLink
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