using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class SimpleType : IValidate
    {
        [XmlText()]
        public virtual string Value { get; set; }
        [XmlIgnore]
        public virtual bool ValueSpecified { get { return !string.IsNullOrEmpty(Value); } }



        public SimpleType()
        {
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public override bool Equals(object obj)
        {
            SimpleType value = obj as SimpleType;
            if (value != null)
            {
                if (this.Value != null && value.Value != null)
                    return (value.Value == this.Value);
                else if (this.Value == null && value.Value == null)
                    return true;
            }

            return false;
        }

        #region IValidate Members

        public virtual bool Validate()
        {
            if (Value != null) 
                return true;
            return false;
        }

        #endregion
    }
}
