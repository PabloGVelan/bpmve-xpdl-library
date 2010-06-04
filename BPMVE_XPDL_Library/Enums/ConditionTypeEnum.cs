using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public enum ConditionTypeEnum
    {
        [XmlEnum("CONDITION")]
        Condition,
        [XmlEnum("OTHERWISE")]
        Otherwise,
        [XmlEnum("EXCEPTION")]
        Exception,
        [XmlEnum("DEFAULTEXCEPTION")]
        DefaultException
    }
}