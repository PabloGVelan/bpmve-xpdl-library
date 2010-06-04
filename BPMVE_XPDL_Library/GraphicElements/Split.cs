using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.9.2. Split
    /// A split describes the semantics where Multiple outgoing Transitions for an Activity exist. 
    /// Any activity (including route activities) with Multiple outgoing transitions (sequence flow)
    /// must have a SPLIT transition restriction with a list of references To the outgoing transitions.
    /// The split transition restriction is used To specify the order in which the outgoing transitions
    /// are evaluated.
    /// </summary>
    public class Split: IValidate
    {
        /// <summary>
        /// A list of outgoing transitions From the Activity. Each transition is identified by its Id.
        /// Mandatory for All activities (including gateways) that have Multiple outgoing sequence flow.
        /// </summary>
        [XmlArray("TransactionRefs")]
        public List<TransitionRef> TransitionRefs { get; set; }
		[XmlIgnore]
		public bool TransitionRefsSpecified { get { return TransitionRefs == null ? false : TransitionRefs.Count != 0; } }

        /// <summary>
        /// Specifies the split behavior of this activity. If specified, then for BPMN gateway
        /// activities then this MUST match the GatewayType of the Route element. If specified 
        /// for BPMN non-gateway activities then this MUST be "Inclusive".
        /// Note that the enumerations XOR, OR AND AND are deprecated AND replaced by the new
        /// enumerations Exclusive, Inclusive AND Parallel respectively. It is recommended that
        /// modellers are capable of reading deprecated values but always write the new enumerations.
        /// </summary>
        [XmlAttribute("Type")]
        [DefaultValue(GatewayTypeEnum.Inclusive)]
        public GatewayTypeEnum Type { get; set; }
        //[XmlIgnore]
        //public bool TypeSpecified { get { return Type != null; } }

        /// <summary>
        /// Where the Type is ―Exclusive‖ this attribute specifies whether it is an Exclusive 
        /// Data-Based split OR AND Exclusive Event-Based split (see above).
        /// </summary>
        [XmlAttribute("ExclusiveType")]
        [DefaultValue(ExclusiveTypeEnum.Data)]
        public ExclusiveTypeEnum ExclusiveType { get; set; }
        //[XmlIgnore]
        //public bool ExclusiveTypeSpecified { get { return ExclusiveType != null; } }

        [XmlAttribute("OutgoingCondition")]
        public string OutgoingCondition { get; set; }
		[XmlIgnore]
		public bool OutgoingConditionSpecified { get { return OutgoingCondition != ""; } }



        public Split()
        {
            Type = GatewayTypeEnum.Inclusive;
            ExclusiveType = ExclusiveTypeEnum.Data;
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Split value = obj as Split;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Type, this.ExclusiveType, this.OutgoingCondition
                };

                List<object> listB = new List<object>
                {
                    value.Type, value.ExclusiveType, value.OutgoingCondition
                };

                if (!Utilities.IsListEqual<TransitionRef>(this.TransitionRefs, value.TransitionRefs))
                    return false;

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