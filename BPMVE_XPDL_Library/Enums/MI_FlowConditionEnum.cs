using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public enum MI_FlowConditionEnum
    {
        [XmlEnum("None")]
        None,
        [XmlEnum("One")]
        One,
        [XmlEnum("All")]
        All,
        [XmlEnum("Complex")]
        Complex
    }
}