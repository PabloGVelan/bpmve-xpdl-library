using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;
using System.IO;
using System.Xml.Schema;
using System.Xml;
using BPMVE_XPDL_Library;
using NUnit.Framework;

namespace BPMVE_XPDL_Library_UnitTest
{
    public static class StaticProperties
    {
        public static ExtendedAttribute ExtendedAttribute = new ExtendedAttribute
        {
            Name = "Name",
            Value = "Value"
        };

        public static ArtifactInput ArtifactInput = new ArtifactInput
        {
            ArtifactId = "ArtifactId"
        };

        public static Assignment Assignment = new Assignment
        {
            Target = new Expression { ScriptVersion = "2.1" },
            Expression = new Expression { ScriptType = "UnknownType" },
            AssignTime = AssignmentTimeEnum.Start
        };

        public static Author Author = new Author { Value = "Author" };

        public static Category Category = new Category { Id = "Id", Name = "Name" };

        public static Codepage Codepage = new Codepage { Value = "Value" };

        public static Color Color = new Color 
        {
            Alpha = 1.0,
            Blue = 2.0,
            Green = 3.0,
            Red = 4.0
        };

        public static Condition Condition = new Condition 
        {
            Expression = new Expression
            {
                ScriptGrammer = "ScriptGrammar",
                ScriptType = "ScriptType",
                ScriptVersion = "ScriptVersion"
            },
            Type = ConditionTypeEnum.Condition
        };

        public static Coordinates Coordinates = new Coordinates { X = "1.0", Y = "2.0" };

        public static Cost Cost = new Cost { Value = "Value" };

        public static Countrykey CountryKey = new Countrykey { Value = "Value" };

        public static Expression ExpressionType = new Expression 
        {
            ScriptGrammer = "ScriptGrammar",
            ScriptType = "ScriptType",
            ScriptVersion = "ScriptVersion"
        };

        public static Description Description = new Description { Value = "Value" };

        public static DataField DataField = new DataField 
        {
            DataType = null,
            IsCorrelation = false,
            Description = Description,
            ExtendedAttributes = new List<ExtendedAttribute> 
            {
                ExtendedAttribute, ExtendedAttribute 
            },
            Id = "Id",
            InitialValue = ExpressionType,
            IsArray = false,
            IsReadOnly = false,
            Length = "Length",
            Name = "Name"
        };

        public static Documentation Documentation = new Documentation { Value = "Value" };

        public static Date Date = new Date { Value = "Value" };

        public static DataMapping DataMapping = new DataMapping
        {
            Actual = ExpressionType,
            Direction = DirectionEnum.InOut,
            Formal = "Formal",
            TestValue = ExpressionType
        };

        public static Message MessageType = new Message
        {
            ActualParameters = new List<ActualParameter>(),
            DataMappings = new List<DataMapping> { DataMapping, DataMapping },
            FaultName = "FaultName",
            From = "From",
            Id = "Id",
            Name = "Name",
            To = "To"
        };

        public static Duration Duration = new Duration { Value = "Value" };

        public static EndPoint EndPoint = new EndPoint
        {
            EndPointType = EndPointTypeEnum.Service,
            ExternalReference = new ExternalReference
            {
                Location = "Location",
                Namespace_XPDL = "Namespace_XPDL",
                Xref = "Xref"
            }
        };

        public static ExternalReference ExternalReference = new ExternalReference
        {
            Location = "Location",
            Namespace_XPDL = "Namespace_XPDL",
            Xref = "Xref"
        };

        public static FormalParameter FormalParameter = new FormalParameter
        {
            DataType = null,
            Description = Description,
            Id = "Id",
            InitialValue = ExpressionType,
            IsArray = false,
            IsReadOnly = false,
            IsRequired = false,
            Length = "Length",
            Mode = FormalParameterMode.In,
            Name = "Name"
        };

        public static Input Input = new Input { ArtifactId = "ArtifactId" };

        public static InputSet InputSet = new InputSet 
        {
            ArtifactInputs = new List<ArtifactInput> { ArtifactInput, ArtifactInput },
            Inputs = new List<Input> { Input, Input },
            PropertyInputs = new List<PropertyInput>
            {
                new PropertyInput { PropertyId = "PropertyId" } 
            }
        };

        public static Limit Limit = new Limit { Value = "Value" };

        public static Output Output = new Output { ArtifactId = "Value" };

        public static OutputSet OutputSet = new OutputSet 
        {
            Outputs = new List<Output> { Output, Output }
        };

        public static Page Page = new Page
        {
            Id = "Id",
            Name = "Name",
            Height = 1.0,
            Width = 2.0
        };

        public static ParticipantType ParticipantType = new ParticipantType 
        {
            Type = ParticipantTypeEnum.Human
        };

        public static Participant Participant = new Participant 
        {
            Description = Description,
            ExtendedAttributes = new List<ExtendedAttribute> { ExtendedAttribute },
            ExternalReference = ExternalReference,
            Id = "Id",
            Name = "Name",
            ParticipantType = ParticipantType
        };

        public static Partner Partner = new Partner
        {
            PartnerLinkId = "PartnerLinkId",
            RoleType = RoleTypeEnum.MyRole
        };

        public static Role Role = new Role { Name = "Name", PortType = "PortType" };

        public static PartnerRole PartnerRole = new PartnerRole
        {
            EndPoint = EndPoint,
            PortName = "PortName",
            RoleName = "RoleName",
            ServiceName = "ServiceName"
        };

        public static PartnerLink PartnerLink = new PartnerLink 
        {
            Id = "Id",
            Name = "Name",
            PartnerLinkTypeId = "PartnerLinkId",
            MyRole = new MyRole { RoleName = "RoleName" },
            PartnerRole = PartnerRole
        };

        public static PartnerLinkType PartnerLinkType = new PartnerLinkType 
        {
            Id = "Id",
            Name = "Name",
            Roles = new List<Role> { Role, Role }
        };

        public static Performer Performer = new Performer { Value = "Value" };

        public static Priority Priority = new Priority { Value = "Value" };

        public static Responsible Responsible = new Responsible { Value = "Value" };

        public static RedefinableHeader RedefinableHeader = new RedefinableHeader
        {
            Author = Author,
            Codepage = Codepage,
            CountryKey = CountryKey,
            PublicationStatus = PublicationStatusEnum.UnderRevision,
            Responsibles = new List<Responsible> { Responsible },
            Version = null
        };

        public static PropertyInput PropertyInput = new PropertyInput 
        {
            PropertyId = "PropertyId"
        };

        public static Script Script = new Script 
        {
            Grammar = "Grammar",
            Type = "Type",
            Version = "Version"
        };

        public static Service Service = new Service 
        {
            EndPoint = EndPoint,
            PortName = "PortName",
            ServiceName = "ServiceName"
        };

        public static Time Time = new Time { Value = "Time" };

        public static TimeEstimation TimeEstimation = new TimeEstimation
        {
            Duration = Duration,
            WaitingTime = Time,
            WorkingTime = Time
        };

        public static TransitionRef TransitionRef = new TransitionRef
        {
            Id = "Id",
            Name = "Name"
        };

        public static Unit Unit = new Unit { Value = "Value" };

        public static ValidTo ValidTo = new ValidTo { Value = "Value" };

        public static ValidFrom ValidFrom = new ValidFrom { Value = "Value" };

        public static Vendor Vendor = new Vendor { Value = "Value" };

        public static BPMVE_XPDL_Library.Version_XPDL Version = new BPMVE_XPDL_Library.Version_XPDL
        {
            Value = "Value"
        };

        public static WebServiceFaultCatch WebServiceFaultCatch = new WebServiceFaultCatch
        {
            BlockActivity = BlockActivity,
            FaultName = "FaultName",
            Message = MessageType,
            TransitionRef = TransitionRef
        };

        public static WebServiceOperation WebServiceOperation = new WebServiceOperation 
        {
            OperationName = "OperationName",
            Partner = Partner,
            Service = Service
        };

        public static Lane Lane = new Lane
        {
            Id = "Id",
            Name = "Name",
            Performers = new List<Performer> { new Performer { Value = "Value" } },
            Object = new Object_XPDL(),
            NestedLanes = new List<Lane> { new Lane { Id = "NestedId", Name = "NestedName" } }
        };

        public static Pool Pool = new Pool 
        {
            Id = "Id",
            BoundaryVisible = true,
            IsMainPool = true,
            Lanes = new List<Lane> { Lane, Lane },
            Name = "Name",
            Orientation = OrientationEnum.Horizontal,
            Participant = "Participant",
            Process = "Process"
        };

        public static TaskApplication TaskApplication = new TaskApplication 
        {
            ActualParameters = new List<ActualParameter>(),
            DataMappings = new List<DataMapping> { DataMapping, DataMapping, DataMapping },
            Description = Description,
            Id = "Id",
            Name = "Name",
            PackageRef = "PackageRef"
        };

        public static TaskManual TaskManual = new TaskManual 
        {
            Performers = new List<Performer> { Performer, Performer, Performer }
        };

        public static TaskReceive TaskReceive = new TaskReceive
        {
            Implementation = ImplementationEnum.WebService,
            IsInstantiate = true,
            Message = MessageType,
            WebserviceOperation = WebServiceOperation
        };

        public static TaskReference TaskReference = new TaskReference { TaskRef = "TaskRef" };

        public static TaskScript TaskScript = new TaskScript { Script = ExpressionType };

        public static TaskSend TaskSend = new TaskSend
        {
            Implementation = ImplementationEnum.Unspecified,
            Message = MessageType,
            WebserviceFaultCatch = new List<WebServiceFaultCatch>
            {
                WebServiceFaultCatch, WebServiceFaultCatch 
            },
            WebServiceOperation = WebServiceOperation
        };

        public static TaskService TaskService = new TaskService 
        { 
            Implementation = ImplementationEnum.Unspecified, 
            MessageIn = MessageType,
            MessageOut = MessageType, 
            WebserviceFaultCatch = new List<WebServiceFaultCatch> 
            {
                WebServiceFaultCatch, WebServiceFaultCatch 
            },
            WebServiceOperation = WebServiceOperation
        };

        public static TaskUser TaskUser = new TaskUser
        {
            Implementation = ImplementationEnum.Unspecified, 
            MessageIn = MessageType,
            MessageOut = MessageType,
            Performers = new List<Performer> { Performer, Performer, Performer },
            WebServiceOperation = WebServiceOperation
        };

        public static Task Task = new Task 
        {
            TaskApplication = TaskApplication,
            TaskManual = TaskManual, 
            TaskReceive = TaskReceive,
            TaskReference = TaskReference, 
            TaskScript = TaskScript, 
            TaskSend = TaskSend, 
            TaskService = TaskService, 
            TaskUser = TaskUser 
        };

        public static NoImplementation NoImplementation = new NoImplementation();

        public static Reference Reference = new Reference { ActivityId = "ActivityId" };

        public static SubFlow SubFlow = new SubFlow
        {
            ActualParameters = new List<ActualParameter>(),
            DataMappings = new List<DataMapping> { DataMapping, DataMapping, DataMapping },
            EndPoint = EndPoint,
            Execution = ExecutionSyncMode.Asynchronous,
            //ExtendedAttributes = new List<ExtendedAttribute>
            //{
            //    ExtendedAttribute, ExtendedAttribute, ExtendedAttribute 
            //},
            Id = "Id",
            InstanceDataField = "InstanceDataField",
            Name = "Name",
            PackageRef = "PackageRef",
            StartActivityId = "StartActivityId",
            StartActivitySetId = "StartActivitySetId",
            View = ViewEnum.Collapsed
        };

        public static Implementation Implementation = new Implementation
        {
            Task = Task, 
            NoImplementation = NoImplementation,
            Reference = Reference, 
            SubFlow = SubFlow 
        };

        public static ConnectorGraphicsInfo ConnectorGraphicsInfo = new ConnectorGraphicsInfo
        {
            BorderColor = "0,0,0", Coordinates = new List<Coordinates> 
            {
                Coordinates, Coordinates, Coordinates 
            }, 
            FillColor = "1,1,1", 
            IsVisible = true, 
            PageId = "PageId",
            //Shape = "Shape", 
            Style = "Style",
            ToolId = "ToolId" 
        };

        public static NodeGraphicsInfo NodeGraphicsInfo = new NodeGraphicsInfo
        {
            BorderColor = "0,0,0",
            Coordinates = new List<Coordinates> { Coordinates, Coordinates, Coordinates },
            FillColor = "1,1,1",
            Height = 2.0,
            IsVisible = true,
            LaneId = "LandId",
            OpensimColor = "3,3,3",
            OpensimLocation = "OpenSimLocation",
            PageId = "PageId",
            Shape = "Shape",
            ToolId = "ToolId",
            Width = 4.0
        };

        public static ResourceCost ResourceCost = new ResourceCost 
        {
            CostUnitOfTime = CostUnitOfTimeEnum.Hour, 
            ResourceCostName = "ResourceCostName", 
            ResourceCosts = 1.0m
        };

        public static CostStructure CostStructure = new CostStructure 
        {
            ResourceCost = new List<ResourceCost> { ResourceCost, ResourceCost },
            FixedCost = 1 
        };

        public static Deadline Deadline = new Deadline
        {
            DeadlineDuration = ExpressionType,
            ExceptionName = "ExceptionName",
            Execution = ExecutionSyncMode.Asynchronous 
        };

        public static Icon Icon = new Icon 
        {
            XCoord = 1, 
            YCoord = 2, 
            Height = 3, 
            Width = 4,
            Shape = IconShapeEnum.Diamond 
        };

        public static IORules IORules = new IORules
        {
            Expressions = new List<Expression> { ExpressionType, ExpressionType, ExpressionType } 
        };

        public static SimulationInformation SimulationInformation = new SimulationInformation
        { 
            Cost = Cost, 
            Instantiation = InstantiationEnum.Multiple,
            TimeEstimation = TimeEstimation 
        };

        public static Transaction Transaction = new Transaction 
        {
            TransactionId = "TransactionId",
            TransactionMethod = TransactionMethodEnum.Compensate, 
            TransactionProtocol = "TransactionProtocol" 
        };

        public static ResultError ResultError = new ResultError { ErrorCode = "ErrorCode" };

        public static TriggerConditional TriggerCond = new TriggerConditional
        {
            ConditionName = "ConditionName", 
            Expression = ExpressionType 
        };

        public static TriggerResultCancel TriggerResultCancel = new TriggerResultCancel { };

        public static TriggerResultCompensation TriggerResultCompensation = new TriggerResultCompensation 
        { 
            ActivityId = "ActivityId"
        };

        public static TriggerResultLink TriggerResultLink = new TriggerResultLink 
        { 
            CatchThrow = CatchThrowEnum.Catch, 
            Name = "Name" 
        };

        public static TriggerResultMessage TriggerResultMessage = new TriggerResultMessage
        {
            CatchThrow = CatchThrowEnum.Throw, 
            Message = MessageType,
            WebServiceOperation = WebServiceOperation
        };

        public static TriggerResultSignal TriggerResultSignal = new TriggerResultSignal
        {
            CatchThrow = CatchThrowEnum.Catch,
            Name = "Name", 
            Properties = new List<Expression> { ExpressionType, ExpressionType }
        };

        public static TriggerRule TriggerRule = new TriggerRule
        { 
            RuleName = "RuleName"
        };

        public static TriggerTimer TriggerTimer = new TriggerTimer
        { 
            TimeCycle = ExpressionType,
            TimeDate = ExpressionType 
        };

        public static ResultMultiple ResultMultiple = new ResultMultiple 
        {
            ResultError = ResultError, 
            TriggerResultCompensation = TriggerResultCompensation, 
            TriggerResultLink = TriggerResultLink, 
            TriggerResultMessage = TriggerResultMessage
        };

        public static TriggerIntermediateMultiple TriggerIntermediateMultiple = new TriggerIntermediateMultiple 
        {
            ResultError = ResultError,
            TriggerConditional = TriggerCond,
            TriggerResultCompensation = TriggerResultCompensation, 
            TriggerResultLink = TriggerResultLink,
            TriggerResultMessage = TriggerResultMessage,
            TriggerTimer = TriggerTimer
        };

        public static TriggerMultiple TriggerMultiple = new TriggerMultiple 
        {
            TriggerConditional = TriggerCond, 
            TriggerResultLink = TriggerResultLink, 
            TriggerResultMessage = TriggerResultMessage, 
            TriggerTimer = TriggerTimer 
        };

        public static StartEvent StartEvent = new StartEvent 
        { 
            Implementation = ImplementationEnum.WebService, 
            Trigger = StartEventTriggerEnum.Conditional,
            TriggerConditional = TriggerCond, 
            TriggerMultiple = TriggerMultiple,
            TriggerResultMessage = TriggerResultMessage, 
            TriggerResultSignal = TriggerResultSignal,
            TriggerTimer = TriggerTimer 
        };

        public static IntermediateEvent IntermediateEvent = new IntermediateEvent
        {
            Implementation = ImplementationEnum.Other,
            ResultError = ResultError,
            Target = "Target",
            Trigger = IntermediateEventTriggerEnum.Compensation,
            TriggerCancel = TriggerResultCancel,
            TriggerConditional = TriggerCond,
            TriggerIntermediateMultiple = TriggerIntermediateMultiple,
            TriggerResultCompensation = TriggerResultCompensation,
            TriggerResultLink = TriggerResultLink,
            TriggerResultMessage = TriggerResultMessage,
            TriggerResultSignal = TriggerResultSignal,
            TriggerTimer = TriggerTimer
        };

        public static EndEvent EndEvent = new EndEvent
        {
            Implementation = ImplementationEnum.Unspecified,
            Result = EndEventTriggerEnum.Cancel,
            ResultError = ResultError,
            ResultMultiple = ResultMultiple,
            TriggerResultCompensation = TriggerResultCompensation,
            TriggerResultMessage = TriggerResultMessage,
            TriggerResultSignal = TriggerResultSignal
        };

        public static Event Event = new Event
        {
            EndEvent = EndEvent,
            StartEvent = StartEvent,
            IntermediateEvent = IntermediateEvent
        };

        public static Association Association = new Association
        {
            AssociationDirection = AssociationDirectionEnum.From,
            ConnectorGraphicsInfos = new List<ConnectorGraphicsInfo> 
            { 
                ConnectorGraphicsInfo, ConnectorGraphicsInfo 
            },
            Id = "Id",
            Name = "Name",
            Source = "Source",
            Target = "Target"
        };

        public static Transition Transition = new Transition
        {
            Assignments = new List<Assignment> { Assignment, Assignment },
            Condition = Condition,
            ConnectorGraphicsInfos = new List<ConnectorGraphicsInfo> 
            { 
                ConnectorGraphicsInfo, ConnectorGraphicsInfo 
            },
            Description = Description,
            ExtendedAttributes = new List<ExtendedAttribute> { ExtendedAttribute, ExtendedAttribute },
            Id = "Id",
            Name = "Name",
            Quantity = 4,
            From = "From",
            To = "To"
        };

        public static MessageFlow MessageFlow = new MessageFlow
        {
            ConnectorGraphicsInfos = new List<ConnectorGraphicsInfo> 
            {
                ConnectorGraphicsInfo, ConnectorGraphicsInfo 
            },
            Id = "Id",
            Message = MessageType,
            Name = "Name",
            Source = "Source",
            Target = "Target"
        };

        public static Group Group = new Group
        {
            Category = new Category { Id = "Id", Name = "Name" },
            Id = "Id",
            Name = "Name",
            Objects = new List<Object_XPDL>()
        };

        public static DataObject DataObject = new DataObject
        {
            DataFields = new List<DataField> { DataField },
            Id = "Id",
            IsProducedAtCompletion = true,
            IsRequiredForStart = true,
            Name = "Name",
            State = "State"
        };

        public static Artifact Artifact = new Artifact
        {
            ArtifactType = ArtifactTypeEnum.DataObject,
            DataObject = DataObject,
            Group = Group,
            GroupName = "GroupName",
            Id = "Id",
            Name = "Name",
            NodeGraphicsInfos = new List<NodeGraphicsInfo> { NodeGraphicsInfo },
            TextAnnotation = "TextAnnotation"
        };

        public static LoopStandard LoopStandard = new LoopStandard
        {
            LoopCondition = ExpressionType,
            LoopCounter = 1,
            LoopMaximum = 2,
            TestTime = TestTimeEnum.After
        };

        public static LoopMultiInstance LoopMultiInstance = new LoopMultiInstance
        {
            ComplexMI_FlowCondition = ExpressionType,
            LoopCounter = 1,
            MI_Condition = ExpressionType,
            MI_FlowCondition = MI_FlowConditionEnum.One,
            MI_Ordering = OrderingEnum.Sequential
        };

        public static Loop Loop = new Loop
        {
            LoopType = LoopTypeEnum.MultiInstance,
            LoopStandard = LoopStandard,
            LoopMultiInstance = LoopMultiInstance
        };

        public static Split Split = new Split
        {
            ExclusiveType = ExclusiveTypeEnum.Data,
            OutgoingCondition = "OutgoingCondition",
            TransitionRefs = new List<TransitionRef> { TransitionRef, TransitionRef },
            Type = GatewayTypeEnum.Complex
        };

        public static Join Join = new Join
        {
            ExclusiveType = ExclusiveTypeEnum.Data,
            IncomingCondition = "IncomingCondition",
            Type = GatewayTypeEnum.Exclusive
        };

        public static TransitionRestriction TransitionRestriction = new TransitionRestriction
        {
            Join = Join,
            Split = Split
        };

        public static BlockActivity BlockActivity = new BlockActivity
        {
            ActivitySetId = "ActivitySetId",
            StartActivityId = "StartActivityId",
            View = ViewEnum.Collapsed
        };

        public static Route Route = new Route
        {
            ExclusiveType = ExclusiveTypeEnum.Event,
            GatewayType = GatewayTypeEnum.AND,
            IncomingCondiiton = "IncomingCondition",
            IsInstantiate = true,
            IsMarkerVisible = true,
            OutgoingCondition = "OutgoingCondition"
        };

        public static Activity Activity = new Activity
        {
            Assignments = new List<Assignment> { Assignment, Assignment },
            CompletionQuantity = 1,
            DataFields = new List<DataField> { DataField, DataField },
            Deadline = Deadline,
            Description = Description,
            Documentation = Documentation,
            ExtendedAttributes = new List<ExtendedAttribute>
            {
                ExtendedAttribute, ExtendedAttribute 
            },
            FinishMode = StartAndFinishModeEnum.Automatic,
            Icon = Icon,
            Id = "Id",
            InputSets = new List<InputSet> { InputSet, InputSet },
            IORules = IORules,
            IsATransaction = true,
            IsForCompensation = true,
            IsStartActivity = true,
            Limit = Limit,
            Loop = Loop,
            Name = "Name",
            NodeGraphicsInfos = new List<NodeGraphicsInfo> { NodeGraphicsInfo, NodeGraphicsInfo },
            OutputSets = new List<OutputSet> { OutputSet, OutputSet },
            Performers = new List<Performer> { Performer, Performer },
            Priority = Priority,
            SimulationInformation = SimulationInformation,
            StartMode = StartAndFinishModeEnum.Manual,
            StartQuantity = 2,
            Status = ProcessStatusEnum.Aborted,
            Transaction = Transaction,
            TransitionRestrictions = new List<TransitionRestriction> 
            {
                TransitionRestriction, TransitionRestriction 
            }
        };

        public static ApplicationType_EJB ApplicationType_EJB = new ApplicationType_EJB
        {
            HomeClass = "HomeClass",
            JndiName = "JndiName",
            Method = "Method"
        };

        public static ApplicationType_POJO ApplicationType_POJO = new ApplicationType_POJO
        {
            Class = "Class",
            Method = "Method"
        };

        public static ApplicationType_Form ApplicationType_Form = new ApplicationType_Form
        {
            FormLayout = "FormLayout"
        };

        public static ApplicationType_WebService ApplicationType_WebService = new ApplicationType_WebService
        {
            InputMsgName = "InputMsgName",
            OutputMsgName = "OutputMsgName",
            WebserviceFaultCatch = WebServiceFaultCatch,
            WebServiceOperation = WebServiceOperation
        };

        public static ApplicationType_BusinessRule ApplicationType_BusinessRule = new ApplicationType_BusinessRule
        {
            Location = "Location",
            RuleName = "RuleName"
        };

        public static ApplicationType_Script ApplicationType_Script = new ApplicationType_Script
        {
            Expression = ExpressionType
        };

        public static ApplicationType_XSLT ApplicationType_XSLT = new ApplicationType_XSLT
        {
            Location = "Location"
        };

        public static ApplicationType ApplicationType = new ApplicationType
        {
            BusinessRule = ApplicationType_BusinessRule,
            EJB = ApplicationType_EJB,
            POJO = ApplicationType_POJO,
            Form = ApplicationType_Form,
            Script = ApplicationType_Script,
            WebService = ApplicationType_WebService,
            XSLT = ApplicationType_XSLT
        };

        public static Application Application = new Application
        {
            Description = Description,
            ExtendedAttributes = new List<ExtendedAttribute> { ExtendedAttribute, ExtendedAttribute },
            ExternalReference = ExternalReference,
            FormalParameters = new List<FormalParameter> { FormalParameter, FormalParameter },
            Id = "Id",
            Name = "Name",
            Type = ApplicationType
        };

        public static ActivitySet ActivitySet = new ActivitySet
        {
            Activities = new List<Activity> { Activity, Activity },
            Adhoc = true,
            AdhocCompletionCondition = "AdhocCompletionCondition",
            AdhocOrdering = OrderingEnum.Parallel,
            DefaultStartActivityId = "DefaultStartActivityId",
            Id = "Id",
            Name = "Name",
            Transitions = new List<Transition> { Transition, Transition }
        };

        public static ProcessHeader ProcessHeader = new ProcessHeader
        {
            Created = Date,
            Description = Description,
            DurationUnit = DurationUnitEnum.Day,
            Limit = Limit,
            Priority = Priority,
            TimeEstimation = TimeEstimation,
            ValidFrom = ValidFrom,
            ValidTo = ValidTo
        };

        public static WorkflowProcess WorkflowProcess = new WorkflowProcess
        {
            AccessLevel = ProcessAccessLevelEnum.Private,
            Activities = new List<Activity> { Activity, Activity },
            ActivitySets = new List<ActivitySet> { ActivitySet, ActivitySet },
            Adhoc = true,
            AdhocCompletionCondition = "AdhocCompletionCondition",
            AdhocOrdering = OrderingEnum.Parallel,
            Applications = new List<Application> { Application, Application },
            Assignments = new List<Assignment> { Assignment, Assignment },
            DataFields = new List<DataField> { DataField, DataField },
            DefaultStartActivityId = "DefaultStartActivityId",
            DefaultStartActivitySetId = "DefaultStartActivitySetId",
            ExtendedAttributes = new List<ExtendedAttribute> { ExtendedAttribute, ExtendedAttribute },
            FormalParameters = new List<FormalParameter> { FormalParameter, FormalParameter },
            Id = "Id",
            InputSets = new List<InputSet> { InputSet, InputSet },
            IsEnableInstanceCompensation = true,
            IsSuppressJoinFailure = true,
            Name = "Name",
            OutputSets = new List<OutputSet> { OutputSet, OutputSet },
            Participants = new List<Participant> { Participant, Participant },
            PartnerLinks = new List<PartnerLink> { PartnerLink, PartnerLink },
            ProcessType = ProcessTypeEnum.Collaboration,
            RedefinableHeader = RedefinableHeader,
            Status = ProcessStatusEnum.Aborting,
            Transitions = new List<Transition> { Transition, Transition }
        };

        public static LayoutInfo LayoutInfo = new LayoutInfo
        {
            PixelsPerMillimeter = 1.0f
        };

        public static ConformanceClass ConformanceClass = new ConformanceClass
        {
            BPMNModelPortabilityConformance = BPMNConformanceEnum.Complete,
            GraphConformance = GraphConformanceEnum.FullBlocked
        };

        public static VendorExtension VendorExtension = new VendorExtension
        {
            ExtensionDescription = "ExtendedDescription",
            SchemaNamespace = "SchemaNamespace",
            ToolId = "ToolId"
        };

        public static ExternalPackage ExternalPackage = new ExternalPackage
        {
            ExtendedAttributes = new List<ExtendedAttribute> { ExtendedAttribute, ExtendedAttribute },
            Href = "Href",
            Id = "Id",
            Name = "Name"
        };

        public static PackageHeader PackageHeader = new PackageHeader
        {
            CostUnit = Unit,
            Created = Date,
            Description = Description,
            Documentation = Documentation,
            ModificationDate = Date,
            PriorityUnit = Unit,
            Vendor = Vendor,
            VendorExtensions = new List<VendorExtension> { VendorExtension, VendorExtension },
            XpdlVersion = Version,
            LayoutInfo = LayoutInfo
        };

        public static Package Package = new Package
        {
            //Applications = new List<Application> { Application, Application },
            Artifacts = new List<Artifact> { Artifact, Artifact },
            Associations = new List<Association> { Association, Association },
            DataFields = new List<DataField> { DataField, DataField },
            ExtendedAttributes = new List<ExtendedAttribute> { ExtendedAttribute, ExtendedAttribute },
            ExternalPackages = new List<ExternalPackage> { ExternalPackage, ExternalPackage },
            Id = "Id",
            Language = "Language",
            MessageFlows = new List<MessageFlow> { MessageFlow, MessageFlow },
            Name = "Name",
            Pages = new List<Page> { Page, Page },
            Participants = new List<Participant> { Participant, Participant },
            PartnerLinkTypes = new List<PartnerLinkType> { PartnerLinkType, PartnerLinkType },
            Pools = new List<Pool> { Pool, Pool },
            Processes = new List<WorkflowProcess> { WorkflowProcess, WorkflowProcess },
            QueryLanguage = "QueryLanguage",
            RedefinableHeader = RedefinableHeader,
            Script = Script,
            PackageHeader = PackageHeader,
            ConformanceClass = ConformanceClass
        };

    }
}
