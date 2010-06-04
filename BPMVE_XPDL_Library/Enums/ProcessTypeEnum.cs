using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public enum ProcessTypeEnum
    {
        [XmlEnum("None")]
        None,
        [XmlEnum("Private")]
        Private,
        [XmlEnum("Abstract")]
        Abstract,
        [XmlEnum("Collaboration")]
        Collaboration
    }
}