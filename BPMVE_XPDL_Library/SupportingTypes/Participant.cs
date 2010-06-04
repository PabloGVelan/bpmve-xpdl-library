using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.11. Participants
    /// The Participant is One of the following types: Resource set, Resource, organizational unit,
    /// Role, Human, OR System. A Role AND a Resource are used in the sense of abstract actors. . 
    /// This definition is an abstraction level between the real performer AND the activity, which
    /// has To be performed. During run time these abstract definitions are evaluated AND assigned 
    /// To concrete Human(s) AND/OR program(s).
    /// Note that this notion of Participant differs From the BPMN term (see section 7.4.1). The 
    /// scope of the identifier of a participant entity declaration in a minimal Resource repository
    /// OR organizational model is the surrounding entity (Process Definition OR Process Model Definition)
    /// in which it is defined. An external Resource repository OR organizational model may contain 
    /// substantial additional information that complements the basic participant types presented in here.
    /// </summary>
    public class Participant : IValidate
    {
        /// <summary>
        /// Definition of the type of participant entity.
        /// </summary>
        [XmlElement("ParticipantType")]
        public ParticipantType ParticipantType { get; set; }
        [XmlIgnore]
        public bool ParticipantTypeSpecified { get { return ParticipantType != null; } }

        /// <summary>
        /// Short textual description of a participant.
        /// </summary>
        [XmlElement("Description")]
        public Description Description { get; set; }
		[XmlIgnore]
		public bool DescriptionSpecified { get { return Description != null; } }

        /// <summary>
        /// A reference To an external specification of a participant. See section 7
        /// </summary>
        [XmlElement("ExternalReference")]
        public ExternalReference ExternalReference { get; set; }
		[XmlIgnore]
		public bool ExternalReferenceSpecified { get { return ExternalReference != null; } }

        /// <summary>
        /// Optional extensions To meet individual implementation needs.
        /// </summary>
        [XmlArray("ExtendedAttributes")]
        public List<ExtendedAttribute> ExtendedAttributes { get; set; }
        [XmlIgnore]
        public bool ExtendedAttributesSpecified { get { return ExtendedAttributes == null ? false : ExtendedAttributes.Count != 0; } }

        /// <summary>
        /// Used To identify the participant definition.
        /// </summary>
        [XmlAttribute("Id")]
        public string Id { get; set; }

        /// <summary>
        /// Text used To identify a performer.
        /// </summary>
        [XmlAttribute("Name")]
        public string Name { get; set; }
		[XmlIgnore]
		public bool NameSpecified { get { return Name != ""; } }



        public Participant()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Participant value = obj as Participant;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Id, this.Name, this.Description, this.ParticipantType, this.ExternalReference
                };

                List<object> listB = new List<object>
                {
                    value.Id, value.Name, value.Description, value.ParticipantType, value.ExternalReference
                };

                if (!Utilities.IsListEqual<ExtendedAttribute>(this.ExtendedAttributes, value.ExtendedAttributes))
                {
                    return false;
                }

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