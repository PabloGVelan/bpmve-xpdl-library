using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.5.3.3. Task Manual
    /// A TaskType of Manual MUST NOT have an incoming OR an outgoing Message Flow.
    /// </summary>
    public class TaskManual : IValidate
    {
        /// <summary>
        /// A list of performers that will be performing the Manual Task. The Performers entry 
        /// could be in the form of a specific individual, a group, OR an organization. Similar
        /// To the  ̳Implementation:No‘ activity (see section 7.6.5.1).
        /// </summary>
        [XmlArray("Performers")]
        public List<Performer> Performers { get; set; }
		[XmlIgnore]
		public bool PerformersSpecified { get { return Performers == null ? false : Performers.Count != 0; } }



        public TaskManual()
        {
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        
		public override bool Equals (object obj)
		{
			TaskManual value = obj as TaskManual;
            if (value != null)
			{
				return (Utilities.IsListEqual<Performer>(this.Performers, value.Performers));
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