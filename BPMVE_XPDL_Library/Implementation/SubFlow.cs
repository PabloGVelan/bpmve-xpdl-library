using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.5.4. SubFlow/Sub-Process
    /// The Activity is refined as a subflow. The subflow may be executed synchronously OR asynchronously. 
    /// The subflow identifiers used are inherited From the surrounding Package declaration.
    /// SubFlow calls are transactional if the parent Activity has been defined that way. See Table 35.
    /// In the case of asynchronous execution the execution of the Activity is continued After a process 
    /// instance of the referenced Process Definition is initiated (in this case execution proceeds To any 
    /// post activity split logic After subflow initiation. No return parameters are supported From such 
    /// called processes. Synchronization with the initiated subflow, if required, has To be done by Other 
    /// means such as events, not described in this document. This style of subflow is characterized as 
    /// chained (OR forked) subflow operation.
    /// In the case of synchronous execution the execution of the Activity is suspended After a process 
    /// instance of the referenced Process Definition is initiated. After execution termination of this 
    /// process instance the Activity is resumed. Return parameters may be used between the called AND 
    /// calling processes on completion of the subflow. This style of subflow is characterized as hierarchic 
    /// subflow operation.
    /// </summary>
    public class SubFlow : IValidate
    {
        [XmlArray("ActualParameters")]
        public List<ActualParameter> ActualParameters { get; set; }
		[XmlIgnore]
		public bool ActualParametersSpecified { get { return ActualParameters == null ? false : ActualParameters.Count != 0; } }

        [XmlArray("DataMappings")]
        public List<DataMapping> DataMappings { get; set; }
		[XmlIgnore]
		public bool DataMappingsSpecified { get { return DataMappings == null ? false : DataMappings.Count != 0; } }

        [XmlElement("EndPoint")]
        public EndPoint EndPoint { get; set; }
        [XmlIgnore]
        public bool EndPointSpecified { get { return EndPoint != null; } }

        [XmlAttribute("Id")]
        public string Id { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlIgnore]
        public bool NameSpecified { get { return Name != ""; } }

        [XmlAttribute("Execution")]
        [DefaultValue(ExecutionSyncMode.Synchronous)]
        public ExecutionSyncMode Execution { get; set; }
        //[XmlIgnore]
        //public bool ExecutionSpecified { get { return Execution != null; } }

        [XmlAttribute("View")]
        [DefaultValue(ViewEnum.Collapsed)]
        public ViewEnum View { get; set; }
        //[XmlIgnore]
        //public bool ViewSpecified { get { return View != null; } }

        [XmlAttribute("PackageRef")]
        public string PackageRef { get; set; }
		[XmlIgnore]
		public bool PackageRefSpecified { get { return PackageRef != ""; } }

        [XmlAttribute("InstanceDataField")]
        public string InstanceDataField { get; set; }
        [XmlIgnore]
        public bool InstanceDataFieldSpecified { get { return InstanceDataField != ""; } }

        [XmlAttribute("StartActivityId")]
        public string StartActivityId { get; set; }
        [XmlIgnore]
        public bool StartActivityIdSpecified { get { return StartActivityId != ""; } }

        [XmlAttribute("StartActivitySetId")]
        public string StartActivitySetId { get; set; }
        [XmlIgnore]
        public bool StartActivitySetIdSpecified { get { return StartActivitySetId != ""; } }

        //[XmlArray("ExtendedAttributes")]
        //public List<ExtendedAttribute> ExtendedAttributes { get; set; }
        //[XmlIgnore]
        //public bool ExtendedAttributesSpecified { get { return ExtendedAttributes == null ? false : ExtendedAttributes.Count != 0; } }



        public SubFlow()
        {
            Execution = ExecutionSyncMode.Synchronous;
            View = ViewEnum.Collapsed;
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            SubFlow value = obj as SubFlow;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.PackageRef, this.EndPoint, this.Execution, this.Id, this.Name, this.StartActivityId,
					this.StartActivitySetId, this.View
                };

                List<object> listB = new List<object>
                {
                    value.PackageRef, value.EndPoint, value.Execution, value.Id, value.Name, value.StartActivityId,
					value.StartActivitySetId, value.View
                };

                if (!Utilities.IsListEqual<ActualParameter>(this.ActualParameters, value.ActualParameters) ||
				    !Utilities.IsListEqual<DataMapping>(this.DataMappings, value.DataMappings))// ||
				    //!Utilities.IsListEqual<ExtendedAttribute>(this.ExtendedAttributes, value.ExtendedAttributes))
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