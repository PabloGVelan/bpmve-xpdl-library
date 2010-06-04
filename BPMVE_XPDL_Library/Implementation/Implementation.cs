using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.5. Implementation Alternatives
    /// It is assumed that the execution of the Activity is atomic with respect To the Data under 
    /// control of the Process OR Workflow engine. That implies that in the case of a System crash,
    /// an abort, OR a cancellation of the Activity, the Relevant Data Standard AND the control Data 
    /// are rolled back (automatically OR by Other means), OR an appropriate compensating activity
    /// is applied. (This does not necessarily hold for audit Data.) This version of the specification
    /// does not include any specific controls over Data synchronization OR recovery (for example 
    /// between execution, subflows OR applications under execution.
    /// </summary>
    public class Implementation : IValidate
    {
        [XmlElement("No")]
        public NoImplementation NoImplementation { get; set; }
        [XmlIgnore]
        public bool NoImplementationSpecified { get { return NoImplementation != null; } }

        [XmlElement("Task")]
        public Task Task { get; set; }
        [XmlIgnore]
        public bool TaskSpecified { get { return Task != null; } }

        [XmlElement("SubFlow")]
        public SubFlow SubFlow { get; set; }
        [XmlIgnore]
        public bool SubFlowSpecified { get { return SubFlow != null; } }

        [XmlElement("Reference")]
        public Reference Reference { get; set; }
        [XmlIgnore]
        public bool ReferenceSpecified { get { return Reference != null; } }



        public Implementation()
        {
        } 

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Implementation value = obj as Implementation;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.NoImplementation, this.Task, this.SubFlow, this.Reference
                };

                List<object> listB = new List<object>
                {
                    value.NoImplementation, value.Task, value.SubFlow, value.Reference
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