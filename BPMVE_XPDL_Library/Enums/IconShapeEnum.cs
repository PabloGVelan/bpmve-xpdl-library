using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public enum IconShapeEnum
    {
        [XmlEnum("RoundRectangle")]
        RoundRectangle,
        [XmlEnum("Rectangle")]
        Rectangle,
        [XmlEnum("Ellipse")]
        Ellipse,
        [XmlEnum("Diamond")]
        Diamond,
        [XmlEnum("UpTriangle")]
        UpTriangle,
        [XmlEnum("DownTriangle")]
        DownTriangle
    }
}