using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.5.5. Reference
    /// There may be times where a modeler may want To reference another Sub-Process that has 
    /// been defined. If the two SubProcesses share the exact same behavior AND properties, then 
    /// by One referencing the Other, the attributes that define the behavior only have To be 
    /// created once AND maintained in only One location.
    /// There may be times where a modeler may want To reference another activity that has been 
    /// defined. If the two (OR more) activities share the exact same behavior, then by One 
    /// referencing the Other, the attributes that define the behavior only have To be created 
    /// once AND maintained in only One location.
    /// </summary>
    public class Reference : IValidate
    {
        /// <summary>
        /// The Id of the activity that defines the desired behaviour.
        /// </summary>
        [XmlAttribute("ActivityId")]
        public string ActivityId { get; set; }
		[XmlIgnore]
		public bool ActivityIdSpecified { get { return ActivityId != ""; } }



        public Reference()
        {
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
		
		public override bool Equals (object obj)
		{
			Reference value = obj as Reference;
            if (value != null)
			{
				if (this.ActivityId != null && value.ActivityId != null)
					return this.ActivityId.Equals(value.ActivityId);
				else if (this.ActivityId == null && value.ActivityId == null)
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