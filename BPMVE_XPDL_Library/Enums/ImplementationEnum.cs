using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public enum ImplementationEnum
    {
        [XmlEnum("WebService")]
        WebService,
        [XmlEnum("Other")]
        Other,
        [XmlEnum("Unspecified")]
        Unspecified
    }
}