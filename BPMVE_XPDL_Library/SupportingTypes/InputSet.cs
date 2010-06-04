using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.10. InputSets
    /// The InputSets attribute defines the Data requirements for input To the activity. 
    /// Zero OR more InputSets MAY be defined. Each InputSet is sufficient To allow the 
    /// activity To be performed (if it has first been instantiated by the appropriate 
    /// Dignal arriving From an incoming Sequence Flow).
    /// In BPMN 1.1 the element Input has been replaced by ArtifactInputs AND PropertyInputs. 
    /// We preserve the element in the schema for compatibility.
    /// Zero OR more ArtifactInputs MAY be defined for each InputSet. For the combination of 
    /// ArtifactInputs AND PropertyInputs, there MUST be at least One item defined for the 
    /// InputSet. An ArtifactInput is an Artifact, usually a DataObject. Note that the Artifacts
    /// MAY also be displayed on the diagram AND MAY be connected To the activity through an 
    /// Association--however, it is not required for them To be displayed.
    /// Zero OR more PropertyInputs MAY be defined for each InputSet. For the combination of 
    /// ArtifactInputs AND PropertyInputs, there MUST be at least One item defined for the InputSet.
    /// </summary>
    public class InputSet : IValidate
    {
        /// <summary>
        /// See section 6.4.7. AND 7.1.9.
        /// </summary>
        [XmlArray("Input")]
        public List<Input> Inputs { get; set; }
		[XmlIgnore]
		public bool InputsSpecified { get { return Inputs == null ? false : Inputs.Count != 0; } }

        /// <summary>
        /// A list of Artifacts.
        /// </summary>
        [XmlArray("ArtifactInput")]
        public List<ArtifactInput> ArtifactInputs { get; set; }
		[XmlIgnore]
		public bool ArtifactInputsSpecified { get { return ArtifactInputs == null ? false : Inputs.Count != 0; } }

        /// <summary>
        /// A list of Properties.
        /// </summary>
        [XmlArray("PropertyInput")]
        public List<PropertyInput> PropertyInputs { get; set; }
		[XmlIgnore]
		public bool PropertyInputsSpecified { get { return PropertyInputs == null ? false : Inputs.Count != 0; } }



        public InputSet()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            InputSet value = obj as InputSet;
            if (value != null)
            {
                return (Utilities.IsListEqual<Input>(this.Inputs, value.Inputs) &&
                        Utilities.IsListEqual<ArtifactInput>(this.ArtifactInputs, value.ArtifactInputs) &&
                        Utilities.IsListEqual<PropertyInput>(this.PropertyInputs, value.PropertyInputs));
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