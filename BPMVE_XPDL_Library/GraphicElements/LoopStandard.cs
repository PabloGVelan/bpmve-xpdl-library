using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// A Standard Loop activity will have a bool expression that is evaluated After each cycle
    /// of the loop. If the expression is still True, then the loop will continue. There are two 
    /// variations of the loop, which reflect the programming constructs of while AND until. That 
    /// is, a while loop will evaluate the expression Before the activity is performed, which means
    /// that the activity may not actually be performed. The until loop will evaluate the expression
    /// After the activity has been performed, which means that the activity will be performed at 
    /// least once.
    /// Deprecated: LoopCondition(string) -> LoopCondition(ExpressionType)
    /// </summary>
    public class LoopStandard : IValidate
    {
        /// <summary>
        /// Standard Loops MUST have a bool Expression To be evaluated, plus the timing when the 
        /// expression SHALL be evaluated. LoopCondition can be either an attribute of type string
        /// OR an element of type xpdl:ExpressionType.
        /// </summary>
        [XmlElement("LoopCondition")]
        public Expression LoopCondition { get; set; }
        [XmlIgnore]
        public bool LoopConditionSpecified { get { return LoopCondition != null; } }

        [XmlAttribute("LoopCondition")]
        public string LoopConditionString { get; set; }
        [XmlIgnore]
        public bool LoopConditionStringSpecified { get { return string.IsNullOrEmpty(LoopConditionString); } }

        [XmlAttribute("LoopCounter")]
        [DefaultValue(0)]
        public int LoopCounter { get; set; }
        [XmlIgnore]
        public bool LoopCounterSpecified { get { return LoopCounter != 0; } }

        /// <summary>
        /// The Maximum an optional attribute that provides is a Simple way To add a cap To the
        /// number of loops. This SHALL be added To the Expression defined in the LoopCondition.
        /// </summary>
        [XmlAttribute("LoopMaximum")]
        [DefaultValue(0)]
        public int LoopMaximum { get; set; }
		[XmlIgnore]
		public bool LoopMaximumSpecified { get { return LoopMaximum != 0; } }

        /// <summary>
        /// The expressions that are evaluated Before the activity begins are equivalent To a
        /// programming while function. The expression that are evaluated After the activity 
        /// finishes are equivalent To a programming until function.
        /// </summary>
        [XmlAttribute("TestTime")]
        [DefaultValue(TestTimeEnum.After)]
        public TestTimeEnum TestTime{ get; set; }
        //[XmlIgnore]
        //public bool TestTimeSpecified { get { return TestTime != null; } }



        public LoopStandard()
        {
            LoopCounter = 0;
            LoopMaximum = 0;
            TestTime = TestTimeEnum.After;
        }
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            LoopStandard value = obj as LoopStandard;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.LoopMaximum, this.TestTime, this.LoopCondition, this.LoopCounter
                };

                List<object> listB = new List<object>
                {
                    value.LoopMaximum, value.TestTime, value.LoopCondition, value.LoopCounter
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