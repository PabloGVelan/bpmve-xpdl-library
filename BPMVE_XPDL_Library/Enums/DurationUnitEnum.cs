using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public enum DurationUnitEnum
    {
        [XmlEnum("Y")]
        Year,
        [XmlEnum("M")]
        Month,
        [XmlEnum("D")]
        Day,
        [XmlEnum("h")]
        Hour,
        [XmlEnum("m")]
        Minute,
        [XmlEnum("s")]
        Second
    }
}