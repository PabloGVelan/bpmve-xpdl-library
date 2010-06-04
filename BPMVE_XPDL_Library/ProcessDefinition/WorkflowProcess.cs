using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.5. Process Definition
    /// The Process Definition defines the elements that make up a process. It contains definitions
    /// OR declarations, respectively, for Activity AND, optionally, for Transition, Application, 
    /// AND Process Relevant Data entities. Attributes may be specified for administration relevant 
    /// Data like author, AND version; for runtime relevant Data like priority; AND for BPR AND 
    /// simulation relevant Data.
    /// BPMN Processes have similar attributes. A BPMN re-usable process is contained in a Pool which
    /// refers To the process via its Process attribute.
    /// A Process may run as an implementation of an activity of type SubFlow; in this case parameters
    /// may be defined as attributes of the process. BPMN uses the term Sub-Process. See details in 
    /// 7.6.5.4.2. Also see Semantics of Reusable Subprocess [BPMN perspective] in section 7.6.5.4.3. 
    /// For details about the Start AND End of sub-processes see 7.6.5.4.5.
    /// Where a process definition includes input parameters AND is instantiated by means Other than a 
    /// SubFlow/subprocess call (for example by local event) the method for initializing any input 
    /// parameters is locally defined. In such circumstances any relevant Data Standard associated with 
    /// the instantiated process definition, which is included within the parameter list will be 
    /// initialized To the value specified in the ―default value‖ (where specified). Where relevant 
    /// Data Standard is not passed as an input parameter, OR initialized by ―default value‖ the result 
    /// is undefined. Similarly where a subflow terminates abnormally without returning out parameter
    /// values To the calling process, the result is undefined.
    /// In general the scope of the defined entity identifier AND name is the surrounding entity. 
    /// The identifier is unique in this scope. For the Process identifier AND name the scope is 
    /// the surrounding Package.
    /// </summary>
    public class WorkflowProcess : IValidate
    {
        /// <summary>
        /// A set of elements specifying process characteristics.
        /// </summary>
        [XmlElement("ProcessHeader")]
        public ProcessHeader ProcessHeader { get; set; }
        [XmlIgnore]
        public bool ProcessHeaderSpecified { get { return ProcessHeader != null; } }

        /// <summary>
        /// A set of elements AND attributes used by Both the Package AND Process definitions.
        /// </summary>
        [XmlElement("RedefinableHeader")]
        public RedefinableHeader RedefinableHeader { get; set; }
        [XmlIgnore]
        public bool RedefinableHeaderSpecified { get { return RedefinableHeader != null; } }

        /// <summary>
        /// A list of parameters that may be passed To the process. See section 7.1.5.
        /// </summary>
        [XmlArray("FormalParameters")]
        public List<FormalParameter> FormalParameters { get; set; }
        [XmlIgnore]
        public bool FormalParametersSpecified { get { return FormalParameters == null ? false : FormalParameters.Count != 0; } }

        /// <summary>
        /// The InputSets attribute defines the Data requirements for input To the Process. 
        /// Zero OR more InputSets MAY be defined. Each Input set is sufficient To allow the 
        /// Process To be performed (if it has first been instantiated by the appropriate Dignal 
        /// arriving From an incoming Sequence Flow). See section 7.6.10.
        /// </summary>
        [XmlArray("InputSets")]
        public List<InputSet> InputSets { get; set; }
        [XmlIgnore]
        public bool InputSetsSpecified { get { return InputSets == null ? false : InputSets.Count != 0; } }

        /// <summary>
        /// The OutputSets attribute defines the Data requirements for output From the Process. 
        /// Zero OR more OutputSets MAY be defined. At the completion of the Process, only One of 
        /// the OutputSets may be produced--It is up To the implementation of the Process To determine
        /// which set will be produced. However, the IORules attribute MAY indicate a relationship 
        /// between an OutputSet AND an InputSet that started the Process. See section 7.6.11.
        /// </summary>
        [XmlArray("OutputSets")]
        public List<OutputSet> OutputSets { get; set; }
        [XmlIgnore]
        public bool OutputSetsSpecified { get { return OutputSets == null ? false : OutputSets.Count != 0; } }

        /// <summary>
        /// A list of resources used in implementing the process. See section 7.11.
        /// </summary>
        [XmlArray("Participants")]
        public List<Participant> Participants { get; set; }
        [XmlIgnore]
        public bool ParticipantsSpecified { get { return Participants == null ? false : Participants.Count != 0; } }

        /// <summary>
        /// A list of Application Declarations. See section 7.3.
        /// </summary>
        [XmlArray("Applications")]
        public List<Application> Applications { get; set; }
        [XmlIgnore]
        public bool ApplicationsSpecified { get { return Applications == null ? false : Applications.Count != 0; } }

        /// <summary>
        /// A list of Relevant Data fields defined for the process. See section 7.12.
        /// </summary>
        [XmlArray("DataFields")]
        public List<DataField> DataFields { get; set; }
        [XmlIgnore]
        public bool DataFieldsSpecified { get { return DataFields == null ? false : DataFields.Count != 0; } }

        /// <summary>
        /// A list of self contained sets of activities AND transitions. Used To represent a BPMN 
        /// embedded subprocess.
        /// </summary>
        [XmlArray("ActivitySets")]
        public List<ActivitySet> ActivitySets { get; set; }
        [XmlIgnore]
        public bool ActivitySetsSpecified { get { return ActivitySets == null ? false : ActivitySets.Count != 0; } }

        /// <summary>
        /// A list of activities that comprise the process. See section 7.6.
        /// </summary>
        [XmlArray("Activities")]
        public List<Activity> Activities { get; set; }
        [XmlIgnore]
        public bool ActivitiesSpecified { get { return Activities == null ? false : Activities.Count != 0; } }

        /// <summary>
        /// A list of the transitions that connect the process activities. See section 7.7.
        /// </summary>
        [XmlArray("Transitions")]
        public List<Transition> Transitions { get; set; }
        [XmlIgnore]
        public bool TransitionsSpecified { get { return Transitions == null ? false : Transitions.Count != 0; } }

        /// <summary>
        /// Optional vendor-defined extensions To meet implementation needs. See section 7.1.1.
        /// </summary>
        [XmlArray("ExtendedAttributes")]
        public List<ExtendedAttribute> ExtendedAttributes { get; set; }
        [XmlIgnore]
        public bool ExtendedAttributesSpecified { get { return ExtendedAttributes == null ? false : ExtendedAttributes.Count != 0; } }

        /// <summary>
        /// A list of Data Standard assignments. See section 7.1.7.
        /// </summary>
        [XmlArray("Assignments")]
        public List<Assignment> Assignments { get; set; }
        [XmlIgnore]
        public bool AssignmentsSpecified { get { return Assignments == null ? false : Assignments.Count != 0; } }

        /// <summary>
        /// Partner links used by this process. See section 7.8.2.
        /// </summary>
        [XmlArray("PartnerLinks")]
        public List<PartnerLink> PartnerLinks { get; set; }
        [XmlIgnore]
        public bool PartnerLinksSpecified { get { return PartnerLinks == null ? false : PartnerLinks.Count != 0; } }

        /// <summary>
        /// See section 7.1.9.4.
        /// </summary>
        [XmlElement("Object")]
        public Object_XPDL Object { get; set; }
        [XmlIgnore]
        public bool ObjectSpecified { get { return Object != null; } }

        /// <summary>
        /// Used To identify the process.
        /// </summary>
        [XmlAttribute("Id")]
        public string Id { get; set; }

        /// <summary>
        /// Text Used To identify the process.
        /// </summary>
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlIgnore]
        public bool NameSpecified { get { return Name != ""; } }

        /// <summary>
        /// The Access level of a process may be either PUBLIC OR PRIVATE. If PUBLIC the process may be 
        /// invoked by an external System OR application. A process with private access may only be 
        /// invoked From a SubFlow/subprocess Activity (see section 7.6.5.3.10). Use is optional AND 
        /// default is PUBLIC.
        /// </summary>
        [XmlAttribute("AccessLevel")]
        [DefaultValue(ProcessAccessLevelEnum.Public)]
        public ProcessAccessLevelEnum AccessLevel { get; set; }
        //[XmlIgnore]
        //public bool AccessLevelSpecified { get { return AccessLevel != null; } }

        /// <summary>
        /// BPMN types: None, Private, Abstract, Collaboration. See section 7.5.5.
        /// </summary>
        [XmlAttribute("ProcessType")]
        [DefaultValue(ProcessTypeEnum.None)]
        public ProcessTypeEnum ProcessType { get; set; }
        //[XmlIgnore]
        //public bool ProcessTypeSpecified { get { return ProcessType != null; } }

        /// <summary>
        /// See section 7.5.6.
        /// </summary>
        [XmlAttribute("Status")]
        [DefaultValue(ProcessStatusEnum.None)]
        public ProcessStatusEnum Status { get; set; }
        //[XmlIgnore]
        //public bool StatusSpecified { get { return Status != null; } }

        /// <summary>
        /// See section 7.5.7.
        /// </summary>
        [XmlAttribute("SuppressJoinFailure")]
        [DefaultValue(false)]
        public bool IsSuppressJoinFailure { get; set; }
        //[XmlIgnore]
        //public bool IsSuppressJoinFailureSpecified { get { return IsSuppressJoinFailure != null; } }

        /// <summary>
        /// See section 7.5.8.
        /// </summary>
        [XmlAttribute("EnableInstanceCompensation")]
        [DefaultValue(false)]
        public bool IsEnableInstanceCompensation { get; set; }
        //[XmlIgnore]
        //public bool IsEnableInstanceCompensationSpecified { get { return IsEnableInstanceCompensation != null; } }

        /// <summary>
        /// See section 7.5.9.
        /// </summary>
        [XmlAttribute("AdHoc")]
        [DefaultValue(false)]
        public bool Adhoc { get; set; }
        //[XmlIgnore]
        //public bool AdhocSpecified { get { return Adhoc != null; } }

        /// <summary>
        /// See section 7.5.9.
        /// </summary>
        [XmlAttribute("AdHocOrdering")]
        [DefaultValue(OrderingEnum.Parallel)]
        public OrderingEnum AdhocOrdering { get; set; }
        //[XmlIgnore]
        //public bool AdhocOrderingSpecified { get { return AdhocOrdering != null; } }

        /// <summary>
        /// See section 7.5.9.
        /// </summary>
        [XmlAttribute("AdHocCompletionCondition")]
        public string AdhocCompletionCondition { get; set; }
		[XmlIgnore]
		public bool AdhocCompletionConditionSpecified { get { return !string.IsNullOrEmpty(AdhocCompletionCondition); } }

        /// <summary>
        /// If present, DefaultStartActivityId must be the id of a Start activity In the Default 
        /// StartActivitySet if that‘s present In the top level process activities Otherwise
        /// </summary>
        [XmlAttribute("DefaultStartActivityId")]
        public string DefaultStartActivityId { get; set; }
		[XmlIgnore]
		public bool DefaultStartActivityIdSpecified { get { return DefaultStartActivityId != ""; } }

        /// <summary>
        /// If present, DefaultStartActivitySetId must be the id of an Activity Set in the process.
        /// </summary>
        [XmlAttribute("DefaultStartActivitySetId")]
        public string DefaultStartActivitySetId { get; set; }
        [XmlIgnore]
        public bool DefaultStartActivitySetIdSpecified { get { return DefaultStartActivitySetId != ""; } }



        public WorkflowProcess()
        {
            AccessLevel = ProcessAccessLevelEnum.Public;
            ProcessType = ProcessTypeEnum.None;
            Status = ProcessStatusEnum.None;
            IsSuppressJoinFailure = false;
            IsEnableInstanceCompensation = false;
            Adhoc = false;
            AdhocOrdering = OrderingEnum.Parallel;
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            WorkflowProcess value = obj as WorkflowProcess;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.AccessLevel, this.AdhocOrdering, this.AdhocCompletionCondition, this.Adhoc, 
					this.DefaultStartActivityId, this.DefaultStartActivitySetId, this.IsEnableInstanceCompensation,
					this.Id, this.Name, this.Object, this.ProcessHeader, this.ProcessType, this.RedefinableHeader,
					this.Status, this.IsEnableInstanceCompensation
                };

                List<object> listB = new List<object>
                {
                    value.AccessLevel, value.AdhocOrdering, value.AdhocCompletionCondition, value.Adhoc, 
					value.DefaultStartActivityId, value.DefaultStartActivitySetId, value.IsEnableInstanceCompensation,
					value.Id, value.Name, value.Object, value.ProcessHeader, value.ProcessType, value.RedefinableHeader,
					value.Status, value.IsEnableInstanceCompensation
                };

                if (!Utilities.IsListEqual<Activity>(this.Activities, value.Activities) ||
				    !Utilities.IsListEqual<ActivitySet>(this.ActivitySets, value.ActivitySets) ||
				    !Utilities.IsListEqual<Application>(this.Applications, value.Applications) ||
				    !Utilities.IsListEqual<Assignment>(this.Assignments, value.Assignments) ||
				    !Utilities.IsListEqual<DataField>(this.DataFields, value.DataFields) ||
				    !Utilities.IsListEqual<ExtendedAttribute>(this.ExtendedAttributes, value.ExtendedAttributes) ||
				    !Utilities.IsListEqual<FormalParameter>(this.FormalParameters, value.FormalParameters) ||
				    !Utilities.IsListEqual<InputSet>(this.InputSets, value.InputSets) ||
				    !Utilities.IsListEqual<OutputSet>(this.OutputSets, value.OutputSets) ||
				    !Utilities.IsListEqual<Participant>(this.Participants, value.Participants) ||
				    !Utilities.IsListEqual<PartnerLink>(this.PartnerLinks, value.PartnerLinks) ||
				    !Utilities.IsListEqual<Transition>(this.Transitions, value.Transitions))
                    return false;

//                for (int j = 0; j < listA.Count; j++)
//                    if (listA[j] != null && listB[j] != null)
//                        if (!listA[j].Equals(listB[j]))
//                            return false;
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