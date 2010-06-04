using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.2.2. Redefinable Header
    /// The redefinable header covers those header attributes that may be defined in the definition 
    /// header AND may be redefined in the header of any process definition. In case of redefinition, 
    /// the scope rules hold.
    /// </summary>
    public class RedefinableHeader : IValidate
    {
        /// <summary>
        /// Name of the author of this package definition.
        /// </summary>
        [XmlElement("Author")]
        public Author Author { get; set; }
		[XmlIgnore]
		public bool AuthorSpecified { get { return Author != null; } }

        /// <summary>
        /// Version of this Package Definition.
        /// </summary>
        [XmlElement("Version")]
        public Version_XPDL Version { get; set; }
        [XmlIgnore]
        public bool VersionSpecified { get { return Version != null; } }

        /// <summary>
        /// The codepage used for the text parts. If codepage is omitted, then UFT-8 is assumed.
        /// </summary>
        [XmlElement("Codepage")]
        public Codepage Codepage { get; set; }
		[XmlIgnore]
		public bool CodepageSpecified { get { return Codepage != null; } }

        /// <summary>
        /// Country code based on ISO 3166. It could be either the three digits country code number, 
        /// OR the two alpha characters country codes.
        /// </summary>
        [XmlElement("Countrykey")]
        public Countrykey CountryKey { get; set; }
		[XmlIgnore]
		public bool CountryKeySpecified { get { return CountryKey != null; } }

        /// <summary>
        /// Participant, who is responsible for this process; the supervisor during run time.
        /// Link To entity participant. Participant, who is responsible for this workflow of this 
        /// Model definition (usually an Organisational Unit OR a Human). It is assumed that the 
        /// responsible is the supervisor during run time. Default: Initiating participant.
        /// </summary>
        [XmlArray("Responsibles")]
        public List<Responsible> Responsibles { get; set; }
        [XmlIgnore]
        public bool ResponsiblesSpecified { get { return Responsibles == null ? false : Responsibles.Count != 0; } }

        /// <summary>
        /// Status of the Process Definition. UNDER_REVISION RELEASED UNDER_TEST
        /// </summary>
        [XmlAttribute("PublicationStatus")]
        [DefaultValue(PublicationStatusEnum.UnderTest)]
        public PublicationStatusEnum PublicationStatus { get; set; }
        //[XmlIgnore]
        //public bool PublicationStatusSpecified { get { return PublicationStatus != null; } }



        public RedefinableHeader()
        {
            PublicationStatus = PublicationStatusEnum.UnderTest;
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            RedefinableHeader value = obj as RedefinableHeader;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Version, this.PublicationStatus, this.CountryKey, this.Codepage, this.Author
                };

                List<object> listB = new List<object>
                {
                    value.Version, value.PublicationStatus, value.CountryKey, value.Codepage, value.Author
                };

                if (!Utilities.IsListEqual<Responsible>(this.Responsibles, value.Responsibles))
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