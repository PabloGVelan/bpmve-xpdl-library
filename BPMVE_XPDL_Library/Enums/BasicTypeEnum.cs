using System;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public enum BasicTypeEnum
    {
        /// <summary>
        /// A finite-length sequence of characters.
        /// </summary>
        [XmlEnum("STRING")]
        String,
        /// <summary>
        /// 
        /// </summary>
        [XmlEnum("FLOAT")]
        Float,
        /// <summary>
        /// A number represented by an optional sign followed by a finite-length sequence of 
        /// decimal digits. The maximum size of the integer is not specified in XPDL.
        /// </summary>
        [XmlEnum("INTEGER")]
        Integer,
        /// <summary>
        /// A reference To an external Data type – now deprecated. The ExternalReference is 
        /// the recommended way To refer To an external Data type
        /// </summary>
        [XmlEnum("REFERENCE")]
        Reference,
        /// <summary>
        /// A specific instance of time. The date format is not specified within X
        /// </summary>
        [XmlEnum("DATETIME")]
        DateTime,
        /// <summary>
        /// A specific date instance. This differs From DATETIME in that there is no time component.
        /// </summary>
        [XmlEnum("DATE")]
        Date,
        /// <summary>
        /// A specific time instance. This differs From DATETIME in that there is no date component.
        /// </summary>
        [XmlEnum("TIME")]
        Time,
        /// <summary>
        /// 
        /// </summary>
        [XmlEnum("BOOLEAN")]
        Boolean,
        /// <summary>
        /// A Data instance of a performer type is One having a value of a declared participant.
        /// </summary>
        [XmlEnum("PERFORMER")]
        Performer
    }
}