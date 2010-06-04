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
    public class SwimlanesTests
    {
        [TestFixtureSetUp()]
        public void Setup()
        {
            Utilities.CreateAndSerializeFile(StaticProperties.Lane, Utilities.SwimlanesDirectory, "LaneBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Pool, Utilities.SwimlanesDirectory, "PoolBasic.xpdl");
        }

        [Test()]
        public void LaneFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Lane>(
                Utilities.SwimlanesDirectory,
                "LaneBasic.xpdl",
                "LaneBasic_out.xpdl"));
        }

        [Test()]
        public void LaneVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Lane>(
                Utilities.SwimlanesDirectory,
                "Lane.xml",
                "Lane_out.xml"));
        }

        [Test()]
        public void PoolFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Pool>(
                Utilities.SwimlanesDirectory,
                "PoolBasic.xpdl",
                "PoolBasic_out.xpdl"));
        }

        [Test()]
        public void PoolVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Pool>(
                Utilities.SwimlanesDirectory,
                "Pool.xml",
                "Pool_out.xml"));
        }
    }
}
