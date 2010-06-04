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
    public class ArtifactsTests
    {
        [TestFixtureSetUp()]
        public void Setup()
        {
            Utilities.CreateAndSerializeFile(StaticProperties.Artifact, Utilities.ArtifactsDirectory, "ArtifactBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Group, Utilities.ArtifactsDirectory, "GroupBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.DataObject, Utilities.ArtifactsDirectory, "DataObjectBasic.xpdl");
        }

        [Test()]
        public void ArtifactFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Artifact>(
                Utilities.ArtifactsDirectory,
                "ArtifactBasic.xpdl",
                "ArtifactBasic_out.xpdl"));
        }

        [Test()]
        public void ArtifactVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Artifact>(
                Utilities.ArtifactsDirectory,
                "Artifact.xml",
                "Artifact_out.xml"));
        }

        [Test()]
        public void GroupFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Group>(
                Utilities.ArtifactsDirectory,
                "GroupBasic.xpdl",
                "GroupBasic_out.xpdl"));
        }

        [Test()]
        public void GroupVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Group>(
                Utilities.ArtifactsDirectory,
                "Group.xml",
                "Group_out.xml"));
        }

        [Test()]
        public void DataObjectFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<DataObject>(
                Utilities.ArtifactsDirectory,
                "DataObjectBasic.xpdl",
                "DataObjectBasic_out.xpdl"));
        }

        [Test()]
        public void DataObjectVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<DataObject>(
                Utilities.ArtifactsDirectory,
                "DataObject.xml",
                "DataObject_out.xml"));
        }
    }
}
