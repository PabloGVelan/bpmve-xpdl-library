using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.3.2.3. XSLT
    /// Application that uses XSL transformation on formal parameters. The Application should have 
    /// One IN AND One OUT formal parameter, OR if the transformation transforms the formal 
    /// parameter into a document in the same schema the application can have One INOUT formal parameter.
    /// </summary>
    public class ApplicationType_XSLT : IValidate
    {
        /// <summary>
        /// Location of the XSL transformation.
        /// </summary>
        [XmlAttribute("Location")]
        public string Location { get; set; }
        [XmlIgnore]
        public bool LocationSpecified { get { return Location != ""; } }



        public ApplicationType_XSLT()
        {
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            ApplicationType_XSLT value = obj as ApplicationType_XSLT;
            if (value != null)
            {
                if (this.Location != null &&
                    value.Location != null)
                    return (value.Location == this.Location);
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