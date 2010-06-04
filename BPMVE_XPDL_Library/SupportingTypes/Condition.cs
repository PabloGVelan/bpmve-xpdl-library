using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Reflection;
using System.Collections;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.7.1. Condition
    /// </summary>
    public class Condition : IValidate
    {
        /// <summary>
        /// A Condition expression represented via XML markup.
        /// </summary>
        [XmlElement("Expression")]
        public Expression Expression { get; set; }
		[XmlIgnore]
		public bool ExpressionSpecified { get { return Expression != null; } }

        /// <summary>
        /// Define the type of transition Condition.
        /// </summary>
        [XmlAttribute("Type")]
        [DefaultValue(ConditionTypeEnum.Condition)]
        public ConditionTypeEnum Type { get; set; }
        //[XmlIgnore]
        //public bool TypeSpecified { get { return Type != null; } }



        public Condition()
        {
            Type = ConditionTypeEnum.Condition;
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Condition value = obj as Condition;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Expression, this.Type
                };

                List<object> listB = new List<object>
                {
                    value.Expression, value.Type
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