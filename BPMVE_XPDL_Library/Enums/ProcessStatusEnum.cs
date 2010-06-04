using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public enum ProcessStatusEnum
    {
        [XmlEnum("None")]
        None,
        [XmlEnum("Ready")]
        Ready,
        [XmlEnum("Active")]
        Active,
        [XmlEnum("Cancelled")]
        Cancelled,
        [XmlEnum("Aborting")]
        Aborting,
        [XmlEnum("Aborted")]
        Aborted,
        [XmlEnum("Completing")]
        Completing,
        [XmlEnum("Completed")]
        Completed
    }
}