using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.13.3. Declared Data Types
    /// It is possible To reuse a Complex Data definition wherever you can use a Standard XPDL 
    /// type. Define the Data type under a TypeDeclaration AND then refer To it using the 
    /// DeclaredType Data type.
    /// </summary>
    public class TypeDeclaration : DataType
    {
        /// <summary>
        /// The Data type. See Table 90: Standard Data Types.
        /// </summary>
        public DataType DataType { get; set; }
		[XmlIgnore]
		public bool DataTypeSpecified { get { return DataType != null; } }

        /// <summary>
        /// An informal description of the Data type.
        /// </summary>
        public List<Description> Descriptions { get; set; }
		[XmlIgnore]
		public bool DescriptionsSpecified { get { return Descriptions.Count != 0; } }

        /// <summary>
        /// Optional extensions To meet individual implementation needs.
        /// </summary>
        public List<ExtendedAttribute> ExtendedAttributes { get; set; }
        [XmlIgnore]
        public bool ExtendedAttributesSpecified { get { return ExtendedAttributes.Count != 0; } }

        /// <summary>
        /// An identifier for the TypeDeclaration.
        /// </summary>
        public Id Id { get; set; }

        /// <summary>
        /// The name of the TypeDeclaration.
        /// </summary>
        public string Name { get; set; }
		[XmlIgnore]
		public bool NameSpecified { get { return Name != ""; } }
    }
}