using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public enum GraphConformanceEnum
    {
        /// <summary>
        /// The network structure is restricted To proper nesting of SPLIT/JOIN AND loops.
        /// </summary>
        [XmlEnum("FULL_BLOCKED")]
        FullBlocked,
        /// <summary>
        /// The network structure is restricted To proper nesting of loops.
        /// </summary>
        [XmlEnum("LOOP_BLOCKED")]
        LoopBlocked,
        /// <summary>
        /// There is no restriction on the network structure. This is the default.
        /// </summary>
        [XmlEnum("NON_BLOCKED")]
        NonBlocked
    }
}