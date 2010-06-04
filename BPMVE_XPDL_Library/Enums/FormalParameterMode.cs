using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public enum FormalParameterMode
    {
        [XmlEnum("IN")]
        In,
        [XmlEnum("INOUT")]
        InOut,
        [XmlEnum("OUT")]
        Out
    }
}