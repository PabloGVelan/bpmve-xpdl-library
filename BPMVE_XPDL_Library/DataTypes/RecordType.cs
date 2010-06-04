using System;
using System.Collections.Generic;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.13.2.2. Record Type
    /// </summary>
    public class RecordType : ComplexType
    {
        /// <summary>
        /// A Standard in the record.
        /// </summary>
        public List<Member> Members { get; set; }
    }
}