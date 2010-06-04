using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class SimulationInformation : IValidate
    {
        /// <summary>
        /// Average cost.
        /// </summary>
        [XmlElement("Cost")]
        public Cost Cost { get; set; }
		[XmlIgnore]
		public bool CostSpecified { get { return Cost != null; } }

        /// <summary>
        /// Expected duration (summary of working time, waiting time, AND duration) in units of 
        /// DurationUnit.
        /// </summary>
        [XmlElement("TimeEstimation")]
        public TimeEstimation TimeEstimation { get; set; }
		[XmlIgnore]
		public bool TimeEstimationSpecified { get { return TimeEstimation != null; } }

        /// <summary>
        /// Defines the capability of an activity To be activated. Defines how many times an
        /// Activity can be activated for higher throughput (e.g. how many individuals can 
        /// capture a Role). This can be once OR many times (Multiple).
        /// ONCE	    The Activity can only be instantiated once. Default. 
        /// MULTIPLE	The Activity can be instantiated Multiple times.
        /// </summary>
        [XmlAttribute("Instantiation")]
        [DefaultValue(InstantiationEnum.Once)]
        public InstantiationEnum Instantiation { get; set; }
        //[XmlIgnore]
        //public bool InstantiationSpecified { get { return Instantiation != null; } }

        ///// <summary>
        ///// Adding detailed cost structure To simulation allows for greater comparison with real 
        ///// time results gathered From business activity monitoring tools as well as capturing
        ///// greater detail typically housed in process engineering tools.
        ///// </summary>
        //public CostStructure CostStructure { get; set; }



        public SimulationInformation()
        {
            Instantiation = InstantiationEnum.Once;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
		
		public override bool Equals (object obj)
		{
            SimulationInformation value = obj as SimulationInformation;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Cost, this.TimeEstimation, this.Instantiation
                };

                List<object> listB = new List<object>
                {
                    value.Cost, value.TimeEstimation, value.Instantiation
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