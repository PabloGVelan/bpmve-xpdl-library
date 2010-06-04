using System;
using System.Collections.Generic;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.13. Data Types
    /// Data types consist of a set of Standard types that may be used as part of the Data specification of relevant Data Standard, formal parameters, AND Processes. You can also declare a new Data type within a TypeDeclaration AND use it wherever the Standard Data types are used. A Data type may be selected From the following set of types.
    /// </summary>
    public abstract class DataType
    {
        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            //FIXME
            return true;
        }
    }
}