using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public enum IntermediateEventTriggerEnum
    {
        [XmlEnum("None")]
        None,
        [XmlEnum("Message")]
        Message,
        [XmlEnum("Timer")]
        Timer,
        [XmlEnum("Error")]
        Error,
        [XmlEnum("Cancel")]
        Cancel,
        [XmlEnum("Conditional")]
        Conditional,
        [XmlEnum("Link")]
        Link,
        [XmlEnum("Signal")]
        Signal,
        [XmlEnum("Compensation")]
        Compensation,
        [XmlEnum("Multiple")]
        Multiple
    }
}