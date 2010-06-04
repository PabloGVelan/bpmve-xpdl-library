using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.3.2.4. Script
    /// Application that executes a script (expression) using formal parameters. 
    /// The script should have access only To formal parameters of the application.
    /// </summary>
    public class ApplicationType_Script : IValidate
    {
        /// <summary>
        /// The script.
        /// </summary>
        [XmlElement("Expression")]
        public Expression Expression { get; set; }
		[XmlIgnore]
        public bool ExpressionSpecified { get { return Expression != null; } }



        public ApplicationType_Script()
        {
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            ApplicationType_Script value = obj as ApplicationType_Script;
            if (value != null)
            {
                if (this.Expression != null &&
                    value.Expression != null)
                    return (value.Expression.Equals(this.Expression));
            }

            return false;
        }

        #region IValidate Members

        public bool Validate()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}