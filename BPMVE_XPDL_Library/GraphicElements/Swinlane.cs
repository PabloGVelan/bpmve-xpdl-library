using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public abstract class Swimlane : GraphicalObject
    {
        /// <summary>
        /// DataObject | Group | Annotation
        /// </summary>
        //[XmlElement("NodeGraphicsInfos")]
        [XmlArray("NodeGraphicsInfos")]
        public abstract List<NodeGraphicsInfo> NodeGraphicalsInfos { get; set; }
        [XmlIgnore]
        public abstract bool NodeGraphicalsInfosSpecified { get; }

        /// <summary>
        /// Used To identify the Swimlane.
        /// </summary>
        [XmlAttribute("Id")]
        public abstract override string Id { get; set; }

        /// <summary>
        /// Name of the Swimlane.
        /// </summary>
        [XmlAttribute("Name")]
        public abstract override string Name { get; set; }
        [XmlIgnore]
        public abstract override bool NameSpecified { get; }

        /// <summary>
        /// See section 7.1.9.4.
        /// </summary>
        [XmlElement("Object")]
        public abstract override Object_XPDL Object { get; set; }
        [XmlIgnore]
        public abstract override bool ObjectSpecified { get; }
    }
}