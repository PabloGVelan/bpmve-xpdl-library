using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// An element that represents One of the values in an enumeration.
    /// </summary>
    public class EnumerationValue
    {
        /// <summary>
        /// The name of the value.
        /// </summary>
        public string Name { get; set; }
		[XmlIgnore]
		public bool NameSpecified { get { return Name != ""; } }
    }
}