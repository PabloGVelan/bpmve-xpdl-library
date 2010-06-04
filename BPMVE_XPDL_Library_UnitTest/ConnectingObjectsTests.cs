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
    public class ConnectingObjectsTests
    {
        [TestFixtureSetUp()]
        public void Setup()
        {
            Utilities.CreateAndSerializeFile(StaticProperties.Association, Utilities.ConnObjectsDirectory, "AssociationBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Transition, Utilities.ConnObjectsDirectory, "TransitionBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.MessageFlow, Utilities.ConnObjectsDirectory, "MessageFlowBasic.xpdl");
        }

        [Test()]
        public void AssociationFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Association>(
                Utilities.ConnObjectsDirectory,
                "AssociationBasic.xpdl",
                "AssociationBasic_out.xpdl"));
        }

        [Test()]
        public void AssociationVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Association>(
                Utilities.ConnObjectsDirectory,
                "Association.xml",
                "Association_out.xml"));
        }

        [Test()]
        public void TransitionFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Transition>(
                Utilities.ConnObjectsDirectory,
                "TransitionBasic.xpdl",
                "TransitionBasic_out.xpdl"));
        }

        [Test()]
        public void TransitionVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Transition>(
                Utilities.ConnObjectsDirectory,
                "Transition.xml",
                "Transition_out.xml"));
        }

        [Test()]
        public void MessageFlowFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<MessageFlow>(
                Utilities.ConnObjectsDirectory,
                "MessageFlowBasic.xpdl",
                "MessageFlowBasic_out.xpdl"));
        }

        [Test()]
        public void MessageFlowVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<MessageFlow>(
                Utilities.ConnObjectsDirectory,
                "MessageFlow.xml",
                "MessageFlow_out.xml"));
        }
    }
}
