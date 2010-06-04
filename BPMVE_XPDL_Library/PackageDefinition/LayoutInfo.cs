using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// All co-ordinates (in NodeGraphicsInfos) have origin of 'top-left, relative To parent 
    /// container'. Co-ordinate units are in pixels. However it would be nice To give Other 
    /// applications a hint as To the scale of a 'pixel' when the XPDL file was saved (i.e. 
    /// the XPDL writer specifies co-ordinates AND sizes in pixels but can also specify 'pixels 
    /// To the millimeter' - the reading application can then, if it wishes, take this into 
    /// account AND scale To its pixel size appropriately).
    /// The default unit should be Pixels. The transformation of whatever measurement unit is 
    /// used internally is left up To the implementing tool.
    /// </summary>
    public class LayoutInfo : IValidate
    {
        [XmlAttribute("PixelsPerMillimeter")]
        public float PixelsPerMillimeter { get; set; }
        [XmlIgnore]
        public bool PixelsPerMillimeterSpecified
        {
            get { return PixelsPerMillimeter != 0.0; }
        }



        public LayoutInfo()
        {
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            LayoutInfo value = obj as LayoutInfo;
            if (value != null)
            {
                return (float.Equals(this.PixelsPerMillimeter, value.PixelsPerMillimeter));
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