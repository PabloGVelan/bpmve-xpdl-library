using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.9. Transition Restriction
    /// Any activity (including route activities) with Multiple outgoing transitions (sequence 
    /// flow) must have a SPLIT transition restriction with a list of references To the outgoing
    /// transitions. The split transition restriction is used To specify the order in which the 
    /// outgoing transitions are evaluated.
    /// A JOIN transition restriction MAY be used when there are Multiple incoming sequence flows,
    /// however in BPMN diagrams the join AND split behavior for non-gateway activities is fixed 
    /// (join is always Exclusive AND split is always Inclusive).
    /// </summary>
    public class TransitionRestriction : IValidate
    {
        [XmlElement("Join")]
        public Join Join { get; set; }
        [XmlIgnore]
        public bool JoinSpecified { get { return Join != null; } }

        [XmlElement("Split")]
        public Split Split { get; set; }
        [XmlIgnore]
        public bool SplitSpecified { get { return Split != null; } }



        public TransitionRestriction()
        {
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            TransitionRestriction value = obj as TransitionRestriction;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Join, this.Split
                };

                List<object> listB = new List<object>
                {
                    value.Join, value.Split
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