using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.11. OutputSet
    /// The OutputSets attribute defines the Data requirements for output From the activity. 
    /// Zero OR more OutputSets MAY be defined. At the completion of the activity, only One 
    /// of the OutputSets may be produced. It is up To the implementation of the activity 
    /// To determine which set will be produced. However, the IORules attribute MAY indicate 
    /// a relationship between an OutputSet AND an InputSet that started the activity.
    /// One OR more Outputs MUST be defined for each OutputSet. An Output is an Artifact, usually
    /// a Document Object. Note that the Artifacts MAY also be displayed on the diagram AND MAY 
    /// be connected To the activity through an Association. However, it is not required for them 
    /// To be displayed.
    /// </summary>
    public class OutputSet : IValidate
    {
        /// <summary>
        /// A list of outputs
        /// </summary>
        [XmlArray("Output")]
        public List<Output> Outputs { get; set; }
		[XmlIgnore]
		public bool OutputsSpecified { get { return Outputs == null ? false : Outputs.Count != 0; } }



        public OutputSet()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            OutputSet value = obj as OutputSet;
            if (value != null)
            {
                return (Utilities.IsListEqual<Output>(this.Outputs, value.Outputs));
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