using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.4.5.10. Trigger Conditional
    /// If the Trigger is a Conditional, then a Condition MUST be entered.
    /// For Intermediate Event: This is only used for Exception handling. This type of event is 
    /// triggered when a Condition becomes true. A Condition is an expression that evaluates some
    /// Process Data.
    /// </summary>
    public class TriggerConditional : TriggerResult, IValidate
    {
        /// <summary>
        /// A ConditionExpression may be entered. In some cases the Condition itself will be stored
        /// AND maintained in a separate application (e.g., a Rules Engine). If a ConditionExpression
        /// is not entered, then a Name MUST be entered (see the attribute above).
        /// </summary>
        [XmlElement("Expression")]
        public Expression Expression { get; set; }
        [XmlIgnore]
        public bool ExpressionSpecified { get { return Expression != null; } }
        
        /// <summary>
        /// Name is an optional attribute that is a text description of the Condition. If a Name 
        /// is not entered, then a ConditionExpression MUST be entered (see the attribute below).
        /// </summary>
        [XmlAttribute("ConditionName")]
        public string ConditionName { get; set; }
		[XmlIgnore]
		public bool ConditionNameSpecified { get { return ConditionName != ""; } }



        public TriggerConditional()
        {
        }
        
        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            TriggerConditional value = obj as TriggerConditional;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.ConditionName, this.Expression
                };

                List<object> listB = new List<object>
                {
                    value.ConditionName, value.Expression
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