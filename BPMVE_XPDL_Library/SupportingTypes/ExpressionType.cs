using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class Expression : IValidate
    {
        [XmlAttribute("ScriptType")]
        public virtual string ScriptType { get; set; }
        [XmlIgnore]
        public virtual bool ScriptTypeSpecified { get { return ScriptType != ""; } }

        [XmlAttribute("ScriptGrammer")]
        public virtual string ScriptGrammer { get; set; }
        [XmlIgnore]
        public virtual bool ScriptGrammerSpecified { get { return ScriptGrammer != ""; } }

        [XmlAttribute("ScriptVersion")]
        public virtual string ScriptVersion { get; set; }
        [XmlIgnore]
        public virtual bool ScriptVersionSpecified { get { return ScriptVersion != ""; } }



        public Expression()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Expression value = obj as Expression;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.ScriptType, this.ScriptGrammer, this.ScriptVersion
                };

                List<object> listB = new List<object>
                {
                    value.ScriptType, value.ScriptGrammer, value.ScriptVersion
                };

                return (Utilities.IsEqual(listA, listB));
            }

            return false;
        }

        #region IValidate Members

        public virtual bool Validate()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}