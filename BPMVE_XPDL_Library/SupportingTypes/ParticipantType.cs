using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.11.1. Participant Entity Types
    /// The Participant entity type attribute characterises the participant To be an individual, 
    /// an organisational unit OR an abstract Resource such as a machine.
    /// </summary>
    public class ParticipantType : IValidate
    {
        [XmlAttribute("Type")]
        [DefaultValue(ParticipantTypeEnum.Human)]
        public ParticipantTypeEnum Type { get; set; }
        //[XmlIgnore]
        //public bool TypeSpecified { get { return Type != null; } }



        public ParticipantType()
        {
            Type = ParticipantTypeEnum.Human;
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            ParticipantType value = obj as ParticipantType;
            if (value != null)
            {
				return (value.Type == this.Type);
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