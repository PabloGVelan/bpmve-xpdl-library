using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.1.2.3. NodeGraphicsInfo
    /// NodeGraphicsInfo is an optional entity that can be used by a tool To describe graphical 
    /// information. Each graphical node in XPDL (Activity, Pool, Lane, Artifact) has a list of 
    /// NodeGraphicsInfo, One for each tool that has saved the corresponding information in the 
    /// XPDL file. If a tool chooses To use the NodeGraphicsInfo, it should select a tool id, which
    /// can be the name of the tool. Therefore Multiple tools can work using the same XPDL file AND
    /// displaying the process with a different presentation layout.
    /// </summary>
    public class NodeGraphicsInfo : GraphicsInfo, IValidate
    {
        [XmlElement("Coordinates")]
        public override List<Coordinates> Coordinates { get; set; }
        [XmlIgnore]
        public override bool CoordinatesSpecified { get { return Coordinates == null ? false : Coordinates.Count != 0; } }

        [XmlAttribute("ToolId")]
        public override string ToolId { get; set; }
        [XmlIgnore]
        public override bool ToolIdSpecified { get { return ToolId != ""; } }

        [XmlAttribute("IsVisible")]
        [DefaultValue(true)]
        public override bool IsVisible { get; set; }
        //[XmlIgnore]
        //public override bool IsVisibleSpecified { get { return IsVisible != null; } }

        [XmlAttribute("PageId")]
        public override string PageId { get; set; }
        [XmlIgnore]
        public override bool PageIdSpecified { get { return PageId != ""; } }

        /// <summary>
        /// If the node is in a Lane, this is the Id of the Lane.
        /// </summary>
        [XmlAttribute("LaneId")]
        public string LaneId { get; set; }
        [XmlIgnore]
        public bool LaneIdSpecified { get { return LaneId != ""; } }

        /// <summary>
        /// Height of the node. Tool specific AND depends on ToolId.
        /// </summary>
        [XmlAttribute("Height")]
        public double Height { get; set; }
        [XmlIgnore]
        public bool HeightSpecified { get { return Height != 0.0; } }

        /// <summary>
        /// Width of the node. Tool specific AND depends on ToolId.
        /// </summary>
        [XmlAttribute("Width")]
        public double Width { get; set; }
        [XmlIgnore]
        public bool WidthSpecified { get { return Width != 0.0; } }

        [XmlAttribute("BorderColor")]
        public override string BorderColor { get; set; }
        [XmlIgnore]
        public override bool BorderColorSpecified { get { return BorderColor != ""; } }

        [XmlAttribute("FillColor")]
        public override string FillColor { get; set; }
        [XmlIgnore]
        public override bool FillColorSpecified { get { return FillColor != ""; } }

        [XmlAttribute("Shape")]
        public string Shape { get; set; }
        [XmlIgnore]
        public bool ShapeSpecified { get { return Shape != ""; } }

        [XmlAttribute("OpenSimColor")]
        public string OpensimColor { get; set; }
        [XmlIgnore]
        public bool OpensimColorSpecified { get { return OpensimColor != ""; } }

        [XmlAttribute("OpenSimLocation")]
        public string OpensimLocation { get; set; }
        [XmlIgnore]
        public bool OpensimLocationSpecified { get { return OpensimLocation != ""; } }



        public NodeGraphicsInfo()
        {
            IsVisible = true;
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            NodeGraphicsInfo value = obj as NodeGraphicsInfo;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.LaneId, this.Height, this.Width, this.ToolId, this.IsVisible,
                    this.PageId, this.BorderColor, this.FillColor, this.Shape, this.OpensimColor,
                    this.OpensimLocation
                };

                List<object> listB = new List<object>
                {
                    value.LaneId, value.Height, value.Width, value.ToolId, value.IsVisible,
                    value.PageId, value.BorderColor, value.FillColor, value.Shape, value.OpensimColor,
                    value.OpensimLocation
                };

                if (!Utilities.IsListEqual<Coordinates>(this.Coordinates, value.Coordinates))
                    return false;

                return (Utilities.IsEqual(listA, listB));
            }

            return false;
        }

        #region IValidate Members

        public bool Validate()
        {
            return true;
        }

        #endregion
    }
}