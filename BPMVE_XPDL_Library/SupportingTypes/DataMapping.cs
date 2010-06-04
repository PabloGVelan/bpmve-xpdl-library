using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class DataMapping : IValidate
    {
        [XmlElement("Actual")]
        public Expression Actual { get; set; }
        [XmlIgnore]
        public bool ActualSpecified { get { return Actual != null; } }

        [XmlElement("TestValue")]
        public Expression TestValue { get; set; }
        [XmlIgnore]
        public bool TestValueSpecified { get { return TestValue != null; } }

        [XmlAttribute("Formal")]
        public string Formal { get; set; }
        [XmlIgnore]
        public bool FormalSpecified { get { return Formal != ""; } }

        [XmlAttribute("Direction")]
        [DefaultValue(DirectionEnum.In)]
        public DirectionEnum Direction { get; set; }
        //[XmlIgnore]
        //public bool DirectionSpecified { get { return Direction != null; } }



        public DataMapping()
        {
            Direction = DirectionEnum.In;
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            DataMapping value = obj as DataMapping;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Actual, this.TestValue, this.Formal, this.Direction
                };

                List<object> listB = new List<object>
                {
                    value.Actual, value.TestValue, value.Formal, value.Direction
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