using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.10. Association
    /// An Association is used To associate information AND Artifacts with Flow Objects. 
    /// Text AND graphical non-Flow Objects can be associated with the Flow Objects AND Flow. 
    /// An Association is also used To show the activities used To Compensate for an activity.
    /// An Association is also used To associate Data Objects with Other objects. A Data Object 
    /// is used To show how documents are used throughout a Process.
    /// Refer To section 7.1.9.5 for more information on Data Objects.
    /// </summary>
    public class Association : ConnectingObject, IValidate
    {
        /// <summary>
        /// See section 7.1.9.4.
        /// </summary>
        [XmlElement("Object")]
        public override Object_XPDL Object { get; set; }
        [XmlIgnore]
        public override bool ObjectSpecified { get { return Object != null; } }

        /// <summary>
        /// See section 7.1.2.4.
        /// </summary>
        [XmlArray("ConnectorGraphicsInfos")]
        public override List<ConnectorGraphicsInfo> ConnectorGraphicsInfos { get; set; }
        [XmlIgnore]
        public override bool ConnectorGraphicsInfosSpecified { get { return ConnectorGraphicsInfos == null ? false : ConnectorGraphicsInfos.Count != 0; } }

        /// <summary>
        /// Used To identify the Association.
        /// </summary>
        [XmlAttribute("Id")]
        public override string Id { get; set; }

        /// <summary>
        /// Determines the source of an Association (any graphical object).
        /// </summary>
        [XmlAttribute("Source")]
        public string Source { get; set; }
        [XmlIgnore]
        public bool SourceSpecified { get { return Source != ""; } }

        /// <summary>
        /// Determines the target of an Association (any graphical object)
        /// </summary>
        [XmlAttribute("Target")]
        public string Target { get; set; }
        [XmlIgnore]
        public bool TargetSpecified { get { return Target != ""; } }

        /// <summary>
        /// Name of the Association.
        /// </summary>
        [XmlAttribute("Name")]
        public override string Name { get; set; }
		[XmlIgnore]
        public override bool NameSpecified { get { return Name != ""; } }

        /// <summary>
        /// None | To | From | Both
        /// </summary>
        [XmlAttribute("AssociationDirection")]
        [DefaultValue(AssociationDirectionEnum.None)]
        public AssociationDirectionEnum AssociationDirection { get; set; }
        //[XmlIgnore]
        //public bool AssociationDirectionSpecified { get { return AssociationDirection != null; } }



        public Association()
        {
            AssociationDirection = AssociationDirectionEnum.None;
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Association value = obj as Association;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.AssociationDirection, this.Source, this.Target, this.Id, this.Name, this.Object
                };

                List<object> listB = new List<object>
                {
                    value.AssociationDirection, value.Source, value.Target, value.Id, value.Name, value.Object
                };

                if (!Utilities.IsListEqual<ConnectorGraphicsInfo>(this.ConnectorGraphicsInfos, value.ConnectorGraphicsInfos))
                    return false;

                return (Utilities.IsEqual(listA, listB));
            }

            return false;
        }

        #region IValidate Members

        public override bool Validate()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}