using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public enum PublicationStatusEnum
    {
        [XmlEnum("UNDER_REVISION")]
        UnderRevision,
        [XmlEnum("RELEASED")]
        Released,
        [XmlEnum("UNDER_TEST")]
        UnderTest
    }
}