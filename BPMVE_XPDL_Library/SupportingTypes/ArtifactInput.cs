using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    [Serializable]
    public class ArtifactInput : IValidate
    {
        [XmlAttribute("ArtifactId")]
        public string ArtifactId { get; set; }
		[XmlIgnore]
		public bool ArtifactIdSpecified { get { return ArtifactId != ""; } }

        [XmlAttribute("RequiredForStart")]
        [DefaultValueAttribute(true)]
        public bool IsRequiredForStart { get; set; }



        public ArtifactInput()
        {
            IsRequiredForStart = true;
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            ArtifactInput value = obj as ArtifactInput;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.ArtifactId, this.IsRequiredForStart
                };

                List<object> listB = new List<object>
                {
                    value.ArtifactId, value.IsRequiredForStart
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