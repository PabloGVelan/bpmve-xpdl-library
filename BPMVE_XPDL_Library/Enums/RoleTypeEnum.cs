using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public enum RoleTypeEnum
    {
        [XmlEnum("MyRole")]
        MyRole,
        [XmlEnum("PartnerRole")]
        PartnerRole
    }
}