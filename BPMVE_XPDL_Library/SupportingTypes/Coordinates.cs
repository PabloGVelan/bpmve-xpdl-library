using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class Coordinates : IValidate
    {
        [XmlAttribute("XCoordinate")]
        public string X { get; set; }
        [XmlIgnore]
        public bool XSpecified { get { return X != ""; } }

        [XmlAttribute("YCoordinate")]
        public string Y { get; set; }
        [XmlIgnore]
        public bool YSpecified { get { return Y != ""; } }



        public Coordinates()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Coordinates value = obj as Coordinates;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.X, this.Y
                };

                List<object> listB = new List<object>
                {
                    value.X, value.Y
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
