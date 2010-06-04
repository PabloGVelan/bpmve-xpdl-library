using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public enum TransactionMethodEnum
    {
        [XmlEnum("Compensate")]
        Compensate,
        [XmlEnum("Store")]
        Store,
        [XmlEnum("Image")]
        Image
    }
}