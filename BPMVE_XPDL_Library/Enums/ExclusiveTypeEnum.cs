using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public enum ExclusiveTypeEnum
    {
        [XmlEnum("Data")]
        Data,
        [XmlEnum("Event")]
        Event
    }
}