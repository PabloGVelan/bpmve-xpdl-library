using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class MyRole : IValidate
    {
        [XmlAttribute("RoleName")]
        public string RoleName { get; set; }
		[XmlIgnore]
		public bool RoleNameSpecified { get { return RoleName != ""; } }



        public MyRole()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            MyRole value = obj as MyRole;
            if (value != null)
            {
                if (this.RoleName != null &&
                    value.RoleName != null)
                    return (value.RoleName == this.RoleName);
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
