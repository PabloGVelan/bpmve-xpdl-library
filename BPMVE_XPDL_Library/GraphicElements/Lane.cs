using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.4.2. Lane
    /// A Lane is a sub-partition within a Pool AND will extend the entire length of the Pool, 
    /// either vertically (see Figure below) OR horizontally (see Figure below). If the pool is 
    /// invisibly bounded, the lane associated with the pool must extend the entire length of the 
    /// pool. Text associated with the Lane (e.g., its name AND/OR any attribute) can be placed
    /// inside the shape, in any direction OR location, depending on the preference of the modeler
    /// OR modeling tool vendor. Our examples place the name as a banner on the left side (for 
    /// Horizontal Pools) OR at the top (for Vertical Pools) on the Other side of the line that 
    /// separates the Pool name; however, this is not a requirement.
    /// </summary>
    public class Lane : Swimlane, IValidate
    {
        /// <summary>
        /// See section 7.1.9.4.
        /// </summary>
        [XmlElement("Object")]
        public override Object_XPDL Object { get; set; }
        [XmlIgnore]
        public override bool ObjectSpecified { get { return Object != null; } }

        [XmlArray("NodeGraphicsInfos")]
        public override List<NodeGraphicsInfo> NodeGraphicalsInfos { get; set; }
        [XmlIgnore]
        public override bool NodeGraphicalsInfosSpecified
        {
            get
            {
                return (NodeGraphicalsInfos == null ? false : NodeGraphicalsInfos.Count != 0);
            }
        }

        /// <summary>
        /// A Swim Lane in a Pool is often used To designate the default 'Role' required To 
        /// perform any of the activities in the lane. This optional element provides the ability
        /// To specify the default performers for All activities in the lane. Any individual 
        /// activity can override this with its own performer expression.
        /// </summary>
        [XmlArray("Performers")]
        public List<Performer> Performers { get; set; }
        [XmlIgnore]
        public bool PerformersSpecified { get { return Performers == null ? false : Performers.Count != 0; } }

        /// <summary>
        /// This element identifies any Lanes that are nested within the current Lane.
        /// </summary>
        //[XmlElement("NestedLanes")]
        [XmlArray("NestedLanes")]
        public List<Lane> NestedLanes { get; set; }
		[XmlIgnore]
        public bool NestedLanesSpecified { get { return NestedLanes == null ? false : NestedLanes.Count != 0; } }

        /// <summary>
        /// Used To identify the Lane.
        /// </summary>
        [XmlAttribute("Id")]
        public override string Id { get; set; }

        /// <summary>
        /// Name of the Lane.
        /// </summary>
        [XmlAttribute("Name")]
        public override string Name { get; set; }
		[XmlIgnore]
		public override bool NameSpecified { get { return Name != ""; } }

        [XmlAttribute("ParentLane")]
        public string ParentLane { get; set; }
        [XmlIgnore]
        public bool ParentLaneSpecified { get { return string.IsNullOrEmpty(ParentLane); } }

        [XmlAttribute("ParentPool")]
        public string ParentPool { get; set; }
        [XmlIgnore]
        public bool ParentPoolSpecified { get { return string.IsNullOrEmpty(ParentPool); } }



        public Lane()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Lane value = obj as Lane;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Id, this.Name, this.Object
                };

                List<object> listB = new List<object>
                {
                    value.Id, value.Name, value.Object
                };

                if (!Utilities.IsListEqual<Lane>(this.NestedLanes, value.NestedLanes) ||
                    !Utilities.IsListEqual<Performer>(this.Performers, value.Performers) ||
                    !Utilities.IsListEqual<NodeGraphicsInfo>(this.NodeGraphicalsInfos, value.NodeGraphicalsInfos))
                {
                    return false;
                }

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