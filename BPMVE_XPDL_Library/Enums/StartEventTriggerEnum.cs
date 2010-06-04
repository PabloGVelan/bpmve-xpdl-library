using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public enum StartEventTriggerEnum
    {
        [XmlEnum("None")]
        None,
        [XmlEnum("Message")]
        Message,
        [XmlEnum("Timer")]
        Timer,
        [XmlEnum("Conditional")]
        Conditional,
        [XmlEnum("Signal")]
        Signal,
        [XmlEnum("Multiple")]
        Multiple
    }
}