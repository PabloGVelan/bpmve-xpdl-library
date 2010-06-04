using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.3.2.6. Business Rule
    /// Application that invokes a Business Rule.
    /// </summary>
    public class ApplicationType_BusinessRule : IValidate
    {
        /// <summary>
        /// Name of the Business Rule.
        /// </summary>
        [XmlElement("RuleName")]
        public string RuleName { get; set; }
		[XmlIgnore]
        public bool RuleNameSpecified { get { return RuleName != ""; } }

        /// <summary>
        /// Location of the Rule.
        /// </summary>
        [XmlElement("Location")]
        public string Location { get; set; }
        [XmlIgnore]
        public bool LocationSpecified { get { return Location != ""; } }



        public ApplicationType_BusinessRule()
        {
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            ApplicationType_BusinessRule value = obj as ApplicationType_BusinessRule;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.RuleName, this.Location
                };

                List<object> listB = new List<object>
                {
                    value.RuleName, value.Location
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