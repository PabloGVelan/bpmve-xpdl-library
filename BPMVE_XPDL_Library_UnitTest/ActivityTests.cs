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
	public class ActivityTests
	{
		
		[TestFixtureSetUp()]
        public void Setup()
        {
			Utilities.CreateAndSerializeFile(StaticProperties.Loop, Utilities.ActivityDirectory, "LoopBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.LoopMultiInstance, Utilities.ActivityDirectory, "LoopMultiBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.LoopStandard, Utilities.ActivityDirectory, "LoopStandardBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Join, Utilities.ActivityDirectory, "JoinBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Split, Utilities.ActivityDirectory, "SplitBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.TransitionRestriction, Utilities.ActivityDirectory, "TransitionRestrictionBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.BlockActivity, Utilities.ActivityDirectory, "BlockActivityBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Route, Utilities.ActivityDirectory, "RouteBasic.xpdl");
			Utilities.CreateAndSerializeFile(StaticProperties.Activity, Utilities.ActivityDirectory, "ActivityBasic.xpdl");
		}

		[Test()]
        public void LoopFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Loop>(
                Utilities.ActivityDirectory,
                "LoopBasic.xpdl",
                "LoopBasic_out.xpdl"));
        }

        [Test()]
        public void LoopVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Loop>(
                Utilities.ActivityDirectory,
                "Loop.xml",
                "Loop_out.xml"));
        }
		
		[Test()]
        public void LoopMultiFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<LoopMultiInstance>(
                Utilities.ActivityDirectory,
                "LoopMultiBasic.xpdl",
                "LoopMultiBasic_out.xpdl"));
        }

        [Test()]
        public void LoopMultiInstanceVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<LoopMultiInstance>(
                Utilities.ActivityDirectory,
                "LoopMultiBasic.xml",
                "LoopMultiBasic_out.xml"));
        }
		
		[Test()]
        public void LoopStandardFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<LoopStandard>(
                Utilities.ActivityDirectory,
                "LoopStandardBasic.xpdl",
                "LoopStandardBasic_out.xpdl"));
        }

        [Test()]
        public void LoopStandardVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<LoopStandard>(
                Utilities.ActivityDirectory,
                "LoopStandard.xml",
                "LoopStandard_out.xml"));
        }
		
		[Test()]
        public void JoinFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Join>(
                Utilities.ActivityDirectory,
                "JoinBasic.xpdl",
                "JoinBasic_out.xpdl"));
        }

        [Test()]
        public void JoinVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Join>(
                Utilities.ActivityDirectory,
                "Join.xml",
                "Join_out.xml"));
        }
		
		[Test()]
        public void SplitFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Split>(
                Utilities.ActivityDirectory,
                "SplitBasic.xpdl",
                "SplitBasic_out.xpdl"));
        }

        [Test()]
        public void SplitVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Split>(
                Utilities.ActivityDirectory,
                "Split.xml",
                "Split_out.xml"));
        }
		
		[Test()]
        public void TransitionRestrictionFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<TransitionRestriction>(
                Utilities.ActivityDirectory,
                "TransitionRestrictionBasic.xpdl",
                "TransitionRestrictionBasic_out.xpdl"));
        }

        [Test()]
        public void TransitionRestrictionVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<TransitionRestriction>(
                Utilities.ActivityDirectory,
                "TransitionRestriction.xml",
                "TransitionRestriction_out.xml"));
        }
		
		[Test()]
        public void BlockActivityFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<BlockActivity>(
                Utilities.ActivityDirectory,
                "BlockActivityBasic.xpdl",
                "BlockActivityBasic_out.xpdl"));
        }

        [Test()]
        public void BlockActivityVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<BlockActivity>(
                Utilities.ActivityDirectory,
                "BlockActivity.xml",
                "BlockActivity_out.xml"));
        }
		
		[Test()]
        public void RouteFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Route>(
                Utilities.ActivityDirectory,
                "RouteBasic.xpdl",
                "RouteBasic_out.xpdl"));
        }

        [Test()]
        public void RouteVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Route>(
                Utilities.ActivityDirectory,
                "Route.xml",
                "Route_out.xml"));
        }
		
		[Test()]
        public void ActivityFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Activity>(
                Utilities.ActivityDirectory,
                "ActivityBasic.xpdl",
                "ActivityBasic_out.xpdl"));
        }

        [Test()]
        public void ActivityVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Activity>(
                Utilities.ActivityDirectory,
                "Activity.xml",
                "Activity_out.xml"));
        }
	}
}
