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
    public class GraphicsInfosTests
    {
        [TestFixtureSetUp()]
        public void Setup()
        {
            Utilities.CreateAndSerializeFile(StaticProperties.ConnectorGraphicsInfo, Utilities.GraphicsInfosDirectory, "ConnectorGraphicsInfoBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.NodeGraphicsInfo, Utilities.GraphicsInfosDirectory, "NodeGraphicsInfoBasic.xpdl");
        }

        [Test()]
        public void ConnectorGraphicsInfoFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<ConnectorGraphicsInfo>(
                Utilities.GraphicsInfosDirectory,
                "ConnectorGraphicsInfoBasic.xpdl",
                "ConnectorGraphicsInfoBasic_out.xpdl"));
        }

        [Test()]
        public void ConnectorGraphicsInfoVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<ConnectorGraphicsInfo>(
                Utilities.GraphicsInfosDirectory,
                "ConnectorGraphicsInfo.xml",
                "ConnectorGraphicsInfo_out.xml"));
        }

        [Test()]
        public void NodeGraphicsInfoFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<NodeGraphicsInfo>(
                Utilities.GraphicsInfosDirectory,
                "NodeGraphicsInfoBasic.xpdl",
                "NodeGraphicsInfoBasic_out.xpdl"));
        }

        [Test()]
        public void NodeGraphicsInfoVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<NodeGraphicsInfo>(
                Utilities.GraphicsInfosDirectory,
                "NodeGraphicsInfo.xml",
                "NodeGraphicsInfo_out.xml"));
        }
    }
}
