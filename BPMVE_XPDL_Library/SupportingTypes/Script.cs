using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class Script : IValidate
    {
        [XmlAttribute("Type")]
        public string Type { get; set; }
        [XmlIgnore]
        public bool TypeSpecified { get { return Type != ""; } }

        [XmlAttribute("Version")]
        public string Version { get; set; }
        [XmlIgnore]
        public bool VersionSpecified { get { return Version != ""; } }

        [XmlAttribute("Grammar")]
        public string Grammar { get; set; }
        [XmlIgnore]
        public bool GrammarSpecified { get { return Grammar != ""; } }



        public Script()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Script value = obj as Script;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Type, this.Version, this.Grammar
                };

                List<object> listB = new List<object>
                {
                    value.Type, value.Version, value.Grammar
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