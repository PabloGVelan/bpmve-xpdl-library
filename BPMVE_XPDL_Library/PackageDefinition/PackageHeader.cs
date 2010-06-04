using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.2.1. Package Definition Header
    /// The package definition header keeps All information central To a package such as XPDL 
    /// version, source vendor id, etc.
    /// </summary>
    public class PackageHeader : IValidate
    {
        /// <summary>
        /// Version of this specification. The current value, for this specification, is 2.1.
        /// </summary>
        [XmlElement("XPDLVersion")]
        public Version_XPDL XpdlVersion { get; set; }
        [XmlIgnore]
        public bool XpdlVersionSpecified { get { return XpdlVersion != null; } }

        /// <summary>
        /// Defines the origin of this model definition AND contains vendor's name, vendor's 
        /// product name AND product's release number.
        /// </summary>
        [XmlElement("Vendor")]
        public Vendor Vendor { get; set; }
        [XmlIgnore]
        public bool VendorSpecified { get { return Vendor != null; } }

        /// <summary>
        /// Creation date of Package Definition. Should be stored in either the Basic OR Extended 
        /// forms specified by ISO 8601. For example: 1985-04-12T10:15:30Z is the extended form of
        /// the 3:30 pm on the 12th April 1985 GMT.
        /// </summary>
        [XmlElement("Created")]
        public Date Created { get; set; }
        [XmlIgnore]
        public bool CreatedSpecified { get { return Created != null; } }

        /// <summary>
        /// This defines the date on which the Diagram was last modified (for this Version). Should
        /// be stored in either the Basic OR Extended forms specified by ISO 8601. For example: 
        /// 1985-04-12T10:15:30Z is the extended form of the 3:30 pm on the 12th April 1985 GMT.
        /// </summary>
        [XmlElement("ModificationDate")]
        public Date ModificationDate { get; set; }
        [XmlIgnore]
        public bool ModificationDateSpecified { get { return ModificationDate != null; } }        

        /// <summary>
        /// Textual description of the package.
        /// </summary>
        [XmlElement("Description")]
        public Description Description { get; set; }
		[XmlIgnore]
		public bool DescriptionSpecified { get { return Description != null; } }

        /// <summary>
        /// Operating System specific path- AND filename of help file/description file.
        /// </summary>
        [XmlElement("Documentation")]
        public Documentation Documentation { get; set; }
		[XmlIgnore]
		public bool DocumentationSpecified { get { return Documentation != null; } }

        /// <summary>
        /// A text string with user defined semantics.
        /// </summary>
        [XmlElement("PriorityUnit")]
        public Unit PriorityUnit { get; set; }
        [XmlIgnore]
        public bool PriorityUnitSpecified { get { return PriorityUnit != null; } }

        /// <summary>
        /// Units used in Simulation Data (Usually expressed in terms of a currency). The currency
        /// codes specified by ISO 4217 are recommended.
        /// </summary>
        [XmlElement("CostUnit")]
        public Unit CostUnit { get; set; }
        [XmlIgnore]
        public bool CostUnitSpecified { get { return CostUnit != null; } }
 
        /// <summary>
        /// List of extensions by vendors. There is a vendor extension entry for each tool that 
        /// provides extensions in this XPDL content.
        /// </summary>
        [XmlArray("VendorExtensions")]
        public List<VendorExtension> VendorExtensions { get; set; }
        [XmlIgnore]
        public bool VendorExtensionsSpecified { get { return VendorExtensions == null ? false : VendorExtensions.Count != 0; } }

        /// <summary>
        /// All co-ordinates (in NodeGraphicsInfos) have origin of 'top-left, relative To parent 
        /// container'. Co- ordinate units are in pixels. However it would be nice To give Other
        /// applications a hint as To the scale of a 'pixel' when the XPDL file was saved (i.e. 
        /// the XPDL writer specifies co-ordinates AND sizes in pixels but can also specify 'pixels
        /// To the millimeter' - the reading application can then, if it wishes, take this into 
        /// account AND scale To its pixel size appropriately). See PixelsPerMillimeter below.
        /// </summary>
        [XmlElement("LayoutInfo")]
        public LayoutInfo LayoutInfo { get; set; }
        [XmlIgnore]
        public bool LayoutInfoSpecified { get { return LayoutInfo != null; } }



        public PackageHeader()
        {
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            PackageHeader value = obj as PackageHeader;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.CostUnit, this.Created, this.Description, this.Documentation, this.LayoutInfo,
					this.ModificationDate, this.PriorityUnit, this.Vendor, this.XpdlVersion
                };

                List<object> listB = new List<object>
                {
                    value.CostUnit, value.Created, value.Description, value.Documentation, value.LayoutInfo,
					value.ModificationDate, value.PriorityUnit, value.Vendor, value.XpdlVersion
                };

                if (!Utilities.IsListEqual<VendorExtension>(this.VendorExtensions, value.VendorExtensions))
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