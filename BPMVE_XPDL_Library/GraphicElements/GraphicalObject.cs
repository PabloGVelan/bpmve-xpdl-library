using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public abstract class GraphicalObject
    {
        /// <summary>
        /// Used To identify the GraphicalObject.
        /// </summary>
        [XmlAttribute("Id")]
        public abstract string Id { get; set; }

        /// <summary>
        /// Name of the GraphicalObject.
        /// </summary>
        [XmlAttribute("Name")]
        public abstract string Name { get; set; }
        [XmlIgnore]
        public abstract bool NameSpecified { get; }

        /// <summary>
        /// See section 7.1.9.4.
        /// </summary>
        [XmlElement("Object")]
        public abstract Object_XPDL Object { get; set; }
        [XmlIgnore]
        public abstract bool ObjectSpecified { get; }
    }
}