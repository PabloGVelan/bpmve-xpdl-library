using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class Color : IValidate
    {
        [XmlAttribute("Alpha")]
        [DefaultValue(0.0)]
        public double Alpha { get; set; }
        [XmlIgnore]
        public bool AlphaSpecified { get { return Alpha != 0.0d; } }

        [XmlAttribute("Red")]
        [DefaultValue(0.0)]
        public double Red { get; set; }
        [XmlIgnore]
        public bool RedSpecified { get { return Red != 0.0d; } }

        [XmlAttribute("Green")]
        [DefaultValue(0.0)]
        public double Green { get; set; }
        [XmlIgnore]
        public bool GreenSpecified { get { return Green != 0.0d; } }

        [XmlAttribute("Blue")]
        [DefaultValue(0.0)]
        public double Blue { get; set; }
        [XmlIgnore]
        public bool BlueSpecified { get { return Blue != 0.0d; } }



        public Color()
        {
            Alpha = 0.0;
            Red = 0.0;
            Green = 0.0;
            Blue = 0.0;
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Color value = obj as Color;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Alpha, this.Red, this.Green, this.Blue
                };

                List<object> listB = new List<object>
                {
                    value.Alpha, value.Red, value.Green, value.Blue
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