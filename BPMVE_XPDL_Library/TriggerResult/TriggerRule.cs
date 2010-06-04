using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// BPMN: if the TriggerType is Rule then this must be present. Deprecated in BPMN1.1
    /// </summary>
    public class TriggerRule : TriggerResult, IValidate
    {
        /// <summary>
        /// This is the nameof a Rule element. Deprecated in BPMN1.1.
        /// </summary>
        [XmlAttribute("RuleName")]
        public string RuleName { get; set; }
		[XmlIgnore]
		public bool RuleNameSpecified { get { return RuleName != ""; } }


        public TriggerRule()
        {
            RuleName = "";
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            TriggerRule value = obj as TriggerRule;
            if (value != null)
            {
                if (this.RuleName != null &&
                    value.RuleName != null)
                    return (value.RuleName == this.RuleName);
            }

            return false;
        }

        #region IValidate Members

        public bool Validate()
        {
            if (string.IsNullOrEmpty(RuleName))
                return false;
            return true;
        }

        #endregion
    }
}
