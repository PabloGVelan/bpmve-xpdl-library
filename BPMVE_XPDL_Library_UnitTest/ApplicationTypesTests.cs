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
	public class ApplicationTypesTests
	{
		[TestFixtureSetUp()]
        public void Setup()
        {
			Utilities.CreateAndSerializeFile(StaticProperties.ApplicationType_EJB, Utilities.ApplicationTypesDirectory, "ApplicationType_EJBBasic.xpdl");
			Utilities.CreateAndSerializeFile(StaticProperties.ApplicationType_BusinessRule, Utilities.ApplicationTypesDirectory, "ApplicationType_BusinessRuleBasic.xpdl");
			Utilities.CreateAndSerializeFile(StaticProperties.ApplicationType_Form, Utilities.ApplicationTypesDirectory, "ApplicationType_FormBasic.xpdl");
			Utilities.CreateAndSerializeFile(StaticProperties.ApplicationType_POJO, Utilities.ApplicationTypesDirectory, "ApplicationType_POJOBasic.xpdl");
			Utilities.CreateAndSerializeFile(StaticProperties.ApplicationType_Script, Utilities.ApplicationTypesDirectory, "ApplicationType_ScriptBasic.xpdl");
			Utilities.CreateAndSerializeFile(StaticProperties.ApplicationType_WebService, Utilities.ApplicationTypesDirectory, "ApplicationType_WebServiceBasic.xpdl");
			Utilities.CreateAndSerializeFile(StaticProperties.ApplicationType_XSLT, Utilities.ApplicationTypesDirectory, "ApplicationType_XSLTBasic.xpdl");
			Utilities.CreateAndSerializeFile(StaticProperties.ApplicationType, Utilities.ApplicationTypesDirectory, "ApplicationTypeBasic.xpdl");
		}

		[Test()]
        public void ApplicationType_EJBFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<ApplicationType_EJB>(
                Utilities.ApplicationTypesDirectory,
                "ApplicationType_EJBBasic.xpdl",
                "ApplicationType_EJBBasic_out.xpdl"));
        }
		
		[Test()]
        public void ApplicationType_BusinessRuleFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<ApplicationType_BusinessRule>(
                Utilities.ApplicationTypesDirectory,
                "ApplicationType_BusinessRuleBasic.xpdl",
                "ApplicationType_BusinessRuleBasic_out.xpdl"));
        }
		
		[Test()]
        public void ApplicationType_FormFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<ApplicationType_Form>(
                Utilities.ApplicationTypesDirectory,
                "ApplicationType_FormBasic.xpdl",
                "ApplicationType_FormBasic_out.xpdl"));
        }
		
		[Test()]
        public void ApplicationType_POJOFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<ApplicationType_POJO>(
                Utilities.ApplicationTypesDirectory,
                "ApplicationType_POJOBasic.xpdl",
                "ApplicationType_POJOBasic_out.xpdl"));
        }
		
		[Test()]
        public void ApplicationType_ScriptFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<ApplicationType_Script>(
                Utilities.ApplicationTypesDirectory,
                "ApplicationType_ScriptBasic.xpdl",
                "ApplicationType_ScriptBasic_out.xpdl"));
        }
		
		[Test()]
        public void ApplicationType_WebServiceFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<ApplicationType_WebService>(
                Utilities.ApplicationTypesDirectory,
                "ApplicationType_WebServiceBasic.xpdl",
                "ApplicationType_WebServiceBasic_out.xpdl"));
        }
		
		[Test()]
        public void ApplicationType_XSLTFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<ApplicationType_XSLT>(
                Utilities.ApplicationTypesDirectory,
                "ApplicationType_XSLTBasic.xpdl",
                "ApplicationType_XSLTBasic_out.xpdl"));
        }
		
		[Test()]
        public void ApplicationTypeFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<ApplicationType>(
                Utilities.ApplicationTypesDirectory,
                "ApplicationTypeBasic.xpdl",
                "ApplicationTypeBasic_out.xpdl"));
        }
	}
}
