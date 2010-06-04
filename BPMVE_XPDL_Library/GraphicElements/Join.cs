using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.9.1. Join
    /// A join describes the semantics of an activity with Multiple incoming Transitions.
    /// Note that for BPMN diagrams this element is no longer necessary because for gateway 
    /// activities the type is specified in the Route element AND for non-gateway activities
    /// the join behaviour is fixed as Exclusive.
    /// The Parallel (AND) join can be seen as a "rendezvous precondition" of the Activity; 
    /// the activity is not initiated until the
    /// transition conditions on All incoming routes evaluate true.
    /// The Exclusive (XOR) join initiates the Activity when the transition conditions of any 
    /// (One) of the incoming transitions evaluates true.
    /// </summary>
    public class Join : IValidate
    {
        /// <summary>
        /// Specifies the join behavior of this activity. If specified, then for BPMN gateway 
        /// activities this MUST match the GatewayType of the Route element. If specified for
        /// BPMN non-gateway activities then this MUST be ―Exclusive‖.
        /// Note that the enumerations XOR, OR AND AND are deprecated AND replaced by the new 
        /// enumerations Exclusive, Inclusive AND Parallel respectively. It is recommended that 
        /// modellers are capable of reading deprecated values but always write the new enumerations.
        /// Parallel (AND)	Join of (All) concurrent threads within the process instance with 
        /// incoming transitions To the activity: Synchronization is required. The number of
        /// threads To be synchronized might be dependent on the result of the conditions of
        /// previous AND split(s). Equivalent To BPMN  ̳OR ̳ gateway merge logic. BPMN AND
        /// gateway merge logic requires All incoming transition threads To be synchronized, 
        /// regardless of previous splits.
        /// Inclusive (OR)	See above. Exclusive (XOR) Join for alternative threads: No synchronisation
        /// is required. COMPLEX	This makes use of the attribute IncomingCondition (see below).
        /// </summary>
        [XmlAttribute("Type")]
        [DefaultValue(GatewayTypeEnum.Exclusive)]
        public GatewayTypeEnum Type { get; set; }
        //[XmlIgnore]
        //public bool TypeSpecified { get { return Type != null; } }

        /// <summary>
        /// Deprecated – join behaviour is identical for Exclusive Data-Base AND Exclusive 
        /// Event-based gateways.
        /// </summary>
        [XmlAttribute("ExclusiveType")]
        [DefaultValue(ExclusiveTypeEnum.Data)]
        public ExclusiveTypeEnum ExclusiveType { get; set; }
        //[XmlIgnore]
        //public bool ExclusiveTypeSpecified { get { return ExclusiveType != null; } }

        /// <summary>
        /// An expression that determines which of the incoming transitions/Sequence Flow are 
        /// required for the Process To continue.. The expression may refer To process Data AND 
        /// the status of the incoming Sequence Flow. For example, an expression may specify that 
        /// any 3 out of 5 incoming Tokens will continue the Process. Another example would be an 
        /// expression that specifies that a Token is
        /// required From Sequence Flow ―a” AND that a Token From either Sequence Flow ―b” OR ―c” is
        /// acceptable. However, the expression should be designed so that the Process is not stalled
        /// at that location.
        /// </summary>
        [XmlAttribute("IncomingCondition")]
        public string IncomingCondition { get; set; }
		[XmlIgnore]
		public bool IncomingConditionSpecified { get { return IncomingCondition != ""; } }



        public Join()
        {
            Type = GatewayTypeEnum.Exclusive;
            ExclusiveType = ExclusiveTypeEnum.Data;
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Join value = obj as Join;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Type, this.ExclusiveType, this.IncomingCondition
                };

                List<object> listB = new List<object>
                {
                    value.Type, value.ExclusiveType, value.IncomingCondition
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