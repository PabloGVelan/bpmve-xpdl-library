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
	public class ImplementationTests
	{
		[TestFixtureSetUp()]
        public void Setup()
        {
            Utilities.CreateAndSerializeFile(StaticProperties.TaskApplication, Utilities.ImplementationDirectory, "TaskApplicationBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.TaskManual, Utilities.ImplementationDirectory, "TaskManualBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.TaskReceive, Utilities.ImplementationDirectory, "TaskReceiveBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.TaskReference, Utilities.ImplementationDirectory, "TaskReferenceBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.TaskScript, Utilities.ImplementationDirectory, "TaskScriptBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.TaskSend, Utilities.ImplementationDirectory, "TaskSendBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.TaskService, Utilities.ImplementationDirectory, "TaskServiceBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.TaskUser, Utilities.ImplementationDirectory, "TaskUserBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Task, Utilities.ImplementationDirectory, "TaskBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.NoImplementation, Utilities.ImplementationDirectory, "NoImplementationBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Reference, Utilities.ImplementationDirectory, "ReferenceBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.SubFlow, Utilities.ImplementationDirectory, "SubFlowBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Implementation, Utilities.ImplementationDirectory, "ImplementationBasic.xpdl");
		}
		
		[Test()]
		public void TaskFull()
		{
			Assert.IsTrue(Utilities.InitializeFullTest<Task>(
                Utilities.ImplementationDirectory,
                "TaskBasic.xpdl",
                "TaskBasic_out.xpdl"));
		}

        [Test()]
        public void TaskVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Task>(
                Utilities.ImplementationDirectory,
                "Task.xml",
                "Task_out.xml"));
        }
		
		[Test()]
		public void TaskApplicationFull()
		{
			Assert.IsTrue(Utilities.InitializeFullTest<TaskApplication>(
                Utilities.ImplementationDirectory,
                "TaskApplicationBasic.xpdl",
                "TaskApplicationBasic_out.xpdl"));
		}

        [Test()]
        public void TaskApplicationVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<TaskApplication>(
                Utilities.ImplementationDirectory,
                "TaskApplication.xml",
                "TaskApplication_out.xml"));
        }
		
		[Test()]
		public void TaskManualFull()
		{
			Assert.IsTrue(Utilities.InitializeFullTest<TaskManual>(
                Utilities.ImplementationDirectory,
                "TaskManualBasic.xpdl",
                "TaskManualBasic_out.xpdl"));
		}

        [Test()]
        public void TaskManualVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<TaskManual>(
                Utilities.ImplementationDirectory,
                "TaskManual.xml",
                "TaskManual_out.xml"));
        }
		
		[Test()]
		public void TaskReceiveFull()
		{
			Assert.IsTrue(Utilities.InitializeFullTest<TaskReceive>(
                Utilities.ImplementationDirectory,
                "TaskReceiveBasic.xpdl",
                "TaskReceiveBasic_out.xpdl"));
		}

        [Test()]
        public void TaskReceiveVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<TaskReceive>(
                Utilities.ImplementationDirectory,
                "TaskReceive.xml",
                "TaskReceive_out.xml"));
        }
		
		[Test()]
		public void TaskReferenceFull()
		{
			Assert.IsTrue(Utilities.InitializeFullTest<TaskReference>(
                Utilities.ImplementationDirectory,
                "TaskReferenceBasic.xpdl",
                "TaskReferenceBasic_out.xpdl"));
		}

        [Test()]
        public void TaskReferenceVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<TaskReference>(
                Utilities.ImplementationDirectory,
                "TaskReference.xml",
                "TaskReference_out.xml"));
        }

		[Test()]
		public void TaskScriptFull()
		{
			Assert.IsTrue(Utilities.InitializeFullTest<TaskScript>(
                Utilities.ImplementationDirectory,
                "TaskScriptBasic.xpdl",
                "TaskScriptBasic_out.xpdl"));
		}

        [Test()]
        public void TaskScriptVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<TaskScript>(
                Utilities.ImplementationDirectory,
                "TaskScript.xml",
                "TaskScript_out.xml"));
        }
		
		[Test()]
		public void TaskSendFull()
		{
			Assert.IsTrue(Utilities.InitializeFullTest<TaskSend>(
                Utilities.ImplementationDirectory,
                "TaskSendBasic.xpdl",
                "TaskSendBasic_out.xpdl"));
		}

        [Test()]
        public void TaskSendVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<TaskSend>(
                Utilities.ImplementationDirectory,
                "TaskSend.xml",
                "TaskSend_out.xml"));
        }
		
		[Test()]
		public void TaskServiceFull()
		{
			Assert.IsTrue(Utilities.InitializeFullTest<TaskService>(
                Utilities.ImplementationDirectory,
                "TaskServiceBasic.xpdl",
                "TaskServiceBasic_out.xpdl"));
		}

        [Test()]
        public void TaskServiceVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<TaskService>(
                Utilities.ImplementationDirectory,
                "TaskService.xml",
                "TaskService_out.xml"));
        }
		
		[Test()]
		public void TaskUserFull()
		{
			Assert.IsTrue(Utilities.InitializeFullTest<TaskUser>(
                Utilities.ImplementationDirectory,
                "TaskUserBasic.xpdl",
                "TaskUserBasic_out.xpdl"));
		}

        [Test()]
        public void TaskUserVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<TaskUser>(
                Utilities.ImplementationDirectory,
                "TaskUser.xml",
                "TaskUser_out.xml"));
        }
		
		[Test()]
		public void NoImplementationFull()
		{
			Assert.IsTrue(Utilities.InitializeFullTest<NoImplementation>(
                Utilities.ImplementationDirectory,
                "NoImplementationBasic.xpdl",
                "NoImplementationBasic_out.xpdl"));
		}

        [Test()]
        public void NoImplementationVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<NoImplementation>(
                Utilities.ImplementationDirectory,
                "No.xml",
                "No_out.xml"));
        }
		
		[Test()]
		public void ReferenceFull()
		{
			Assert.IsTrue(Utilities.InitializeFullTest<Reference>(
                Utilities.ImplementationDirectory,
                "ReferenceBasic.xpdl",
                "ReferenceBasic_out.xpdl"));
		}

        [Test()]
        public void ReferenceVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Reference>(
                Utilities.ImplementationDirectory,
                "Reference.xml",
                "Reference_out.xml"));
        }
		
		[Test()]
		public void SubFlowFull()
		{
			Assert.IsTrue(Utilities.InitializeFullTest<SubFlow>(
                Utilities.ImplementationDirectory,
                "SubFlowBasic.xpdl",
                "SubFlowBasic_out.xpdl"));
		}

        [Test()]
        public void SubFlowVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<SubFlow>(
                Utilities.ImplementationDirectory,
                "SubFlow.xml",
                "SubFlow_out.xml"));
        }
		
		[Test()]
		public void ImplementationFull()
		{
			Assert.IsTrue(Utilities.InitializeFullTest<Implementation>(
                Utilities.ImplementationDirectory,
                "ImplementationBasic.xpdl",
                "ImplementationBasic_out.xpdl"));
		}

        [Test()]
        public void ImplementationVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Implementation>(
                Utilities.ImplementationDirectory,
                "Implementation.xml",
                "Implementation_out.xml"));
        }
	}
}
