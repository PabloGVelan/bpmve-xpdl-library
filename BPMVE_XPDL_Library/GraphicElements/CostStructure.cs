using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// Activities incur costs in a number of ways, they use up
    /// resources which may be people, machines, services, computers, office space, etc. 
    /// Activities also use up fixed costs which may be assigned on an activity by activity
    /// basis, thus allowing for the assignment of overhead. Fixed costs are assigned in bulk,
    /// that is To say there is One fixed cost per activity. However Resource costs are assigned
    /// on a Resource by Resource basis, each One having a cost AND an associated time unit.
    /// </summary>
    public class CostStructure : IValidate
    {
        [XmlArray("ResourceCosts")]
        public List<ResourceCost> ResourceCost { get; set; }
		[XmlIgnore]
		public bool ResourceCostSpecified { get { return ResourceCost == null ? false : ResourceCost.Count != 0; } }

        [XmlElement("FixedCost")]
        [DefaultValue(0)]
        public int FixedCost { get; set; }
		[XmlIgnore]
		public bool FixedCostSpecified { get { return FixedCost != 0; } }



        public CostStructure()
        {
            FixedCost = 0;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

		public override bool Equals (object obj)
		{
            CostStructure value = obj as CostStructure;

            if (value != null)
            {
                if (this.FixedCost != value.FixedCost)
					return false;

                if (!Utilities.IsListEqual<ResourceCost>(this.ResourceCost, value.ResourceCost))
                    return false;
            }

            return true;
		}

        #region IValidate Members

        public bool Validate()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}