using System;
using System.Collections.Generic;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.13.2.3. Union Type
    /// </summary>
    public class UnionType : ComplexType
    {
        /// <summary>
        /// A Standard in the union.
        /// </summary>
        public List<Member> Members { get; set; }
    }
}