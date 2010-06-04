using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.3.2.2. POJO
    /// Application type that defines information required To call method on local Java class. 
    /// Formal Parameters restrictions are the same as for EJB application type.
    /// </summary>
    public class ApplicationType_POJO : IValidate
    {
        /// <summary>
        /// Fully qualified name of the class.
        /// </summary>
        [XmlElement("Class")]
        public string Class { get; set; }
        [XmlIgnore]
        public bool ClassSpecified { get { return Class != ""; } }

        /// <summary>
        /// Method that will be invoked.
        /// </summary>
        [XmlElement("Method")]
        public string Method { get; set; }
        [XmlIgnore]
        public bool MethodSpecified { get { return Method != ""; } }



        public ApplicationType_POJO()
        {
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            ApplicationType_POJO value = obj as ApplicationType_POJO;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Class, this.Method
                };

                List<object> listB = new List<object>
                {
                    value.Class, value.Method
                };

                return (Utilities.IsEqual(listA, listB));
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