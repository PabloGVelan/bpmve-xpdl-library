using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public enum EndEventTriggerEnum
    {
        [XmlEnum("None")]
        None,
        [XmlEnum("Message")]
        Message,
        [XmlEnum("Error")]
        Error,
        [XmlEnum("Cancel")]
        Cancel,
        [XmlEnum("Compensation")]
        Compensation,
        [XmlEnum("Signal")]
        Signal,
        [XmlEnum("Terminate")]
        Terminate,
        [XmlEnum("Multiple")]
        Multiple
    }
}