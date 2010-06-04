using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.7. Transition Information
    /// The Transition Information describes possible transitions between activities AND the 
    /// conditions that enable OR disable them (the transitions) during execution. Further 
    /// control AND structure restrictions may be expressed in the Activity definition.
    /// Note that BPMN uses the term SequenceFlow for transition. See section 7.7.2.
    /// </summary>
    public class Transition : ConnectingObject, IValidate
    {
        /// <summary>
        /// See section 7.1.7.
        /// </summary>
        [XmlElement("Condition")]
        public Condition Condition { get; set; }
		[XmlIgnore]
		public bool ConditionSpecified { get { return Condition != null; } }

        /// <summary>
        /// Short textual description of the ConnectingGraphic.
        /// </summary>
        [XmlElement("Description")]
        public Description Description { get; set; }
		[XmlIgnore]
		public bool DescriptionSpecified { get { return Description != null; } }

        /// <summary>
        /// Optional extensions To meet individual implementation needs.
        /// </summary>
        [XmlArray("ExtendedAttributes")]
        public List<ExtendedAttribute> ExtendedAttributes { get; set; }
        [XmlIgnore]
        public bool ExtendedAttributesSpecified { get { return ExtendedAttributes == null ? false : ExtendedAttributes.Count != 0; } }

        /// <summary>
        /// See section 7.1.7.
        /// </summary>
        [XmlArray("Assignments")]
        public List<Assignment> Assignments { get; set; }
		[XmlIgnore]
		public bool AssignmentsSpecified { get { return Assignments == null ? false : Assignments.Count != 0; } }

        /// <summary>
        /// See section 7.1.9.4.
        /// </summary>
        [XmlElement("Object")]
        public override Object_XPDL Object { get; set; }
        [XmlIgnore]
        public override bool ObjectSpecified { get { return Object != null; } }

        /// <summary>
        /// See section 7.1.2.4.
        /// </summary>
        [XmlArray("ConnectorGraphicsInfos")]
        public override List<ConnectorGraphicsInfo> ConnectorGraphicsInfos { get; set; }
		[XmlIgnore]
        public override bool ConnectorGraphicsInfosSpecified { get { return ConnectorGraphicsInfos == null ? false : ConnectorGraphicsInfos.Count != 0; } }

        /// <summary>
        /// Used To identify the Transition.
        /// </summary>
        [XmlAttribute("Id")]
        public override string Id { get; set; }

        /// <summary>
        /// Determines the FROM source of a Transition. (Activity Identifier).
        /// </summary>
        [XmlAttribute("From")]
        public string From { get; set; }
		[XmlIgnore]
		public bool FromSpecified { get { return From != ""; } }

        /// <summary>
        /// Determines the TO target of a Transition (Activity Identifier).
        /// </summary>
        [XmlAttribute("To")]
        public string To { get; set; }
		[XmlIgnore]
		public bool ToSpecified { get { return To != ""; } }        

        /// <summary>
        /// Name of the Transition.
        /// </summary>
        [XmlAttribute("Name")]
        public override string Name { get; set; }
		[XmlIgnore]
        public override bool NameSpecified { get { return Name != ""; } }

        /// <summary>
        /// The default value is 1. The value MUST NOT be less than 1. This attribute defines the 
        /// number of Tokens that will be generated down the Sequence Flow.
        /// </summary>
        [XmlAttribute("Quantity")]
        [DefaultValue(1)]
        public int Quantity { get; set; }
        //[XmlIgnore]
        //public bool QuantitySpecified { get { return Quantity != 0; } }



        public Transition()
        {
            Quantity = 1;
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Transition value = obj as Transition;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Condition, this.From, this.To, this.Id, this.Name, this.Object,
                    this.Description, this.Quantity
                };

                List<object> listB = new List<object>
                {
                    value.Condition, value.From, value.To, value.Id, value.Name, value.Object,
                    value.Description, value.Quantity
                };

                if (!Utilities.IsListEqual<ConnectorGraphicsInfo>(this.ConnectorGraphicsInfos, value.ConnectorGraphicsInfos) ||
                    !Utilities.IsListEqual<ExtendedAttribute>(this.ExtendedAttributes, value.ExtendedAttributes) ||
                    !Utilities.IsListEqual<Assignment>(this.Assignments, value.Assignments))
                    return false;

                return (Utilities.IsEqual(listA, listB));
            }

            return false;
        }

        #region IValidate Members

        public override bool Validate()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}