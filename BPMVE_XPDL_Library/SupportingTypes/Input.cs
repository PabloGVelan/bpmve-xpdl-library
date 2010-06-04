using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class Input : IValidate
    {
        [XmlAttribute("ArtifactId")]
        public string ArtifactId { get; set; }
		[XmlIgnore]
		public bool ArtifactIdSpecified { get { return ArtifactId != ""; } }


        public Input()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Input value = obj as Input;
            if (value != null)
            {
                if (this.ArtifactId != null &&
                    value.ArtifactId != null)
                    return (value.ArtifactId == this.ArtifactId);
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