using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library 
{
    /// <summary>
    /// 7.1.2.4. ConnectorGraphicsInfo
    /// ConnectorGraphicsInfo is an optional entity that can be used by a tool To describe graphical 
    /// information for connecting objects (SequenceFlow, MessageFlow, Associations). Each connector
    /// in XPDL has a list of ConnectorGraphicsInfo, One for each tool that has saved the corresponding
    /// information in the XPDL file. If a tool chooses To use the ConnectorGraphicsInfo, it should 
    /// select a tool id, which can be the name of the tool. Therefore Multiple tools can work using 
    /// the same XPDL file AND displaying the process with a different presentation layout.
    /// All co-ordinates have origin of top-left, relative To the parent container OR page. The 
    /// co-ordinates list should include the path End points (clipped To the boundary of the source 
    /// AND destination nodes as applicable). If the co-ordinate path is omited it is assumed that 
    /// the path is a single segment between the centers of the source AND destination nodes (clipping 
    /// is applied as needed To the endpoints).
    /// </summary>
    public class ConnectorGraphicsInfo : GraphicsInfo, IValidate
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
        /// LineStyle. Tool specific AND depends on ToolId. Should not conflict with BPMN recommended
        /// styles for SequenceFlow, MessageFlow AND Association.
        /// </summary>
        [XmlAttribute("Style")]
        public string Style { get; set; }
        [XmlIgnore]
        public bool StyleSpecified { get { return Style != ""; } }

        [XmlAttribute("BorderColor")]
        public override string BorderColor { get; set; }
        [XmlIgnore]
        public override bool BorderColorSpecified { get { return BorderColor != ""; } }

        [XmlAttribute("FillColor")]
        public override string FillColor { get; set; }
        [XmlIgnore]
        public override bool FillColorSpecified { get { return FillColor != ""; } }

        //[XmlAttribute("Shape")]
        //public override string Shape { get; set; }
        //[XmlIgnore]
        //public override bool ShapeSpecified { get { return Shape != ""; } }



        public ConnectorGraphicsInfo()
        {
			IsVisible = true;
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            ConnectorGraphicsInfo value = obj as ConnectorGraphicsInfo;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Style, this.ToolId, this.IsVisible, this.PageId,
                    this.BorderColor,this.FillColor
                };

                List<object> listB = new List<object>
                {
                    value.Style, value.ToolId, value.IsVisible, value.PageId,
                    value.BorderColor, value.FillColor
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