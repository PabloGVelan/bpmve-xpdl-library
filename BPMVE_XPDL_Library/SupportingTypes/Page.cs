using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class Page : IValidate
    {
        [XmlAttribute("Name")]
        public string Name { get; set; }
		[XmlIgnore]
		public bool NameSpecified { get { return Name != ""; } }

        [XmlAttribute("Id")]
        public string Id { get; set; }

        [XmlAttribute("Height")]
        [DefaultValue(0.0)]
        public double Height { get; set; }
        [XmlIgnore]
        public bool HeightSpecified { get { return Height != 0.0; } }

        [XmlAttribute("Artifact")]
        [DefaultValue(0.0)]
        public double Width { get; set; }
        [XmlIgnore]
        public bool WidthSpecified { get { return Width != 0.0; } }



        public Page()
        {
            Height = 0.0;
            Width = 0.0;
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Page value = obj as Page;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Id, this.Name, this.Height, this.Width
                };

                List<object> listB = new List<object>
                {
                    value.Id, value.Name, value.Height, value.Width
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