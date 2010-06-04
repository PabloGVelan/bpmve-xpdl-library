using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public enum AssociationDirectionEnum
    {
        [XmlEnum("None")]
        None,
        [XmlEnum("To")]
        To,
        [XmlEnum("From")]
        From,
        [XmlEnum("Both")]
        Both
    }
}