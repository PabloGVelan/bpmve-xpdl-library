using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class Icon : IValidate
    {
        [XmlAttribute("XCOORD")]
        [DefaultValue(0.0)]
        public double XCoord { get; set; }
        [XmlIgnore]
        public bool XCoordSpecified { get { return XCoord != 0.0; } }

        [XmlAttribute("YCOORD")]
        [DefaultValue(0.0)]
        public double YCoord { get; set; }
        [XmlIgnore]
        public bool YCoordSpecified { get { return YCoord != 0.0; } }

        [XmlAttribute("WIDTH")]
        [DefaultValue(0.0)]
        public double Width { get; set; }
        [XmlIgnore]
        public bool WidthSpecified { get { return Width != 0.0; } }

        [XmlAttribute("HEIGHT")]
        [DefaultValue(0.0)]
        public double Height { get; set; }
        [XmlIgnore]
        public bool HeightSpecified { get { return Height != 0.0; } }

        [XmlAttribute("SHAPE")]
        [DefaultValue(IconShapeEnum.RoundRectangle)]
        public IconShapeEnum Shape { get; set; }
        //[XmlIgnore]
        //public bool ShapeSpecified { get { return Shape != null; } }



        public Icon()
        {
            XCoord = 0.0;
            YCoord = 0.0;
            Width = 0.0;
            Height = 0.0;
            Shape = IconShapeEnum.RoundRectangle;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

		public override bool Equals (object obj)
		{
            Icon value = obj as Icon;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.XCoord, this.YCoord, this.Width, this.Shape, this.Height
                };

                List<object> listB = new List<object>
                {
                    value.XCoord, value.YCoord, value.Width, value.Shape, value.Height
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