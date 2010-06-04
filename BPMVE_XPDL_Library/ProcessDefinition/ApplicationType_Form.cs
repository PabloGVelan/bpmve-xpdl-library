using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.3.2.7. Form
    /// The Standard does not decide which kind of a form layout should be used. The Form Application
    /// Type defines a place where All form related information should be stored.
    /// </summary>
    public class ApplicationType_Form : IValidate
    {
        /// <summary>
        /// Optional description of form layout.
        /// </summary>
        [XmlElement("FormLayout")]
        public string FormLayout { get; set; }
        [XmlIgnore]
        public bool FormLayoutSpecified { get { return FormLayout != ""; } }



        public ApplicationType_Form()
        {
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            ApplicationType_Form value = obj as ApplicationType_Form;
            if (value != null)
            {
                if (this.FormLayout != null &&
                    value.FormLayout != null)
                    return (value.FormLayout == this.FormLayout);
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