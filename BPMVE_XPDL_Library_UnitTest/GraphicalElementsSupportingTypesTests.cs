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
	public class GraphicalElementsSupportingTypesTests
	{
		[TestFixtureSetUp()]
        public void Setup()
        {
			Utilities.CreateAndSerializeFile(StaticProperties.ResourceCost, Utilities.GrapElemsSupportTypesDirectory, "ResourceCostBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.CostStructure, Utilities.GrapElemsSupportTypesDirectory, "CostStructureBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.Deadline, Utilities.GrapElemsSupportTypesDirectory, "DeadlineBasic.xpdl");
			Utilities.CreateAndSerializeFile(StaticProperties.Icon, Utilities.GrapElemsSupportTypesDirectory, "IconBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.IORules, Utilities.GrapElemsSupportTypesDirectory, "IORulesBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.SimulationInformation, Utilities.GrapElemsSupportTypesDirectory, "SimulationInformationBasic.xpdl");
			Utilities.CreateAndSerializeFile(StaticProperties.Transaction, Utilities.GrapElemsSupportTypesDirectory, "TransactionBasic.xpdl");
		}
		
		[Test()]
		public void ResourceCostFull()
		{
            Assert.IsTrue(Utilities.InitializeFullTest<ResourceCost>(
                Utilities.GrapElemsSupportTypesDirectory,
                "ResourceCostBasic.xpdl",
                "ResourceCostBasic_out.xpdl"));
		}

        [Test()]
        public void ResourceCostVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<ResourceCost>(
                Utilities.GrapElemsSupportTypesDirectory,
                "ResourceCosts.xml",
                "ResourceCosts_out.xml"));
        }
		
		[Test()]
		public void CostStructureFull()
		{
            Assert.IsTrue(Utilities.InitializeFullTest<CostStructure>(
                Utilities.GrapElemsSupportTypesDirectory,
                "CostStructureBasic.xpdl",
                "CostStructureBasic_out.xpdl"));
		}

        [Test()]
        public void CostStructureVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<CostStructure>(
                Utilities.GrapElemsSupportTypesDirectory,
                "CostStructure.xml",
                "CostStructure_out.xml"));
        }
		
		[Test()]
		public void DeadlineFull()
		{
            Assert.IsTrue(Utilities.InitializeFullTest<Deadline>(
                Utilities.GrapElemsSupportTypesDirectory,
                "DeadlineBasic.xpdl",
                "DeadlineBasic_out.xpdl"));
		}

        [Test()]
        public void DeadlineVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Deadline>(
                Utilities.GrapElemsSupportTypesDirectory,
                "Deadline.xml",
                "Deadline_out.xml"));
        }
		
		[Test()]
		public void IconFull()
		{
            Assert.IsTrue(Utilities.InitializeFullTest<Icon>(
                Utilities.GrapElemsSupportTypesDirectory,
                "IconBasic.xpdl",
                "IconBasic_out.xpdl"));
		}

        [Test()]
        public void IconVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Icon>(
                Utilities.GrapElemsSupportTypesDirectory,
                "Icon.xml",
                "Icon_out.xml"));
        }
		
		[Test()]
		public void IORulesFull()
		{
            Assert.IsTrue(Utilities.InitializeFullTest<IORules>(
                Utilities.GrapElemsSupportTypesDirectory,
                "IORulesBasic.xpdl",
                "IORulesBasic_out.xpdl"));
		}

        [Test()]
        public void IORulesVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<IORules>(
                Utilities.GrapElemsSupportTypesDirectory,
                "IORules.xml",
                "IORules_out.xml"));
        }
		
		[Test()]
		public void SimulationInformationFull()
		{
            Assert.IsTrue(Utilities.InitializeFullTest<SimulationInformation>(
                Utilities.GrapElemsSupportTypesDirectory,
                "SimulationInformationBasic.xpdl",
                "SimulationInformationBasic_out.xpdl"));
		}

        [Test()]
        public void SimulationInformationVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<SimulationInformation>(
                Utilities.GrapElemsSupportTypesDirectory,
                "SimulationInformation.xml",
                "SimulationInformation_out.xml"));
        }
		
		[Test()]
		public void TransactionFull()
		{
            Assert.IsTrue(Utilities.InitializeFullTest<Transaction>(
                Utilities.GrapElemsSupportTypesDirectory,
                "TransactionBasic.xpdl",
                "TransactionBasic_out.xpdl"));
		}

        [Test()]
        public void TransactionVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Transaction>(
                Utilities.GrapElemsSupportTypesDirectory,
                "Transaction.xml",
                "Transaction_out.xml"));
        }
	}
}

