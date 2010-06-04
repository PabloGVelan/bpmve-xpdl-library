using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    [XmlType("ResourceCosts")]
    public class ResourceCost : IValidate
    {
        [XmlElement("ResourceCostName")]
        public string ResourceCostName { get; set; }
		[XmlIgnore]
		public bool ResourceCostNameSpecified { get { return ResourceCostName != ""; } }

        [XmlElement("ResourceCost")]
        public decimal ResourceCosts { get; set; }
		[XmlIgnore]
		public bool ResourceCostsSpecified { get { return ResourceCosts != 0.0m; } }

        [XmlElement("CostUnitOfTime")]
        [DefaultValue(CostUnitOfTimeEnum.Hour)]
        public CostUnitOfTimeEnum CostUnitOfTime { get; set; }
        //[XmlIgnore]
        //public bool CostUnitOfTimeSpecified { get { return CostUnitOfTime != null; } }


        public ResourceCost()
        {
            CostUnitOfTime = CostUnitOfTimeEnum.Hour;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

		public override bool Equals (object obj)
		{
            ResourceCost value = obj as ResourceCost;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.ResourceCostName, this.ResourceCosts, this.CostUnitOfTime
                };

                List<object> listB = new List<object>
                {
                    value.ResourceCostName, value.ResourceCosts, value.CostUnitOfTime
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