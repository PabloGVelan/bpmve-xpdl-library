using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public enum OrderingEnum
    {
        [XmlEnum("Sequential")]
        Sequential,
        [XmlEnum("Parallel")]
        Parallel
    }
}