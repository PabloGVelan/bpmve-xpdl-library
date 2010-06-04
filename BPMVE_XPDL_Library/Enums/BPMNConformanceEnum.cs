using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public enum BPMNConformanceEnum
    {
        /// <summary>
        /// The document is not BPMN compliant.
        /// </summary>
        [XmlEnum("NONE")]
        None,
        /// <summary>
        /// The document conforms To the requirements for portability of models containing a Simple set of BPMN elements.
        /// </summary>
        [XmlEnum("SIMPLE")]
        Simple,
        /// <summary>
        /// The document conforms To the requirements for portability of models containing the Standard set of BPMN elements.
        /// </summary>
        [XmlEnum("STANDARD")]
        Standard,
        /// <summary>
        /// The document conforms To the requirements for portability of models containing the full set of BPMN elements.
        /// </summary>
        [XmlEnum("COMPLETE")]
        Complete
    }
}