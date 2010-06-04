using System;
using System.Collections.Generic;
using BPMVE_XPDL_Library;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6. Process Activity
    /// The Activity Definition is used To define each elementary activity that makes up a process. 
    /// Attributes may be defined To specify activity control information, implementation alternatives,
    /// performer assignment, runtime relevant information like priority, AND Data used specifically in 
    /// BPR AND simulation situations (AND not used within enactment). In addition, restrictions on 
    /// Data access AND To transition evaluation (e.g. Split AND Join) can be described. Mandatory 
    /// attributes are used To define the activity identifier AND type; a small number of Other attributes 
    /// are optional but have common usage across All activity types. Other attribute usage depends upon 
    /// the activity type as shown in the table below.
    /// Supertyped: Id, Name, Object
    /// Deprecated (Not Implemented): BlockActivity, Performer, StartMode, FinishMode, Deadline
    /// </summary>
    public class Activity : GraphicalObject, IValidate
    {
        /// <summary>
        /// Textual description of the activity.
        /// </summary>
        [XmlElement("Description")]
        public Description Description { get; set; }
        [XmlIgnore]
        public bool DescriptionSpecified { get { return Description != null; } }

        /// <summary>
        /// Expected duration for time management purposes (e.g. starting an escalation procedure 
        /// etc.) in units of DurationUnit. It is counted From the starting date/time of the Process. 
        /// The consequences of reaching the limit value are not defined in this document (i.e. vendor 
        /// specific). Note that BPMN provides Timer Events which can be attached To the boundary of a 
        /// regular OR subflow/subprocess activity.
        /// </summary>
        [XmlElement("Limit")]
        public Limit Limit { get; set; }
        [XmlIgnore]
        public bool LimitSpecified { get { return Limit != null; } }

        [XmlElement("Route")]
        public Route Route { get; set; }
        [XmlIgnore]
        public bool RouteSpecified { get { return Route != null; } }

        [XmlElement("Implementation")]
        public Implementation Implementation { get; set; }
        [XmlIgnore]
        public bool ImplementationSpecified { get { return Implementation != null; } }

        [XmlElement("BlockActivity")]
        public BlockActivity BlockActivity { get; set; }
        [XmlIgnore]
        public bool BlockActivitySpecified { get { return BlockActivity != null; } }

        [XmlElement("Event")]
        public Event Event { get; set; }
        [XmlIgnore]
        public bool EventSpecified { get { return Event != null; } }

        /// <summary>
        /// If the IsATransaction attribute is False, then a Transaction MUST NOT be identified. 
        /// If the IsATransaction attribute is True, then a Transaction MUST be identified. Note 
        /// that Transactions that are in different Pools AND are connected through Message Flow 
        /// MUST have the same TransactionId. See section 7.6.12.
        /// </summary>
        [XmlElement("Transaction")]
        public Transaction Transaction { get; set; }
        [XmlIgnore]
        public bool TransactionSpecified { get { return Transaction != null; } }

        /// <summary>
        /// List of Links To entity participants. Each Performer may be an expression. 
        /// Default: Any Participant.
        /// </summary>
        [XmlArray("Performers")]
        public List<Performer> Performers { get; set; }
        [XmlIgnore]
        public bool PerformersSpecified { get { return Performers == null ? false : Performers.Count != 0; } }

        /// <summary>
        /// A value that describes the initial priority of this activity when it starts execution.
        /// If this attribute is not defined but a priority is defined in the Process definition 
        /// then that is used. By default it is assumed that the priority levels are the natural 
        /// numbers starting with zero, AND that the higher the value the higher the priority 
        /// (i.e.: 0, 1,..., n).
        /// </summary>
        [XmlElement("Priority")]
        public Priority Priority { get; set; }
        [XmlIgnore]
        public bool PrioritySpecified { get { return Priority != null; } }

        /// <summary>
        /// Specification of a deadline AND action To be taken if it is reached. It is better To
        /// use the BPMN Timer event To provide this functionality.
        /// </summary>
        [XmlElement("Deadline")]
        public Deadline Deadline { get; set; }
        [XmlIgnore]
        public bool DeadlineSpecified { get { return Deadline != null; } }

        /// <summary>
        /// Estimations for simulation of an Activity. No default. See section 7.6.8.
        /// </summary>
        [XmlElement("SimulationInformation")]
        public SimulationInformation SimulationInformation { get; set; }
        [XmlIgnore]
        public bool SimulationInformationSpecified { get { return SimulationInformation != null; } }

        /// <summary>
        /// Alternative graphics for an icon To represent the activity in a graphical modeller. 
        /// May be used To override the modeller icon for an activity. This may be deprecated 
        /// in the future.
        /// </summary>
        [XmlElement("Icon")]
        public Icon Icon { get; set; }
        [XmlIgnore]
        public bool IconSpecified { get { return Icon != null; } }

        /// <summary>
        /// The address (e.g. path- AND filename) for a help file OR a description file of the activity.
        /// </summary>
        [XmlElement("Documentation")]
        public Documentation Documentation { get; set; }
        [XmlIgnore]
        public bool DocumentationSpecified { get { return Documentation != null; } }

        /// <summary>
        /// Provides further restrictions AND context-related semantics description of Transitions.
        /// All activities (including Gateways) with Multiple outgoing transitions (sequence flow)
        /// must have a TransitionRestrictions Split element with a list of references To the 
        /// outgoing transition elements. (See 7.6.9.2).
        /// </summary>
        [XmlArray("TransactionRestriction")]
        public List<TransitionRestriction> TransitionRestrictions { get; set; }
        [XmlIgnore]
        public bool TransitionRestrictionsSpecified { get { return TransitionRestrictions == null ? false : TransitionRestrictions.Count != 0; } }

        /// <summary>
        /// Optional extensions To meet individual implementation needs.
        /// </summary>
        [XmlArray("ExtendedAttributes")]
        public List<ExtendedAttribute> ExtendedAttributes { get; set; }
        [XmlIgnore]
        public bool ExtendedAttributesSpecified { get { return ExtendedAttributes == null ? false : ExtendedAttributes.Count != 0; } }

        /// <summary>
        /// Allows declaration of relevant Data local To the activity. See section 7.12 .
        /// </summary>
        [XmlArray("DataFields")]
        public List<DataField> DataFields { get; set; }
        [XmlIgnore]
        public bool DataFieldsSpecified { get { return DataFields == null ? false : DataFields.Count != 0; } }

        /// <summary>
        /// See section 7.6.10.
        /// </summary>
        [XmlArray("InputSets")]
        public List<InputSet> InputSets { get; set; }
        [XmlIgnore]
        public bool InputSetsSpecified { get { return InputSets == null ? false : InputSets.Count != 0; } }

        /// <summary>
        /// See section 7.6.11.
        /// </summary>
        [XmlArray("OutputSets")]
        public List<OutputSet> OutputSets { get; set; }
        [XmlIgnore]
        public bool OutputSetsSpecified { get { return OutputSets == null ? false : OutputSets.Count != 0; } }

        /// <summary>
        /// The IORules attribute is a collection of expressions, each of which specifies the 
        /// required relationship between One input AND One output. That is, if the activity is 
        /// instantiated with a specified input, that activity shall Complete with the specified output.
        /// </summary>
        [XmlElement("IORules")]
        public IORules IORules { get; set; }
        [XmlIgnore]
        public bool IORulesSpecified { get { return IORules != null; } }

        /// <summary>
        /// See section 7.6.13.
        /// </summary>
        [XmlElement("Loop")]
        public Loop Loop { get; set; }
        [XmlIgnore]
        public bool LoopSpecified { get { return Loop != null; } }

        /// <summary>
        /// A list of Data Standard assignments. See section 7.1.7.
        /// </summary>
        [XmlArray("Assignments")]
        public List<Assignment> Assignments { get; set; }
		[XmlIgnore]
		public bool AssignmentsSpecified { get { return Assignments == null ? false : Assignments.Count != 0; } }

        /// <summary>
        /// See section 7.1.9.4.
        /// </summary>
        [XmlElement("Object")]
        public override Object_XPDL Object { get; set; }
        [XmlIgnore]
        public override bool ObjectSpecified { get { return Object != null; } }

        /// <summary>
        /// Optional. See section 7.1.1.
        /// </summary>
        [XmlArray("NodeGraphicsInfos")]
        public List<NodeGraphicsInfo> NodeGraphicsInfos { get; set; }
        [XmlIgnore]
        public bool NodeGraphicsInfosSpecified { get { return NodeGraphicsInfos == null ? false : NodeGraphicsInfos.Count != 0; } }

        /// <summary>
        /// Used To identify the Activity.
        /// </summary>
        [XmlAttribute("Id")]
        public override string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [XmlAttribute("IsForCompensation")]
        [DefaultValue(false)]
        public bool IsForCompensation { get; set; }
        //[XmlIgnore]
        //public bool IsForCompensationSpecified { get { return IsForCompensation != null; } }

        /// <summary>
        /// Name of the Activity.
        /// </summary>
        [XmlAttribute("Name")]
        public override string Name { get; set; }
        [XmlIgnore]
        public override bool NameSpecified { get { return Name != ""; } }

        /// <summary>
        /// Designates the first activity To be executed when the process is instantiated. Used 
        /// when there is no Other way To determine this. Conflicts with BPMN StartEvent AND no 
        /// process definition should contain Both.
        /// </summary>
        [XmlAttribute("StartActivity")]
        [DefaultValue(false)]
        public bool IsStartActivity { get; set; }
        //[XmlIgnore]
        //public bool IsStartActivitySpecified { get { return IsStartActivity != null; } }

        /// <summary>
        /// Status values are assigned during execution. Status can be treated as a property AND 
        /// used in expressions local To an Activity.
        /// </summary>
        [XmlAttribute("Status")]
        [DefaultValue(ProcessStatusEnum.None)]
        public ProcessStatusEnum Status { get; set; }
        //[XmlIgnore]
        //public bool StatusSpecified { get { return Status != null; } }

        /// <summary>
        /// Describes how the execution of an Activity is triggered.
        /// </summary>
        [XmlAttribute("StartMode")]
        [DefaultValue(StartAndFinishModeEnum.Automatic)]
        public StartAndFinishModeEnum StartMode { get; set; }
        //[XmlIgnore]
        //public bool StartModeSpecified { get { return StartMode != null; } }

        /// <summary>
        /// Describes how the System operates at the End of the Activity.
        /// </summary>
        [XmlAttribute("FinishMode")]
        [DefaultValue(StartAndFinishModeEnum.Automatic)]
        public StartAndFinishModeEnum FinishMode { get; set; }
        //[XmlIgnore]
        //public bool FinishModeSpecified { get { return FinishMode != null; } }

        /// <summary>
        /// The default value is 1. The value MUST NOT be less than 1. This attribute defines the 
        /// number of Tokens that must arrive Before the activity can begin.
        /// </summary>
        [XmlAttribute("StartQuantity")]
        [DefaultValue(1)]
        public int StartQuantity { get; set; }
        //[XmlIgnore]
        //public bool StartQuantitySpecified { get { return StartQuantity != 0; } }

        /// <summary>
        /// The default value is 1. The value MUST NOT be less than 1. This attribute defines the 
        /// number of Tokens that must be generated From the activity. This number of Tokens will
        /// be sent down any outgoing Sequence Flow (assuming any Sequence Flow Conditions are satisfied).
        /// </summary>
        [XmlAttribute("CompletionQuantity")]
        [DefaultValue(1)]
        public int CompletionQuantity { get; set; }
        //[XmlIgnore]
        //public bool CompletionQuantitySpecified { get { return CompletionQuantity != 0; } }        


        /// <summary>
        /// If the activity is a block activity OR is implemented as a subflow IsATransaction 
        /// determines whether OR not the behavior of the Sub-Process will be treated as a Transaction.
        /// </summary>
        [XmlAttribute("IsATransaction")]
        [DefaultValue(false)]
        public bool IsATransaction { get; set; }
        //[XmlIgnore]
        //public bool IsATransactionSpecified { get { return IsATransaction != null; } }



        public Activity()
        {
            IsForCompensation = false;
            IsStartActivity = false;
            Status = ProcessStatusEnum.None;
            StartMode = StartAndFinishModeEnum.Automatic;
            FinishMode = StartAndFinishModeEnum.Automatic;
            StartQuantity = 1;
            CompletionQuantity = 1;
            IsATransaction = false;
        }
		
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Activity value = obj as Activity;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.CompletionQuantity, this.Deadline, this.Description, this.Documentation, 
                    this.FinishMode, this.Icon, this.IORules, this.IsATransaction, this.Limit,
					this.Loop, this.Priority, this.SimulationInformation, this.IsStartActivity, 
					this.StartMode, this.StartQuantity, this.StartMode, this.Transaction,
					this.IsForCompensation, this.Id, this.Name, this.Object, this.BlockActivity,
					this.Route, this.Event, this.Implementation
					
                };

                List<object> listB = new List<object>
                {
                    value.CompletionQuantity, value.Deadline, value.Description, value.Documentation, 
                    value.FinishMode, value.Icon, value.IORules, value.IsATransaction, value.Limit,
					value.Loop, value.Priority, value.SimulationInformation, value.IsStartActivity, 
					value.StartMode, value.StartQuantity, value.StartMode, value.Transaction,
					value.IsForCompensation, value.Id, value.Name, value.Object, value.BlockActivity,
					value.Route, value.Event, value.Implementation
                };

                if (!Utilities.IsListEqual<Assignment>(this.Assignments, value.Assignments) ||
				    !Utilities.IsListEqual<DataField>(this.DataFields, value.DataFields) ||
				    !Utilities.IsListEqual<ExtendedAttribute>(this.ExtendedAttributes, value.ExtendedAttributes) ||
				    !Utilities.IsListEqual<InputSet>(this.InputSets, value.InputSets) ||
				    !Utilities.IsListEqual<NodeGraphicsInfo>(this.NodeGraphicsInfos, value.NodeGraphicsInfos) ||
				    !Utilities.IsListEqual<OutputSet>(this.OutputSets, value.OutputSets) ||
				    !Utilities.IsListEqual<Performer>(this.Performers, value.Performers) ||
				    !Utilities.IsListEqual<TransitionRestriction>(this.TransitionRestrictions, value.TransitionRestrictions))
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