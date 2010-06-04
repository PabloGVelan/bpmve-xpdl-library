using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public enum CostUnitOfTimeEnum
    {
        [XmlEnum("second")]
        Second,
        [XmlEnum("minute")]
        Minute,
        [XmlEnum("hour")]
        Hour
    }
}