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
    public class EventsTests
    {
        [TestFixtureSetUp()]
        public void Setup()
        {
            Utilities.CreateAndSerializeFile(StaticProperties.ResultError, Utilities.EventsDirectory, "ResultErrorBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.ResultMultiple, Utilities.EventsDirectory, "ResultMultipleBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.TriggerCond, Utilities.EventsDirectory, "TriggerConditionalBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.TriggerIntermediateMultiple, Utilities.EventsDirectory, "TriggerIntMultipleBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.TriggerMultiple, Utilities.EventsDirectory, "TriggerMultipleBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.TriggerResultCancel, Utilities.EventsDirectory, "TriggerResultCancelBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.TriggerResultCompensation, Utilities.EventsDirectory, "TriggerResultCompensationBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.TriggerResultLink, Utilities.EventsDirectory, "TriggerResultLinkBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.TriggerResultMessage, Utilities.EventsDirectory, "TriggerResultMessageBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.TriggerResultSignal, Utilities.EventsDirectory, "TriggerResultSignalBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.TriggerRule, Utilities.EventsDirectory, "TriggerRuleBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.TriggerTimer, Utilities.EventsDirectory, "TriggerTimerBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.StartEvent, Utilities.EventsDirectory, "StartEventBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.IntermediateEvent, Utilities.EventsDirectory, "IntermediateEventBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.EndEvent, Utilities.EventsDirectory, "EndEventBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Event, Utilities.EventsDirectory, "EventBasic.xpdl");
        }


		[Test()]
        public void StartEventFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<StartEvent>(
                Utilities.EventsDirectory,
                "StartEventBasic.xpdl",
                "StartEventBasic_out.xpdl"));
        }

        [Test()]
        public void StartEventVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<StartEvent>(
                Utilities.EventsDirectory,
                "StartEvent.xml",
                "StartEvent_out.xml"));
        }
		
		[Test()]
        public void IntermediateEventFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<IntermediateEvent>(
                Utilities.EventsDirectory,
                "IntermediateEventBasic.xpdl",
                "IntermediateEventBasic_out.xpdl"));
        }

        [Test()]
        public void IntermediateEventVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<IntermediateEvent>(
                Utilities.EventsDirectory,
                "IntermediateEvent.xml",
                "IntermediateEvent_out.xml"));
        }
		
		[Test()]
        public void EndEventFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<EndEvent>(
                Utilities.EventsDirectory,
                "EndEventBasic.xpdl",
                "EndEventBasic_out.xpdl"));
        }

        [Test()]
        public void EndEventVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<EndEvent>(
                Utilities.EventsDirectory,
                "EndEvent.xml",
                "EndEvent_out.xml"));
        }
		
		[Test()]
        public void EventFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<Event>(
                Utilities.EventsDirectory,
                "EventBasic.xpdl",
                "EventBasic_out.xpdl"));
        }

        [Test()]
        public void EventVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Event>(
                Utilities.EventsDirectory,
                "Event.xml",
                "Event_out.xml"));
        }
		
        [Test()]
        public void ResultErrorFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<ResultError>(
                Utilities.EventsDirectory,
                "ResultErrorBasic.xpdl",
                "ResultErrorBasic_out.xpdl"));
        }

        [Test()]
        public void ResultErrorVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<ResultError>(
                Utilities.EventsDirectory,
                "ResultError.xml",
                "ResultError_out.xml"));
        }

        [Test()]
        public void ResultMultipleFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<ResultMultiple>(
                Utilities.EventsDirectory,
                "ResultMultipleBasic.xpdl",
                "ResultMultipleBasic_out.xpdl"));
        }

        [Test()]
        public void ResultMultipleVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<ResultMultiple>(
                Utilities.EventsDirectory,
                "ResultMultiple.xml",
                "ResultMultiple_out.xml"));
        }

        [Test()]
        public void TriggerConditionalFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<TriggerConditional>(
                Utilities.EventsDirectory,
                "TriggerConditionalBasic.xpdl",
                "TriggerConditionalBasic_out.xpdl"));
        }

        [Test()]
        public void TriggerConditionalVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<TriggerConditional>(
                Utilities.EventsDirectory,
                "TriggerConditional.xml",
                "TriggerConditional_out.xml"));
        }

        [Test()]
        public void TriggerIntMultipleFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<TriggerIntermediateMultiple>(
                Utilities.EventsDirectory,
                "TriggerIntMultipleBasic.xpdl",
                "TriggerIntMultipleBasic_out.xpdl"));
        }

        [Test()]
        public void TriggerIntermediateMultipleVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<TriggerIntermediateMultiple>(
                Utilities.EventsDirectory,
                "TriggerIntermediateMultiple.xml",
                "TriggerIntermediateMultiple_out.xml"));
        }

        [Test()]
        public void TriggerMultipleFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<TriggerMultiple>(
                Utilities.EventsDirectory,
                "TriggerMultipleBasic.xpdl",
                "TriggerMultipleBasic_out.xpdl"));
        }

        [Test()]
        public void TriggerMultipleVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<TriggerMultiple>(
                Utilities.EventsDirectory,
                "TriggerMultiple.xml",
                "TriggerMultiple_out.xml"));
        }

        [Test()]
        public void TriggerResultCancelFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<TriggerResultCancel>(
                Utilities.EventsDirectory,
                "TriggerResultCancelBasic.xpdl",
                "TriggerResultCancelBasic_out.xpdl"));
        }

        [Test()]
        public void TriggerResultCancelVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<TriggerResultCancel>(
                Utilities.EventsDirectory,
                "TriggerResultCancel.xml",
                "TriggerResultCancel_out.xml"));
        }

        [Test()]
        public void TriggerResultCompensationFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<TriggerResultCompensation>(
                Utilities.EventsDirectory,
                "TriggerResultCompensationBasic.xpdl",
                "TriggerResultCompensationBasic_out.xpdl"));
        }

        [Test()]
        public void TriggerResultCompensationVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<TriggerResultCompensation>(
                Utilities.EventsDirectory,
                "TriggerResultCompensation.xml",
                "TriggerResultCompensation_out.xml"));
        }

        [Test()]
        public void TriggerResultLinkFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<TriggerResultLink>(
                Utilities.EventsDirectory,
                "TriggerResultLinkBasic.xpdl",
                "TriggerResultLinkBasic_out.xpdl"));
        }

        [Test()]
        public void TriggerResultLinkVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<TriggerResultLink>(
                Utilities.EventsDirectory,
                "TriggerResultLink.xml",
                "TriggerResultLink_out.xml"));
        }

        [Test()]
        public void TriggerResultMessageFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<TriggerResultMessage>(
                Utilities.EventsDirectory,
                "TriggerResultMessageBasic.xpdl",
                "TriggerResultMessageBasic_out.xpdl"));
        }

        [Test()]
        public void TriggerResultMessageVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<TriggerResultMessage>(
                Utilities.EventsDirectory,
                "TriggerResultMessage.xml",
                "TriggerResultMessage_out.xml"));
        }

        [Test()]
        public void TriggerResultSignalFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<TriggerResultSignal>(
                Utilities.EventsDirectory,
                "TriggerResultSignalBasic.xpdl",
                "TriggerResultSignalBasic_out.xpdl"));
        }

        [Test()]
        public void TriggerResultSignalVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<TriggerResultSignal>(
                Utilities.EventsDirectory,
                "TriggerResultSignal.xml",
                "TriggerResultSignal_out.xml"));
        }

        [Test()]
        public void TriggerRuleFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<TriggerRule>(
                Utilities.EventsDirectory,
                "TriggerRuleBasic.xpdl",
                "TriggerRuleBasic_out.xpdl"));
        }

        [Test()]
        public void TriggerRuleVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<TriggerRule>(
                Utilities.EventsDirectory,
                "TriggerRule.xml",
                "TriggerRule_out.xml"));
        }

        [Test()]
        public void TriggerTimerFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<TriggerTimer>(
                Utilities.EventsDirectory,
                "TriggerTimerBasic.xpdl",
                "TriggerTimerBasic_out.xpdl"));
        }

        [Test()]
        public void TriggerTimerVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<TriggerTimer>(
                Utilities.EventsDirectory,
                "TriggerTimer.xml",
                "TriggerTimer_out.xml"));
        }
    }
}
