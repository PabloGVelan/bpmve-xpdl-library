using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.13.3.2. Declared Type
    /// </summary>
    public class DeclaredType : DataType
    {
        /// <summary>
        /// A reference To a Data type declared in a TypeDeclaration.
        /// </summary>
        public Id Id { get; set; }

        /// <summary>
        /// A name for the declared type
        /// </summary>
        public string Name { get; set; }
		[XmlIgnore]
		public bool NameSpecified { get { return Name != ""; } }
    }
}