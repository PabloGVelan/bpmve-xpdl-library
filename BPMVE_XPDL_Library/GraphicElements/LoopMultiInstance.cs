using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// Multi-Instance loops reflect the programming construct foreach. The loop expression for 
    /// a Multi-Instance loop is a numeric expression evaluated only once Before the activity is
    /// performed. The result of the expression evaluation will be an integer that will specify 
    /// the number of times that the activity will be repeated. There are also two variations of 
    /// the Multi-Instance loop where the instances are either performed sequentially OR in Parallel.
    /// Deprecated: MI_Condition(string) -> MI_Condition(ExpressionType)
    ///             ComplexMI_FlowCondition(string) -> MI_Condition(ExpressionType)
    /// </summary>
    public class LoopMultiInstance : IValidate
    {
        /// <summary>
        /// MultiInstance Loops MUST have a numeric Expression to be evaluated--the Expression 
        /// MUST resolve to an integer. MI_Condition can be either an attribute of type string 
        /// or an element of type xpdl:ExpressionType.
        /// </summary>
        [XmlElement("MI_Condition")]
        public Expression MI_Condition { get; set; }
        [XmlIgnore]
        public bool MI_ConditionSpecified { get { return MI_Condition != null; } }

        /// <summary>
        /// If the MI_FlowCondition attribute is set To ―Complex,‖ then an Expression Must be 
        /// entered. This Expression that MAY reference Process Data. The expression will be 
        /// evaluated After each iteration of the Activity AND SHALL resolve To a bool. If the
        /// result of the expression evaluation is TRUE, then a Token will be sent down the 
        /// activity‘s outgoing Sequence Flow. Otherwise, no Token for that iteration will be sent.
        /// </summary>
        [XmlElement("ComplexMI_FlowCondition")]
        public Expression ComplexMI_FlowCondition { get; set; }
        [XmlIgnore]
        public bool ComplexMI_FlowConditionSpecified { get { return ComplexMI_FlowCondition != null; } }

        [XmlAttribute("MI_Condition")]
        public string MI_ConditionString { get; set; }
        [XmlIgnore]
        public bool MI_ConditionStringSpecified { get { return MI_ConditionString != null; } }

        [XmlAttribute("LoopCounter")]
        [DefaultValue(0)]
        public int LoopCounter { get; set; }
        [XmlIgnore]
        public bool LoopCounterSpecified { get { return LoopCounter != 0; } }

        /// <summary>
        /// Sequential | Parallel This applies To only MultiInstance Loops. The MI_Ordering attribute
        /// defines whether the loop instances will be performed sequentially OR in Parallel. 
        /// Sequential MI_Ordering is a more traditional loop. Parallel MI_Ordering is equivalent 
        /// To multi- instance specifications that Other notations, such as UML Activity Diagrams use.
        /// If set To Parallel, the Parallel marker SHALL replace the Loop Marker at the bottom center
        /// of the activity shape.
        /// </summary>
        [XmlAttribute("MI_Ordering")]
        [DefaultValue(OrderingEnum.Sequential)]
        public OrderingEnum MI_Ordering { get; set; }
        //[XmlIgnore]
        //public bool MI_OrderingSpecified { get { return MI_Ordering != null; } }

        /// <summary>
        /// None | One | All | Complex This attribute is equivalent To using a Gateway To control
        /// the flow past a set of Parallel paths. An MI_FlowCondition of ―None‖ is the same as
        /// uncontrolled flow (no Gateway) AND means that All activity instances SHALL generate a 
        /// token that will continue when that instance is Completed. An MI_FlowCondition of ―One‖ 
        /// is the same as an Exclusive Gateway AND means that the Token SHALL continue past the
        /// activity After only One of the activity instances has Completed. The activity will 
        /// continue its Other instances, but additional Tokens MUST NOT be passed From the activity. 
        /// An MI_FlowCondition of ―All‖ is the same as a Parallel Gateway AND means that the Token 
        /// SHALL continue past the activity After All of the activity instances have Completed. 
        /// An MI_FlowCondition of ―Complex‖ is similar To that of a Complex Gateway. 
        /// The ComplexMI_FlowCondition attribute will determine the Token flow.
        /// </summary>
        [XmlAttribute("MI_FlowCondition")]
        [DefaultValue(MI_FlowConditionEnum.All)]
        public MI_FlowConditionEnum MI_FlowCondition { get; set; }
        //[XmlIgnore]
        //public bool MI_FlowConditionSpecified { get { return MI_FlowCondition != null; } }



        public LoopMultiInstance()
        {
            LoopCounter = 0;
            MI_Ordering = OrderingEnum.Sequential;
            MI_FlowCondition = MI_FlowConditionEnum.All;
        }		
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            LoopMultiInstance value = obj as LoopMultiInstance;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.MI_FlowCondition, this.ComplexMI_FlowCondition, this.MI_Condition,
					this.LoopCounter, this.MI_Ordering
                };

                List<object> listB = new List<object>
                {
                    value.MI_FlowCondition, value.ComplexMI_FlowCondition, value.MI_Condition, 
					value.LoopCounter, value.MI_Ordering
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