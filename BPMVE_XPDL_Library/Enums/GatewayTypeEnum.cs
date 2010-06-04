using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// Used when needed for BPMN Gateways. Gate AND sequence information is associated
    /// with the Transition Element
    /// </summary>
    public enum GatewayTypeEnum
    {
        [XmlEnum("XOR")]
        XOR,
        [XmlEnum("Exclusive")]
        Exclusive,
        [XmlEnum("OR")]
        OR,
        [XmlEnum("Inclusive")]
        Inclusive,
        [XmlEnum("Complex")]
        Complex,
        [XmlEnum("AND")]
        AND,
        [XmlEnum("Parallel")]
        Parallel
    }
}