using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// Abstract superclass of NodeGraphicsInfo AND ConnectorGraphicsInfo, encapsulated information 
    /// relavent To Both classes.
    /// </summary>
    public abstract class GraphicsInfo
    {
        /// <summary>
        /// Tool id. This may correspond To the name of the tool generating the XPDL file. Note that 
        /// Multiple GraphicsInfo elements may appear in an element. This allows each tool To have 
        /// its GraphicsInfo, allowing for different tools using the same XPDL file To represent the
        /// element in totally different ways. Each tool read AND writes its own GraphicsInfo based 
        /// on its ToolId, AND it leaves untouched the GraphicsInfo From Other tools.
        /// </summary>
        [XmlAttribute("ToolId")]
        public abstract string ToolId { get; set; }
        [XmlIgnore]
        public abstract bool ToolIdSpecified { get; }

        /// <summary>
        /// True indicates node should be shown.
        /// </summary>
        [XmlAttribute("IsVisible")]
        public abstract bool IsVisible { get; set; }
        //[XmlIgnore]
        //public abstract bool IsVisibleSpecified { get; }

        /// <summary>
        /// The id of the page on which this node should be displayed. Refers To Pages element 
        /// described in section 7.1.2.1.
        /// </summary>
        [XmlAttribute("PageId")]
        public abstract string PageId { get; set; }
        [XmlIgnore]
        public abstract bool PageIdSpecified { get; }

        /// <summary>
        /// Color of the border, expressed as a string.
        /// </summary>
        [XmlAttribute("BorderColor")]
        public abstract string BorderColor { get; set; }
        [XmlIgnore]
        public abstract bool BorderColorSpecified { get; }

        /// <summary>
        /// X AND Y coordinates of points in the path. Tool specific AND depends on ToolId.
        /// </summary>
        [XmlElement("Coordinates")]
        public abstract List<Coordinates> Coordinates { get; set; }
        [XmlIgnore]
        public abstract bool CoordinatesSpecified { get; }

        /// <summary>
        /// Color of the fill, expressed as a string. Tool specific AND depends on ToolId.
        /// </summary>
        [XmlAttribute("FillColor")]
        public abstract string FillColor { get; set; }
        [XmlIgnore]
        public abstract bool FillColorSpecified { get; }

        ///// <summary>
        ///// Shape, expressed as a string: used To override BPMN shapes.
        ///// </summary>
        //[XmlAttribute("Shape")]
        //public abstract string Shape { get; set; }
        //[XmlIgnore]
        //public abstract bool ShapeSpecified { get; }
    }
}