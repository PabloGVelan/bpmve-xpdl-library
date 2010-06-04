using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.5.2. Process Definition Header
    /// The process definition header keeps All information specific for a process definition 
    /// such as process version, priority, duration of validity, etc.
    /// </summary>
    public class ProcessHeader : IValidate
    {
        /// <summary>
        /// Creation date of process definition.
        /// </summary>
        [XmlElement("Created")]
        public Date Created { get; set; }
		[XmlIgnore]
		public bool CreatedSpecified { get { return Created != null; } }

        /// <summary>
        /// Short textual description of the process.
        /// </summary>
        [XmlElement("Description")]
        public Description Description { get; set; }
		[XmlIgnore]
		public bool DescriptionSpecified { get { return Description != null; } }

        /// <summary>
        /// The priority of the process type. The units are defined in the Package header priority units.
        /// </summary>
        [XmlElement("Priority")]
        public Priority Priority { get; set; }
		[XmlIgnore]
		public bool PrioritySpecified { get { return Priority != null; } }

        /// <summary>
        /// Expected duration for time management purposes (e.g. starting an escalation procedure 
        /// etc.) in units of DurationUnit. It is counted From the starting date/time of the Process. 
        /// The consequences of reaching the limit value are not defined in this document (i.e. vendor
        /// specific). It is assumed that in this case at least the Responsible of the current process
        /// is notified of this situation.
        /// </summary>
        [XmlElement("Limit")]
        public Limit Limit { get; set; }
        [XmlIgnore]
        public bool LimitSpecified { get { return Limit != null; } }

        /// <summary>
        /// The date that the process definition is Active From. Empty string means System date. 
        /// Default: Inherited From Model Definition.
        /// </summary>
        [XmlElement("ValidFrom")]
        public ValidFrom ValidFrom { get; set; }
		[XmlIgnore]
		public bool ValidFromSpecified { get { return ValidFrom != null; } }

        /// <summary>
        /// The date at which the process definition becomes valid. Empty string means unlimited 
        /// validity. Default: Inherited From Model Definition.
        /// </summary>
        [XmlElement("ValidTo")]
        public ValidTo ValidTo { get; set; }
		[XmlIgnore]
		public bool ValidToSpecified { get { return ValidTo != null; } }

        /// <summary>
        /// Grouping of waiting time, working time, AND duration. Used for simulation purposes.
        /// </summary>
        [XmlElement("TimeEstimation")]
        public TimeEstimation TimeEstimation { get; set; }
        [XmlIgnore]
        public bool TimeEstimationSpecified { get { return TimeEstimation != null; } }

        /// <summary>
        /// Describes the default unit To be applied To an integer duration value that has no unit tag. 
        /// Possible units are:
        /// Y - Year M - Month D - Day H - Hour m - Minute s – Second
        /// </summary>
        [XmlAttribute("DurationUnit")]
        [DefaultValue(DurationUnitEnum.Year)]
        public DurationUnitEnum DurationUnit { get; set; }
        //[XmlIgnore]
        //public bool DurationUnitSpecified { get { return DurationUnit != null; } }



        public ProcessHeader()
        {
            DurationUnit = DurationUnitEnum.Year;
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            ProcessHeader value = obj as ProcessHeader;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Created, this.Description, this.DurationUnit, this.Limit, 
					this.Priority, this.TimeEstimation, this.ValidFrom, this.ValidTo
                };

                List<object> listB = new List<object>
                {
                    value.Created, value.Description, value.DurationUnit, value.Limit, 
					value.Priority, value.TimeEstimation, value.ValidFrom, value.ValidTo
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