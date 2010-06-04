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
    public class TIBCOTests
    {
        [TestFixtureSetUp()]
        public void Setup()
        {
        }

        [Test()]
        public void SimpleTest()
        {
            Assert.IsTrue(Utilities.InitializeTIBCOTest<Package>(
                Utilities.TIBCODirectory,
                "Simple.xpdl",
                "Simple_out.xpdl"));
        }
        
        [Test()]
        public void ComplexTest()
        {
            Assert.IsTrue(Utilities.InitializeTIBCOTest<Package>(
                Utilities.TIBCODirectory,
                "Complex.xpdl",
                "Complex_out.xpdl"));
        }
    }
}
