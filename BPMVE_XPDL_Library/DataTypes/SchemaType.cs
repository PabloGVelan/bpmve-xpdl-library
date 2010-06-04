using System;
using System.Collections.Generic;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.13.2.1. Schema Type
    /// The SchemaType allows users To define a Data type using XML schema syntax. It may also be 
    /// used To define an XML string that should conform To the schema.
    /// </summary>
    public class SchemaType : ComplexType
    {
        public int TypeName { get; set; }

        public int Elements { get; set; }
    }
}