using System;
using System.Collections.Generic;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.13.2.4. Enumeration Type
    /// </summary>
    public class EnumerationType : ComplexType
    {
        /// <summary>
        /// An element that represents One of the values in an enumeration.
        /// </summary>
        public List<EnumerationValue> EnumerationValues { get; set; }
    }
}