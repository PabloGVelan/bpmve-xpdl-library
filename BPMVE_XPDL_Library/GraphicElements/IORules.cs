using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class IORules : IValidate
    {
        [XmlArray("Expression")]
        public List<Expression> Expressions { get; set; }
		[XmlIgnore]
		public bool ExpressionsSpecified { get { return Expressions == null ? false : Expressions.Count != 0; } }



        public IORules()
        {
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

		public override bool Equals (object obj)
		{
            IORules value = obj as IORules;

            if (value != null)
            {
				return (Utilities.IsListEqual<Expression>(this.Expressions, value.Expressions));
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