using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class Assignment : IValidate
    {
        [XmlElement("Target")]
        public Expression Target { get; set; }
		[XmlIgnore]
		public bool TargetSpecified { get { return Target != null; } }

        [XmlElement("Expression")]
        public Expression Expression { get; set; }
		[XmlIgnore]
		public bool ExpressionSpecified { get { return Expression != null; } }

        [XmlAttribute("AssignTime")]
        [DefaultValue(AssignmentTimeEnum.Start)]
        public AssignmentTimeEnum AssignTime { get; set; }
        //[XmlIgnore]
        //public bool AssignTimeSpecified { get { return AssignTime != null; } }



        public Assignment()
        {
            AssignTime = AssignmentTimeEnum.Start;
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Assignment value = obj as Assignment;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Target, this.Expression, this.AssignTime
                };

                List<object> listB = new List<object>
                {
                    value.Target, value.Expression, value.AssignTime
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