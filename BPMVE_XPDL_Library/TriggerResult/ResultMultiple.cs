using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class ResultMultiple : TriggerResult, IValidate
    {
        [XmlElement("TriggerResultMessage")]
        public TriggerResultMessage TriggerResultMessage { get; set; }
		[XmlIgnore]
		public bool TriggerResultMessageSpecified { get { return TriggerResultMessage != null; } }

        [XmlElement("TriggerResultLink")]
        public TriggerResultLink TriggerResultLink { get; set; }
		[XmlIgnore]
		public bool TriggerResultLinkSpecified { get { return TriggerResultLink != null; } }

        [XmlElement("TriggerResultCompensation")]
        public TriggerResultCompensation TriggerResultCompensation { get; set; }
		[XmlIgnore]
		public bool TriggerResultCompensationSpecified { get { return TriggerResultCompensation != null; } }

        [XmlElement("ResultError")]
        public ResultError ResultError { get; set; }
		[XmlIgnore]
		public bool ResultErrorSpecified { get { return ResultError != null; } }



        public ResultMultiple()
        {
        }
        
        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            ResultMultiple value = obj as ResultMultiple;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.TriggerResultMessage, this.TriggerResultLink, this.TriggerResultCompensation, this.ResultError
                };

                List<object> listB = new List<object>
                {
                    value.TriggerResultMessage, value.TriggerResultLink, value.TriggerResultCompensation, value.ResultError
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