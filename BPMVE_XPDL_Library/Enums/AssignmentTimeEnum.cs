using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public enum AssignmentTimeEnum
    {
        [XmlEnum("Start")]
        Start,
        [XmlEnum("End")]
        End
    }
}