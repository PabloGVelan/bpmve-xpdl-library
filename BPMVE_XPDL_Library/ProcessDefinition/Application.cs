using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.3. Application Declaration
    /// Application declaration is a list of All applications/services OR tools required AND invoked
    /// by the processes defined within the process definition OR surrounding package. Tools may be 
    /// defined (OR, in fact, just named). This means, that the real definition of the tools is not 
    /// necessary AND may be handled by an object manager. The reason for this approach is the handling
    /// of multi-platform environments, where a different program (OR function) has To be invoked for 
    /// each platform. XPDL abstracts From the concrete implementation OR environment (thus these aspects
    /// are not of interest at process definition time).
    /// </summary>
    public class Application : IValidate
    {
        /// <summary>
        /// Short textual description of the application.
        /// </summary>
        [XmlElement("Description")]
        public Description Description { get; set; }
		[XmlIgnore]
		public bool DescriptionSpecified { get { return Description != null; } }

        /// <summary>
        /// There are a number of Standard Application Types. See section 7.3.2.
        /// </summary>
        [XmlElement("Type")]
        public ApplicationType Type { get; set; }
		[XmlIgnore]
		public bool TypeSpecified { get { return Type != null; } }

        /// <summary>
        /// A list of parameters that are interchanged with the application via the invocation 
        /// interface. See section 7.1.5.
        /// </summary>
        [XmlArray("FormalParameters")]
        public List<FormalParameter> FormalParameters { get; set; }
        [XmlIgnore]
        public bool FormalParametersSpecified { get { return FormalParameters == null ? false : FormalParameters.Count != 0; } }

        /// <summary>
        /// A reference To an external specification of the application signature. 
        /// See section 7.1.6.
        /// </summary>
        [XmlElement("ExternalReference")]
        public ExternalReference ExternalReference { get; set; }
        [XmlIgnore]
        public bool ExternalReferenceSpecified { get { return ExternalReference != null; } }

        /// <summary>
        /// Optional vendor-defined extensions To meet implementation needs. See section 7.1.4.
        /// </summary>
        [XmlArray("ExtendedAttributes")]
        public List<ExtendedAttribute> ExtendedAttributes { get; set; }
        [XmlIgnore]
        public bool ExtendedAttributesSpecified { get { return ExtendedAttributes == null ? false : ExtendedAttributes.Count != 0; } }

        /// <summary>
        /// Used To identify the application definition.
        /// </summary>
        [XmlAttribute("Id")]
        public string Id { get; set; }

        /// <summary>
        /// Text used To identify an application (may be interpreted as a generic name of the tool).
        /// </summary>
        [XmlAttribute("Name")]
        public string Name { get; set; }
		[XmlIgnore]
		public bool NameSpecified { get { return Name != ""; } }



        public Application()
        {
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Application value = obj as Application;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Description, this.Type, this.ExternalReference, this.Id, this.Name
                };

                List<object> listB = new List<object>
                {
                    value.Description, value.Type, value.ExternalReference, value.Id, value.Name
                };

                if (!Utilities.IsListEqual<ExtendedAttribute>(this.ExtendedAttributes, value.ExtendedAttributes) ||
				    !Utilities.IsListEqual<FormalParameter>(this.FormalParameters, value.FormalParameters))
                    return false;

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