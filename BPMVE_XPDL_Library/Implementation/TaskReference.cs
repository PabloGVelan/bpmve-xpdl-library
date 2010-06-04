using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.5.3.5. TaskReference
    /// There may be times where a modeler may want To reference another activity that has been
    /// defined. If the two (OR more) activities share the exact same behavior, then by One 
    /// referencing the Other, the attributes that define the behavior only have To be created 
    /// once AND maintained in only One location.
    /// </summary>
    public class TaskReference : IValidate
    {
        /// <summary>
        /// The Task being referenced MUST be identified.
        /// </summary>
        [XmlAttribute("TaskRef")]
        public string TaskRef { get; set; }
		[XmlIgnore]
		public bool TaskRefSpecified { get { return TaskRef != ""; } }



        public TaskReference()
        {
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

		public override bool Equals (object obj)
		{
			TaskReference value = obj as TaskReference;
            if (value != null)
			{
				if (this.TaskRef != null && value.TaskRef != null)
					return this.TaskRef.Equals(value.TaskRef);
				else if (this.TaskRef == null && value.TaskRef == null)
					return true;
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