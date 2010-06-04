using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.4.1.
    /// A Pool represents a Participant in the Process. A Participant can be a specific business
    /// entity (e.g. a company) OR can be a more general business Role (e.g., a buyer, seller, 
    /// OR manufacturer). Graphically, a Pool is a container for partitioning a Process From Other
    /// Pools, when modeling business-To-business situations, although a Pool need not have any 
    /// internal details (i.e., it can be a ―black box‖).
    /// Note that the term Participant in the context of Pools is a BPMN concept that differs From 
    /// the same term used in XPDL Participant Declaration, Participant Assignment AND Performer
    /// expressions.
    /// </summary>
    public class Pool : Swimlane, IValidate
    {
        /// <summary>
        /// The lanes in the pool. See section 7.4.2.
        /// </summary>
        [XmlArray("Lanes")]
        public List<Lane> Lanes { get; set; }
		[XmlIgnore]
        public bool LanesSpecified { get { return Lanes == null ? false : Lanes.Count != 0; } }

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
        /// Used To identify the Pool.
        /// </summary>
        [XmlAttribute("Id")]
        public override string Id { get; set; }

        /// <summary>
        /// Name of the Pool.
        /// </summary>
        [XmlAttribute("Name")]
        public override string Name { get; set; }
        [XmlIgnore]
        public override bool NameSpecified { get { return Name != ""; } }

        [XmlAttribute("Orientation")]
        [DefaultValue(OrientationEnum.Horizontal)]
        public OrientationEnum Orientation { get; set; }
        //[XmlIgnore]
        //public bool OrientationSpecified { get { return Orientation != null; } }

        /// <summary>
        /// The Process attribute defines the Process that is contained within the Pool. 
        /// Each Pool MAY have a Process.
        /// </summary>
        [XmlAttribute("Process")]
        public string Process { get; set; }
        [XmlIgnore]
        public bool ProcessSpecified { get { return Process != ""; } }

        /// <summary>
        /// The Modeler MAY define the Participant for a Pool. The Participant can be either a
        /// Role OR an Entity. This defines the Role that the Pool will play in a Diagram that 
        /// includes Collaboration. Note that the term Participant in the context of Pools is a
        /// BPMN concept that differs From the same term used in XPDL Participant Declaration, 
        /// Participant Assignment AND Performer expressions.
        /// </summary>
        [XmlAttribute("Participant")]
        public string Participant { get; set; }
		[XmlIgnore]
		public bool ParticipantSpecified { get { return Participant != ""; } }

        /// <summary>
        /// This attribute defines if the rectangular boundary for the Pool is visible. 
        /// Only One Pool on a page MAY have the attribute set To False.
        /// </summary>
        [XmlAttribute("BoundaryVisible")]
        [DefaultValue(true)]
        public bool BoundaryVisible { get; set; }
        //[XmlIgnore]
        //public bool BoundaryVisibleSpecified { get { return BoundaryVisible != null; } }

        /// <summary>
        /// This attribute defines if the Pool is the ―main‖ Pool OR the focus of the diagram. 
        /// Only One Pool in the Diagram MAY have the attribute set To True.
        /// </summary>
        [XmlAttribute("MainPool")]
        [DefaultValue(false)]
        public bool IsMainPool { get; set; }
        //[XmlIgnore]
        //public bool IsMainPoolSpecified { get { return IsMainPool != null; } }



        public Pool()
        {
            Orientation = OrientationEnum.Horizontal;
            BoundaryVisible = true;
            IsMainPool = false;
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Pool value = obj as Pool;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.IsMainPool, this.BoundaryVisible, this.Process, this.Participant, this.Orientation,
                    this.Id, this.Name, this.Object
                };

                List<object> listB = new List<object>
                {
                    value.IsMainPool, value.BoundaryVisible, value.Process, value.Participant, value.Orientation,
                    value.Id, value.Name, value.Object
                };

                if (!Utilities.IsListEqual<NodeGraphicsInfo>(this.NodeGraphicalsInfos, value.NodeGraphicalsInfos) ||
                    !Utilities.IsListEqual<Lane>(this.Lanes, value.Lanes))
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