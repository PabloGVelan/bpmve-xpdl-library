using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.1.9 Artifact
    /// BPMN provides modelers with the capability of showing additional information about a 
    /// Process that is not directly related To the Sequence Flow OR Message Flow of the Process.
    /// At this point, BPMN provides three Standard Artifacts: A Data Object, a Group, AND an
    /// Annotation. Additional Standard Artifacts may be added To the BPMN specification in
    /// later versions. A modeler OR modeling tool may extend a BPD AND add new types of Artifacts
    /// To a Diagram. Any new Artifact must follow the Sequence Flow AND Message Flow connection 
    /// rules (listed below). Associations can be used To Link Artifacts To Flow Objects.
    /// An Artifact is a graphical object that provides supporting information about the Process 
    /// OR elements within the Process. However, it does not directly affect the flow of the Process.
    /// Other examples of Artifacts include critical success factors AND milestones.
    /// BPMN provides a specific graphical representation for the different artifacts:
    /// </summary>
    public class Artifact : GraphicalObject, IValidate
    {
        /// <summary>
        /// See section 7.1.9.4.
        /// </summary>
        [XmlElement("Object")]
        public override Object_XPDL Object { get; set; }
        [XmlIgnore]
        public override bool ObjectSpecified { get { return Object != null; } }

        [XmlElement("Group")]
        public Group Group { get; set; }
        [XmlIgnore]
        public bool GroupSpecified { get { return Group != null; } }

        [XmlElement("DataObject")]
        public DataObject DataObject { get; set; }
        [XmlIgnore]
        public bool DataObjectSpecified { get { return DataObject != null; } }

        /// <summary>
        /// See section 7.1.1.
        /// </summary>
        [XmlArray("NodeGraphicsInfos")]
        public List<NodeGraphicsInfo> NodeGraphicsInfos { get; set; }
		[XmlIgnore]
		public bool NodeGraphicsInfosSpecified { get { return NodeGraphicsInfos == null ? false : NodeGraphicsInfos.Count != 0; } }

        /// <summary>
        /// Used To identify the Artifact.
        /// </summary>
        [XmlAttribute("Id")]
        public override string Id { get; set; }

        /// <summary>
        /// Name of the Artifact.
        /// </summary>
        [XmlAttribute("Name")]
        public override string Name { get; set; }
		[XmlIgnore]
		public override bool NameSpecified { get { return Name != ""; } }

        /// <summary>
        /// DataObject | Group | Annotation
        /// </summary>
        [XmlAttribute("ArtifactType")]
        [DefaultValue(ArtifactTypeEnum.Annotation)]
        public ArtifactTypeEnum ArtifactType { get; set; }
        //[XmlIgnore]
        //public bool ArtifactTypeSpecified { get { return ArtifactType != null; } }

        [XmlAttribute("TextAnnotation")]
        public string TextAnnotation { get; set; }
        [XmlIgnore]
        public bool TextAnnotationSpecified { get { return TextAnnotation != ""; } }

        [XmlAttribute("Group")]
        public string GroupName { get; set; }
        [XmlIgnore]
        public bool GroupNameSpecified { get { return GroupName != ""; } }



        public Artifact()
        {
            ArtifactType = ArtifactTypeEnum.Annotation;
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Artifact value = obj as Artifact;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.ArtifactType, this.Id, this.Name, this.Object, 
                    this.TextAnnotation, this.GroupName, this.GroupName, this.DataObject
                };

                List<object> listB = new List<object>
                {
                    value.ArtifactType, value.Id, value.Name, value.Object, 
                    value.TextAnnotation, value.GroupName, value.GroupName, value.DataObject
                };

                if (!Utilities.IsListEqual<NodeGraphicsInfo>(this.NodeGraphicsInfos, value.NodeGraphicsInfos))
                    return false;

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