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
    [TestFixture()]
    public class SupportingTypesTests
    {
        [TestFixtureSetUp()]
        public void Setup()
        {
            Utilities.CreateAndSerializeFile(StaticProperties.ArtifactInput, Utilities.SupportingDirectory, "ArtifactInputBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Assignment, Utilities.SupportingDirectory, "AssignmentBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Author, Utilities.SupportingDirectory, "AuthorBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Category, Utilities.SupportingDirectory, "CategoryBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Codepage, Utilities.SupportingDirectory, "CodepageBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Color, Utilities.SupportingDirectory, "ColorBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Condition, Utilities.SupportingDirectory, "ConditionBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Coordinates, Utilities.SupportingDirectory, "CoordinatesBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Cost, Utilities.SupportingDirectory, "CostBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.CountryKey, Utilities.SupportingDirectory, "CountryKeyBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Description, Utilities.SupportingDirectory, "DescriptionBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.DataField, Utilities.SupportingDirectory, "DataFieldBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.DataMapping, Utilities.SupportingDirectory, "DataMappingBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Documentation, Utilities.SupportingDirectory, "DocumentationBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Date, Utilities.SupportingDirectory, "DateBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Duration, Utilities.SupportingDirectory, "DurationBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.ExpressionType, Utilities.SupportingDirectory, "ExprTypeBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.ExtendedAttribute, Utilities.SupportingDirectory, "ExtAttrBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.ExternalReference, Utilities.SupportingDirectory, "ExtRefBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.FormalParameter, Utilities.SupportingDirectory, "FormalParamBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Input, Utilities.SupportingDirectory, "InputBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.InputSet, Utilities.SupportingDirectory, "InputSetBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Limit, Utilities.SupportingDirectory, "LimitBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.MessageType, Utilities.SupportingDirectory, "MessageTypeBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Output, Utilities.SupportingDirectory, "OutputBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.OutputSet, Utilities.SupportingDirectory, "OutputSetBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Page, Utilities.SupportingDirectory, "PageBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Participant, Utilities.SupportingDirectory, "ParticipantBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.ParticipantType, Utilities.SupportingDirectory, "PartTypeBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Partner, Utilities.SupportingDirectory, "PartnerBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.PartnerLink, Utilities.SupportingDirectory, "PartnerLinkBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.PartnerLinkType, Utilities.SupportingDirectory, "PartnerLinkTypeBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.PartnerRole, Utilities.SupportingDirectory, "PartnerRoleBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Performer, Utilities.SupportingDirectory, "PerformerBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Priority, Utilities.SupportingDirectory, "PriorityBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.PropertyInput, Utilities.SupportingDirectory, "PropertyInputBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.RedefinableHeader, Utilities.SupportingDirectory, "RedHeaderBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Responsible, Utilities.SupportingDirectory, "ResponsibleBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Role, Utilities.SupportingDirectory, "RoleBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Service, Utilities.SupportingDirectory, "ServiceBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Script, Utilities.SupportingDirectory, "ScriptBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Time, Utilities.SupportingDirectory, "TimeBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.TimeEstimation, Utilities.SupportingDirectory, "TimeEstimationBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.TransitionRef, Utilities.SupportingDirectory, "TransitionRefBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Unit, Utilities.SupportingDirectory, "UnitBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.ValidTo, Utilities.SupportingDirectory, "ValidToBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.ValidFrom, Utilities.SupportingDirectory, "ValidFromBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Vendor, Utilities.SupportingDirectory, "VendorBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Version, Utilities.SupportingDirectory, "VersionBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.WebServiceFaultCatch, Utilities.SupportingDirectory, "WebFaultBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.WebServiceOperation, Utilities.SupportingDirectory, "WebOptBasic.xpdl");
        }

        #region A_Tests

        [Test()]
        public void ArtifactInputFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<ArtifactInput>(
                Utilities.SupportingDirectory,
                "ArtifactInputBasic.xpdl",
                "ArtifactInputBasic_out.xpdl"));
        }
		
		[Test()]
		public void ArtifactInputVSXML()
		{
			Assert.IsTrue(Utilities.InitializeVSXMLTest<ArtifactInput>(
			    Utilities.SupportingDirectory,
			    "ArtifactInput.xml",
			    "ArtifactInput_out.xml"));
		}

        [Test()]
        public void AssignmentFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Assignment>(
                Utilities.SupportingDirectory,
                "AssignmentBasic.xpdl",
                "AssignmentBasic_out.xpdl"));
        }
		
		[Test()]
		public void AssignmentVSXML()
		{
			Assert.IsTrue(Utilities.InitializeVSXMLTest<Assignment>(
			    Utilities.SupportingDirectory,
			    "Assignment.xml",
			    "Assignment_out.xml"));
		}

        [Test()]
        public void AuthorFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Author>(
                Utilities.SupportingDirectory,
                "AuthorBasic.xpdl",
                "AuthorBasic_out.xpdl"));
        }
		
		[Test()]
		public void AuthorVSXML()
		{
			Assert.IsTrue(Utilities.InitializeVSXMLTest<Author>(
			    Utilities.SupportingDirectory,
			    "Author.xml",
			    "Author_out.xml"));
		}

        #endregion

        #region C_Tests

        [Test()]
        public void CategoryFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Category>(
                Utilities.SupportingDirectory,
                "CategoryBasic.xpdl",
                "CategoryBasic_out.xpdl"));
        }
		
		[Test()]
		public void CategoryVSXML()
		{
			Assert.IsTrue(Utilities.InitializeVSXMLTest<Category>(
			    Utilities.SupportingDirectory,
			    "Category.xml",
			    "Category_out.xml"));
		}

        [Test()]
        public void CodepageFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Codepage>(
                Utilities.SupportingDirectory,
                "CodepageBasic.xpdl",
                "CodepageBasic_out.xpdl"));
        }
		
		[Test()]
		public void CodepageVSXML()
		{
			Assert.IsTrue(Utilities.InitializeVSXMLTest<Codepage>(
			    Utilities.SupportingDirectory,
			    "Codepage.xml",
			    "Codepage_out.xml"));
		}

        [Test()]
        public void ColorFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Color>(
                Utilities.SupportingDirectory,
                "ColorBasic.xpdl",
                "ColorBasic_out.xpdl"));
        }

        [Test()]
        public void ConditionFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Condition>(
                Utilities.SupportingDirectory,
                "ConditionBasic.xpdl",
                "ConditionBasic_out.xpdl"));
        }
		
		[Test()]
		public void ConditionVSXML()
		{
			Assert.IsTrue(Utilities.InitializeVSXMLTest<Condition>(
			    Utilities.SupportingDirectory,
			    "Condition.xml",
			    "Condition_out.xml"));
		}

        [Test()]
        public void CoordinatesFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Coordinates>(
                Utilities.SupportingDirectory,
                "CoordinatesBasic.xpdl",
                "CoordinatesBasic_out.xpdl"));
        }
		
		[Test()]
		public void CoordinatesVSXML()
		{
			Assert.IsTrue(Utilities.InitializeVSXMLTest<Coordinates>(
			    Utilities.SupportingDirectory,
			    "Coordinates.xml",
			    "Coordinates_out.xml"));
		}

        [Test()]
        public void CostFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Cost>(
                Utilities.SupportingDirectory,
                "CostBasic.xpdl",
                "CostBasic_out.xpdl"));
        }
		
		[Test()]
		public void CostVSXML()
		{
			Assert.IsTrue(Utilities.InitializeVSXMLTest<Cost>(
			    Utilities.SupportingDirectory,
			    "Cost.xml",
			    "Cost_out.xml"));
		}

        [Test()]
        public void CountryKeyFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Countrykey>(
                Utilities.SupportingDirectory,
                "CountryKeyBasic.xpdl",
                "CountryKeyBasic_out.xpdl"));
        }

        [Test()]
        public void CountryKeyVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Countrykey>(
                Utilities.SupportingDirectory,
                "Countrykey.xml",
                "Countrykey_out.xml"));
        }

        #endregion

        #region D_Tests

        [Test()]
        public void DataFieldFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<DataField>(
                Utilities.SupportingDirectory,
                "DataFieldBasic.xpdl",
                "DataFieldBasic_out.xpdl"));
        }

        [Test()]
        public void DataFieldVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<DataField>(
                Utilities.SupportingDirectory,
                "DataField.xml",
                "DataField_out.xml"));
        }

        [Test()]
        public void DataMappingFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<DataMapping>(
                Utilities.SupportingDirectory,
                "DataMappingBasic.xpdl",
                "DataMappingBasic_out.xpdl"));
        }
		
		[Test()]
		public void DataMappingVSXML()
		{
			Assert.IsTrue(Utilities.InitializeVSXMLTest<DataMapping>(
			    Utilities.SupportingDirectory,
			    "DataMapping.xml",
			    "DataMapping_out.xml"));
		}

        [Test()]
        public void DateFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Date>(
                Utilities.SupportingDirectory,
                "DateBasic.xpdl",
                "DateBasic_out.xpdl"));
        }

        [Test()]
        public void DescriptionFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Description>(
                Utilities.SupportingDirectory,
                "DescriptionBasic.xpdl",
                "DescriptionBasic_out.xpdl"));
        }
		
		[Test()]
		public void DescriptionVSXML()
		{
			Assert.IsTrue(Utilities.InitializeVSXMLTest<Description>(
			    Utilities.SupportingDirectory,
			    "Description.xml",
			    "Description_out.xml"));
		}

        [Test()]
        public void DocumentationFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Documentation>(
                Utilities.SupportingDirectory,
                "DocumentationBasic.xpdl",
                "DocumentationBasic_out.xpdl"));
        }
		
		[Test()]
		public void DocumentationVSXML()
		{
			Assert.IsTrue(Utilities.InitializeVSXMLTest<Documentation>(
			    Utilities.SupportingDirectory,
			    "Documentation.xml",
			    "Documentation_out.xml"));
		}

        [Test()]
        public void DurationFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Duration>(
                Utilities.SupportingDirectory,
                "DurationBasic.xpdl",
                "DurationBasic_out.xpdl"));
        }
		
		[Test()]
		public void DurationVSXML()
		{
			Assert.IsTrue(Utilities.InitializeVSXMLTest<Duration>(
			    Utilities.SupportingDirectory,
			    "Duration.xml",
			    "Duration_out.xml"));
		}

        #endregion

        #region E_Tests

        [Test()]
        public void ExtAttrFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<ExtendedAttribute>(
                Utilities.SupportingDirectory,
                "ExtAttrBasic.xpdl",
                "ExtAttrBasic_out.xpdl"));
        }

        [Test()]
        public void ExtAttrVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<ExtendedAttribute>(
                Utilities.SupportingDirectory,
                "ExtendedAttribute.xml",
                "ExtendedAttribute_out.xml"));
        }

        [Test()]
        public void ExprTypeFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Expression>(
                Utilities.SupportingDirectory,
                "ExprTypeBasic.xpdl",
                "ExprTypeBasic_out.xpdl"));
        }

        [Test()]
        public void ExprTypeVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Expression>(
                Utilities.SupportingDirectory,
                "ExpressionType.xml",
                "ExpressionType_out.xml"));
        }

        [Test()]
        public void ExtRefFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<ExternalReference>(
                Utilities.SupportingDirectory,
                "ExtRefBasic.xpdl",
                "ExtRefBasic_out.xpdl"));
        }

        [Test()]
        public void ExtRefVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<ExternalReference>(
                Utilities.SupportingDirectory,
                "ExternalReference.xml",
                "ExternalReference_out.xml"));
        }

        #endregion

        #region F-I-L-M-O_Tests

        [Test()]
        public void FormalParamFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<FormalParameter>(
                Utilities.SupportingDirectory,
                "FormalParamBasic.xpdl",
                "FormalParamBasic_out.xpdl"));
        }

        [Test()]
        public void FormalParamVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<FormalParameter>(
                Utilities.SupportingDirectory,
                "FormalParameter.xml",
                "FormalParameter_out.xml"));
        }

        [Test()]
        public void InputFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Input>(
                Utilities.SupportingDirectory,
                "InputBasic.xpdl",
                "InputBasic_out.xpdl"));
        }

        [Test()]
        public void InputVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Input>(
                Utilities.SupportingDirectory,
                "Input.xml",
                "Input_out.xml"));
        }

        [Test()]
        public void InputSetFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<InputSet>(
                Utilities.SupportingDirectory,
                "InputSetBasic.xpdl",
                "InputSetBasic_out.xpdl"));
        }

        [Test()]
        public void InputSetVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<InputSet>(
                Utilities.SupportingDirectory,
                "InputSet.xml",
                "InputSet_out.xml"));
        }

        [Test()]
        public void LimitFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Limit>(
                Utilities.SupportingDirectory,
                "LimitBasic.xpdl",
                "LimitBasic_out.xpdl"));
        }

        [Test()]
        public void LimitVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Limit>(
                Utilities.SupportingDirectory,
                "Limit.xml",
                "Limit_out.xml"));
        }

        [Test()]
        public void MessageTypeFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Message>(
                Utilities.SupportingDirectory,
                "MessageTypeBasic.xpdl",
                "MessageTypeBasic_out.xpdl"));
        }

        [Test()]
        public void MessageTypeVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Message>(
                Utilities.SupportingDirectory,
                "MessageType.xml",
                "MessageType_out.xml"));
        }

        [Test()]
        public void OutputFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Output>(
                Utilities.SupportingDirectory,
                "OutputBasic.xpdl",
                "OutputBasic_out.xpdl"));
        }

        [Test()]
        public void OutputVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Output>(
                Utilities.SupportingDirectory,
                "Output.xml",
                "Output_out.xml"));
        }

        [Test()]
        public void OutputSetFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<OutputSet>(
                Utilities.SupportingDirectory,
                "OutputSetBasic.xpdl",
                "OutputSetBasic_out.xpdl"));
        }

        [Test()]
        public void OutputSetVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<OutputSet>(
                Utilities.SupportingDirectory,
                "OutputSet.xml",
                "OutputSet_out.xml"));
        }

        #endregion

        #region P-R-Tests

        [Test()]
        public void PageFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Page>(
                Utilities.SupportingDirectory,
                "PageBasic.xpdl",
                "PageBasic_out.xpdl"));
        }

        [Test()]
        public void PageVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Page>(
                Utilities.SupportingDirectory,
                "Page.xml",
                "Page_out.xml"));
        }

        [Test()]
        public void ParticipantFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Participant>(
                Utilities.SupportingDirectory,
                "ParticipantBasic.xpdl",
                "ParticipantBasic_out.xpdl"));
        }

        [Test()]
        public void ParticipantVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Participant>(
                Utilities.SupportingDirectory,
                "Participant.xml",
                "Participant_out.xml"));
        }

        [Test()]
        public void ParticipantTypeFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<ParticipantType>(
                Utilities.SupportingDirectory,
                "PartTypeBasic.xpdl",
                "PartTypeBasic_out.xpdl"));
        }

        [Test()]
        public void ParticipantTypeVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<ParticipantType>(
                Utilities.SupportingDirectory,
                "ParticipantType.xml",
                "ParticipantType_out.xml"));
        }

        [Test()]
        public void PartnerFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Partner>(
                Utilities.SupportingDirectory,
                "PartnerBasic.xpdl",
                "PartnerBasic_out.xpdl"));
        }

        ////FIXME: HOW TO SOLVE "PARTNER"
        //[Test()]
        //public void PartnerVSXML()
        //{
        //    Assert.IsTrue(Utilities.InitializeVSXMLTest<Partner>(
        //        Utilities.SupportingDirectory,
        //        "Partner.xml",
        //        "Partner_out.xml"));
        //}

        [Test()]
        public void PartnerLinkFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<PartnerLink>(
                Utilities.SupportingDirectory,
                "PartnerLinkBasic.xpdl",
                "PartnerLinkBasic_out.xpdl"));
        }

        [Test()]
        public void PartnerLinkVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<PartnerLink>(
                Utilities.SupportingDirectory,
                "PartnerLink.xml",
                "PartnerLink_out.xml"));
        }

        [Test()]
        public void PartnerLinkTypeFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<PartnerLinkType>(
                Utilities.SupportingDirectory,
                "PartnerLinkTypeBasic.xpdl",
                "PartnerLinkTypeBasic_out.xpdl"));
        }

        [Test()]
        public void PartnerLinkTypeVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<PartnerLinkType>(
                Utilities.SupportingDirectory,
                "PartnerLinkType.xml",
                "PartnerLinkType_out.xml"));
        }

        [Test()]
        public void PartnerRoleFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<PartnerRole>(
                Utilities.SupportingDirectory,
                "PartnerRoleBasic.xpdl",
                "PartnerRoleBasic_out.xpdl"));
        }

        ////FIXME: HOW TO SOLVE "PARTNERROLE"
        //[Test()]
        //public void PartnerRoleVSXML()
        //{
        //    Assert.IsTrue(Utilities.InitializeVSXMLTest<PartnerRole>(
        //        Utilities.SupportingDirectory,
        //        "PartnerRole.xml",
        //        "PartnerRole_out.xml"));
        //}

        [Test()]
        public void PerformerFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Performer>(
                Utilities.SupportingDirectory,
                "PerformerBasic.xpdl",
                "PerformerBasic_out.xpdl"));
        }

        [Test()]
        public void PerformerVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Performer>(
                Utilities.SupportingDirectory,
                "Performer.xml",
                "Performer_out.xml"));
        }

        [Test()]
        public void PriorityFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Priority>(
                Utilities.SupportingDirectory,
                "PriorityBasic.xpdl",
                "PriorityBasic_out.xpdl"));
        }

        [Test()]
        public void PriorityVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Priority>(
                Utilities.SupportingDirectory,
                "Priority.xml",
                "Priority_out.xml"));
        }

        [Test()]
        public void PropertyInputFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<PropertyInput>(
                Utilities.SupportingDirectory,
                "PropertyInputBasic.xpdl",
                "PropertyInputBasic_out.xpdl"));
        }

        [Test()]
        public void PropertyInputVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<PropertyInput>(
                Utilities.SupportingDirectory,
                "PropertyInput.xml",
                "PropertyInput_out.xml"));
        }

        [Test()]
        public void RedefinableHeaderFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<RedefinableHeader>(
                Utilities.SupportingDirectory,
                "RedHeaderBasic.xpdl",
                "RedHeaderBasic_out.xpdl"));
        }

        [Test()]
        public void RedefinableHeaderVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<RedefinableHeader>(
                Utilities.SupportingDirectory,
                "RedefinableHeader.xml",
                "RedefinableHeader_out.xml"));
        }

        [Test()]
        public void ResponsibleFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Responsible>(
                Utilities.SupportingDirectory,
                "ResponsibleBasic.xpdl",
                "ResponsibleBasic_out.xpdl"));
        }

        [Test()]
        public void ResponsibleVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Responsible>(
                Utilities.SupportingDirectory,
                "Responsible.xml",
                "Responsible_out.xml"));
        }

        [Test()]
        public void RoleFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Role>(
                Utilities.SupportingDirectory,
                "RoleBasic.xpdl",
                "RoleBasic_out.xpdl"));
        }

        ////FIXME: HOW TO SOLVE "ROLE"
        //[Test()]
        //public void RoleVSXML()
        //{
        //    Assert.IsTrue(Utilities.InitializeVSXMLTest<Role>(
        //        Utilities.SupportingDirectory,
        //        "Role.xml",
        //        "Role_out.xml"));
        //}

        #endregion

        #region S-T-U-V-W-Tests

        [Test()]
        public void ScriptFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Script>(
                Utilities.SupportingDirectory,
                "ScriptBasic.xpdl",
                "ScriptBasic_out.xpdl"));
        }

        [Test()]
        public void ScriptVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Script>(
                Utilities.SupportingDirectory,
                "Script.xml",
                "Script_out.xml"));
        }

        [Test()]
        public void ServiceFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Service>(
                Utilities.SupportingDirectory,
                "ServiceBasic.xpdl",
                "ServiceBasic_out.xpdl"));
        }

        ////FIXME: HOW TO SOLVE "SERVICE"
        //[Test()]
        //public void ServiceVSXML()
        //{
        //    Assert.IsTrue(Utilities.InitializeVSXMLTest<Service>(
        //        Utilities.SupportingDirectory,
        //        "Service.xml",
        //        "Service_out.xml"));
        //}

        [Test()]
        public void TimeFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Time>(
                Utilities.SupportingDirectory,
                "TimeBasic.xpdl",
                "TimeBasic_out.xpdl"));
        }

        ////FIXME: HOW TO SOLVE "TIME"
        //[Test()]
        //public void TimeVSXML()
        //{
        //    Assert.IsTrue(Utilities.InitializeVSXMLTest<Time>(
        //        Utilities.SupportingDirectory,
        //        "Time.xml",
        //        "Time_out.xml"));
        //}

        [Test()]
        public void TimeEstimationFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<TimeEstimation>(
                Utilities.SupportingDirectory,
                "TimeEstimationBasic.xpdl",
                "TimeEstimationBasic_out.xpdl"));
        }

        [Test()]
        public void TimeEstimationVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<TimeEstimation>(
                Utilities.SupportingDirectory,
                "TimeEstimation.xml",
                "TimeEstimation_out.xml"));
        }

        [Test()]
        public void TransitionRefFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<TransitionRef>(
                Utilities.SupportingDirectory,
                "TransitionRefBasic.xpdl",
                "TransitionRefBasic_out.xpdl"));
        }

        [Test()]
        public void TransitionRefVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<TransitionRef>(
                Utilities.SupportingDirectory,
                "TransitionRef.xml",
                "TransitionRef_out.xml"));
        }

        [Test()]
        public void UnitFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Unit>(
                Utilities.SupportingDirectory,
                "UnitBasic.xpdl",
                "UnitBasic_out.xpdl"));
        }

        ////FIXME: HOW TO SOLVE "UNIT"
        //[Test()]
        //public void UnitVSXML()
        //{
        //    Assert.IsTrue(Utilities.InitializeVSXMLTest<Unit>(
        //        Utilities.SupportingDirectory,
        //        "Unit.xml",
        //        "Unit_out.xml"));
        //}

        [Test()]
        public void ValidToFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<ValidTo>(
                Utilities.SupportingDirectory,
                "ValidToBasic.xpdl",
                "ValidToBasic_out.xpdl"));
        }

        [Test()]
        public void ValidToVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<ValidTo>(
                Utilities.SupportingDirectory,
                "ValidTo.xml",
                "ValidTo_out.xml"));
        }

        [Test()]
        public void ValidFromFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<ValidFrom>(
                Utilities.SupportingDirectory,
                "ValidFromBasic.xpdl",
                "ValidFromBasic_out.xpdl"));
        }

        [Test()]
        public void ValidFromVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<ValidFrom>(
                Utilities.SupportingDirectory,
                "ValidFrom.xml",
                "ValidFrom_out.xml"));
        }

        [Test()]
        public void VendorFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Vendor>(
                Utilities.SupportingDirectory,
                "VendorBasic.xpdl",
                "VendorBasic_out.xpdl"));
        }

        [Test()]
        public void VendorVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Vendor>(
                Utilities.SupportingDirectory,
                "Vendor.xml",
                "Vendor_out.xml"));
        }

        [Test()]
        public void VersionFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<BPMVE_XPDL_Library.Version_XPDL>(
                Utilities.SupportingDirectory,
                "VersionBasic.xpdl",
                "VersionBasic_out.xpdl"));
        }

        [Test()]
        public void VersionVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<BPMVE_XPDL_Library.Version_XPDL>(
                Utilities.SupportingDirectory,
                "Version.xml",
                "Version_out.xml"));
        }

        [Test()]
        public void WebServiceFaultCatchFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<WebServiceFaultCatch>(
                Utilities.SupportingDirectory,
                "WebFaultBasic.xpdl",
                "WebFaultBasic_out.xpdl"));
        }

        [Test()]
        public void WebServiceFaultCatchVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<WebServiceFaultCatch>(
                Utilities.SupportingDirectory,
                "WebServiceFaultCatch.xml",
                "WebServiceFaultCatch_out.xml"));
        }

        [Test()]
        public void WebServiceOperationFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<WebServiceOperation>(
                Utilities.SupportingDirectory,
                "WebOptBasic.xpdl",
                "WebOptBasic_out.xpdl"));
        }

        [Test()]
        public void WebServiceOperationVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<WebServiceOperation>(
                Utilities.SupportingDirectory,
                "WebServiceOperation.xml",
                "WebServiceOperation_out.xml"));
        }

        #endregion
    }
}
