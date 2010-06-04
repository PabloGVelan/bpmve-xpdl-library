using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.2.1.1. Vendor Extension
    /// Vendor extension is used for vendors To define extensions AND provide a schema AND a 
    /// description for the extensions.
    /// For details, see section 7.1.2.2 Namespace Qualified Extensions.
    /// </summary>
    public class VendorExtension : IValidate
    {
        /// <summary>
        /// Identification of the tool adding this extension. It is the same value used in 
        /// NodeGraphicsInfo ToolId. This value may be a URI.
        /// </summary>
        [XmlAttribute("ToolId")]
        public string ToolId { get; set; }
		[XmlIgnore]
		public bool ToolIdSpecified { get { return ToolId != ""; } }

        /// <summary>
        /// The URI of the namespace for the vendor extension. The XSD for this URI MAY be 
        /// specified by the xsi:schemaLocation as shown in the example below.
        /// </summary>
        [XmlAttribute("schemaLocation")]
        public string SchemaNamespace { get; set; }
        [XmlIgnore]
        public bool SchemaNamespaceSpecified { get { return SchemaNamespace != ""; } }

        /// <summary>
        /// A URI indicating the location of a document describing the extensions provided
        /// by the schema in schemaLocation.
        /// </summary>
        [XmlAttribute("extensionDescription")]
        public string ExtensionDescription { get; set; }
        [XmlIgnore]
        public bool ExtensionDescriptionSpecified { get { return ExtensionDescription != ""; } }



        public VendorExtension()
        {
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            VendorExtension value = obj as VendorExtension;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.ToolId, this.SchemaNamespace, this.ExtensionDescription
                };

                List<object> listB = new List<object>
                {
                    value.ToolId, value.SchemaNamespace, value.ExtensionDescription
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