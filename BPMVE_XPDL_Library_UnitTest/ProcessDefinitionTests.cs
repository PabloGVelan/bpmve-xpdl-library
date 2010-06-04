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
	public class ProcessDefinitionTests
	{
		[TestFixtureSetUp()]
        public void Setup()
        {
            Utilities.CreateAndSerializeFile(StaticProperties.Application, Utilities.ProcessDefDirectory, "ApplicationBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.ActivitySet, Utilities.ProcessDefDirectory, "ActivitySetBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.ProcessHeader, Utilities.ProcessDefDirectory, "ProcessHeaderBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.WorkflowProcess, Utilities.ProcessDefDirectory, "WorkflowProcessBasic.xpdl");
		}
		
		[Test()]
		public void ApplicationFull()
		{
			Assert.IsTrue(Utilities.InitializeFullTest<Application>(
                Utilities.ProcessDefDirectory,
                "ApplicationBasic.xpdl",
                "ApplicationBasic_out.xpdl"));
		}

        [Test()]
        public void ApplicationVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Application>(
                Utilities.ProcessDefDirectory,
                "Application.xml",
                "Application_out.xml"));
        }
		
		[Test()]
		public void ActivitySetFull()
		{
			Assert.IsTrue(Utilities.InitializeFullTest<ActivitySet>(
                Utilities.ProcessDefDirectory,
                "ActivitySetBasic.xpdl",
                "ActivitySetBasic_out.xpdl"));
		}

        [Test()]
        public void ActivitySetVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<ActivitySet>(
                Utilities.ProcessDefDirectory,
                "ActivitySet.xml",
                "ActivitySet_out.xml"));
        }
		
		[Test()]
		public void ProcessHeaderFull()
		{
			Assert.IsTrue(Utilities.InitializeFullTest<ProcessHeader>(
                Utilities.ProcessDefDirectory,
                "ProcessHeaderBasic.xpdl",
                "ProcessHeaderBasic_out.xpdl"));
		}

        [Test()]
        public void ProcessHeaderVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<ProcessHeader>(
                Utilities.ProcessDefDirectory,
                "ProcessHeader.xml",
                "ProcessHeader_out.xml"));
        }
		
		[Test()]
		public void WorkflowProcessFull()
		{
			Assert.IsTrue(Utilities.InitializeFullTest<WorkflowProcess>(
                Utilities.ProcessDefDirectory,
                "WorkflowProcessBasic.xpdl",
                "WorkflowProcessBasic_out.xpdl"));
		}

        [Test()]
        public void WorkflowProcessVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<WorkflowProcess>(
                Utilities.ProcessDefDirectory,
                "WorkflowProcess.xml",
                "WorkflowProcess_out.xml"));
        }
	}
}
