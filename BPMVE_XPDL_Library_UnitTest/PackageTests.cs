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
	public class PackageTests
	{
		[TestFixtureSetUp()]
        public void Setup()
        {
            Utilities.CreateAndSerializeFile(StaticProperties.LayoutInfo, Utilities.PackageDirectory, "LayoutInfoBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.ConformanceClass, Utilities.PackageDirectory, "ConformanceClassBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.VendorExtension, Utilities.PackageDirectory, "VendorExtensionBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.ExternalPackage, Utilities.PackageDirectory, "ExternalPackageBasic.xpdl");
            Utilities.CreateAndSerializeFile(StaticProperties.PackageHeader, Utilities.PackageDirectory, "PackageHeaderBasic.xpdl");
			Utilities.CreateAndSerializeFile(StaticProperties.Package, Utilities.PackageDirectory, "PackageBasic.xpdl");
		}
		
		[Test()]
		public void LayoutInfoFull()
		{
			Assert.IsTrue(Utilities.InitializeFullTest<LayoutInfo>(
                Utilities.PackageDirectory,
                "LayoutInfoBasic.xpdl",
                "LayoutInfoBasic_out.xpdl"));
		}

        [Test()]
        public void LayoutInfoVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<LayoutInfo>(
                Utilities.PackageDirectory,
                "LayoutInfo.xml",
                "LayoutInfo_out.xml"));
        }
		
		[Test()]
		public void ConformanceClassFull()
		{
			Assert.IsTrue(Utilities.InitializeFullTest<ConformanceClass>(
                Utilities.PackageDirectory,
                "ConformanceClassBasic.xpdl",
                "ConformanceClassBasic_out.xpdl"));
		}

        [Test()]
        public void ConformanceClassVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<ConformanceClass>(
                Utilities.PackageDirectory,
                "ConformanceClass.xml",
                "ConformanceClass_out.xml"));
        }
		
		[Test()]
		public void VendorExtensionFull()
		{
			Assert.IsTrue(Utilities.InitializeFullTest<VendorExtension>(
                Utilities.PackageDirectory,
                "VendorExtensionBasic.xpdl",
                "VendorExtensionBasic_out.xpdl"));
		}

        [Test()]
        public void VendorExtensionVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<VendorExtension>(
                Utilities.PackageDirectory,
                "VendorExtension.xml",
                "VendorExtension_out.xml"));
        }
		
		[Test()]
		public void ExternalPackageFull()
		{
			Assert.IsTrue(Utilities.InitializeFullTest<ExternalPackage>(
                Utilities.PackageDirectory,
                "ExternalPackageBasic.xpdl",
                "ExternalPackageBasic_out.xpdl"));
		}

        [Test()]
        public void ExternalPackageVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<ExternalPackage>(
                Utilities.PackageDirectory,
                "ExternalPackage.xml",
                "ExternalPackage_out.xml"));
        }

        [Test()]
        public void PackageHeaderFull()
        {
            Assert.IsTrue(Utilities.InitializeFullTest<PackageHeader>(
                Utilities.PackageDirectory,
                "PackageHeaderBasic.xpdl",
                "PackageHeaderBasic_out.xpdl"));
        }

        [Test()]
        public void PackageHeaderVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<PackageHeader>(
                Utilities.PackageDirectory,
                "PackageHeader.xml",
                "PackageHeader_out.xml"));
        }
		
		[Test()]
		public void PackageFull()
		{
			Assert.IsTrue(Utilities.InitializeFullTest<Package>(
                Utilities.PackageDirectory,
                "PackageBasic.xpdl",
                "PackageBasic_out.xpdl"));
		}

        [Test()]
        public void PackageVSXML()
        {
            Assert.IsTrue(Utilities.InitializeVSXMLTest<Package>(
                Utilities.PackageDirectory,
                "Package.xml",
                "Package_out.xml"));
        }
	}
}
