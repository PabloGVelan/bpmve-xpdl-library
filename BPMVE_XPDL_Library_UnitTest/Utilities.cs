using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;
using System.IO;
using System.Xml;
using BPMVE_XPDL_Library;
using NUnit.Framework;
using System.Xml.Xsl;

namespace BPMVE_XPDL_Library_UnitTest
{
    public static class Utilities
    {
        public static XmlSerializerNamespaces EmptyNamespaces = ConstructEmptyNamespaces();
        public static XmlWriterSettings EmptySettings = ConstructEmptySettings();
        public static string DefaultNamespace = "http://www.wfmc.org/2008/XPDL2.1";
        public static DirectoryInfo ExeDirectory = new DirectoryInfo(Environment.CurrentDirectory);
        //public static string TestDirectory = ExeDirectory.Parent.Parent.ToString() + "/TestArtifacts/";
        public static string TestDirectory = @"C:\Users\Renfred\Desktop\BPMVE_XPDL_Library\BPMVE_XPDL_Library_UnitTest\TestArtifacts\";
        public static string SupportingDirectory = TestDirectory + @"SupportingTypes/";
        public static string SwimlanesDirectory = TestDirectory + @"Swimlanes/";
        public static string EventsDirectory = TestDirectory + @"Events/";
        public static string GraphicsInfosDirectory = TestDirectory + @"GraphicsInfos/";
        public static string ArtifactsDirectory = TestDirectory + @"Artifacts/";
        public static string ConnObjectsDirectory = TestDirectory + @"ConnectingObjects/";
        public static string GrapElemsSupportTypesDirectory = TestDirectory + @"GraphicElementsSupportingTypes/";
        public static string ImplementationDirectory = TestDirectory + @"Implementation/";
        public static string ActivityDirectory = TestDirectory + @"Activity/";
        public static string ApplicationTypesDirectory = TestDirectory + @"ApplicationTypes/";
        public static string ProcessDefDirectory = TestDirectory + @"ProcessDefinition/";
        public static string PackageDirectory = TestDirectory + @"Package/";
        public static string TIBCODirectory = TestDirectory + @"TIBCO/";

		/// <summary>
		/// Serialize object "obj" with default namespace "defaultNamespace" to file "toFile".
		/// This will add default TIBCO namespaces.
		/// <list>
		/// 		<item>
		/// 			WARNING! If default namespace is NOT given and included in "toFile" then
		///         exception will be thrown.
		/// 		</item>
		/// </list>  
		/// </summary>
		/// <example>
		/// Activity activity = new Activity();
		/// SerializeToFile(activity, "file.xpdl", "http://www.wfmc.org/2008/XPDL2.1");
		/// [Activity xmlns:xpdExt="http://www.tibco.com/XPD/xpdExtension1.0.0" 
		/// 			  xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
		/// 			  xmlns:xpdl2="http://www.wfmc.org/2008/XPDL2.1"]
		/// [/Activity]
		/// </example>
		/// <param name="obj">
		/// Object to be serialized.
		/// </param>
		/// <param name="toFile">
		/// File to be serialized to (full location address).
		/// </param>
		/// <param name="defaultNamespace">
		/// Namespace that will be used as default namespace. Every attribute will have this
		/// namespace pre-fixed onto the front.
		/// </param>
        public static void SerializeToFile(object obj, string toFile, string defaultNamespace)
        {
            XmlSerializer serializer = new XmlSerializer(obj.GetType(), defaultNamespace);
            TextWriter writer = new StreamWriter(toFile);
            serializer.Serialize(writer, obj, ConstructNamespaces());
            writer.Close();
        }

		/// <summary>
		/// Serialize object "obj" with empty namespaces and empty settings to file "toFile".
		/// </summary>
		/// <example>
		/// Activity activity = new Activity();
		/// SerializeToFile(activity, "file.xpdl");
		/// [Activity][/Activity]
		/// </example>
		/// <param name="obj">
		/// Object to be serialized.
		/// </param>
		/// <param name="toFile">
		/// File to be serialized to (full location address).
		/// </param>
        public static void SerializeToFile(object obj, string toFile)
        {
            //TextWriter txtWriter = new StreamWriter(toFile, false);
            using (XmlWriter xmlWriter = XmlWriter.Create(toFile, EmptySettings))
            {
                XmlSerializer serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(xmlWriter, obj, EmptyNamespaces);
            }
        }

		/// <summary>
		/// Serialize object "obj" with no default namespaces to file "toFile".
		/// Additional namesapces can be added with XmlSerializeNamespaces.
		/// Additional writer settings can be added with XmlWriterSettings.
		/// <list>
		/// 		<item>
		/// 			WARNING! If default namespace is included in "toFile" then
		///         exception will be thrown.
		/// 		</item>
		/// </list>  
		/// </summary>
		/// <param name="obj">
		/// Object to be serialized.
		/// </param>
		/// <param name="toFile">
		/// File to be serialized to (full location address).
		/// <param name="namespaces">
		/// Additional XmlSerializerNamespaces to be added to the file.
		/// </param>
		/// <param name="settings">
		/// Additional XmlWriterSettings to be used to generate the file.
		/// </param>
        public static void SerializeToFile(object obj, string toFile, 
		                                   XmlSerializerNamespaces namespaces, 
		                                   XmlWriterSettings settings)
        {
            using (XmlWriter xmlWriter = XmlWriter.Create(toFile, settings))
            {
                XmlSerializer serializer = new XmlSerializer(obj.GetType());
                serializer.Serialize(xmlWriter, obj, namespaces);
            }
        }
		
		/// <summary>
		/// Serialize object "obj" with default namespace "defaultNamespace" to file "toFile".
		/// Additional namesapces can be added with XmlSerializeNamespaces.
		/// Additional writer settings can be added with XmlWriterSettings.
		/// <list>
		/// 		<item>
		/// 			WARNING! If default namespace is NOT given and included in "toFile" then
		///         exception will be thrown.
		/// 		</item>
		/// </list>  
		/// </summary>
		/// <param name="obj">
		/// Object to be serialized.
		/// </param>
		/// <param name="toFile">
		/// File to be serialized to (full location address).
		/// </param>
		/// <param name="defaultNamespace">
		/// Namespace that will be used as default namespace. Every attribute will have this
		/// namespace pre-fixed onto the front.
		/// </param>
		/// <param name="namespaces">
		/// Additional XmlSerializerNamespaces to be added to the file.
		/// </param>
		/// <param name="settings">
		/// Additional XmlWriterSettings to be used to generate the file.
		/// </param>
		public static void SerializeToFile(object obj, string toFile, string defaultNamespace, 
		                                   XmlSerializerNamespaces namespaces, 
		                                   XmlWriterSettings settings)
        {
            using (XmlWriter xmlWriter = XmlWriter.Create(toFile, settings))
            {
                XmlSerializer serializer = new XmlSerializer(obj.GetType(), defaultNamespace);
                serializer.Serialize(xmlWriter, obj, namespaces);
            }
        }

		/// <summary>
		/// Deserialize object of type "Generic" from file "fromFile" with default namespace
		/// of "defaultNamespace".
		/// <list>
		/// 		<item>
		/// 			WARNING! If default namespace is NOT given and included in "fromFile" then
		///         exception will be thrown.
		/// 		</item>
		/// </list>  
		/// </summary>
		/// <typeparam name="Generic">Any declared type within the program.</typeparam>
		/// <param name="fromFile">
		/// String represents the location (including name) of the file to be loaded.
		/// </param>
		/// <param name="defaultNamespace">
		/// Default namespace to be expected in "fromFile".
		/// </param>
		/// <returns>
		/// An object of type "Generic" deserialized from "fromFile".
		/// </returns>
        public static Generic DeserializeToObject<Generic>(string fromFile, string defaultNamespace)
        {
            Generic obj;
            XmlSerializer serializer;
            if (defaultNamespace != null)
                serializer = new XmlSerializer(typeof(Generic), defaultNamespace);
            else
                serializer = new XmlSerializer(typeof(Generic));
            using (XmlReader reader = XmlReader.Create(fromFile))
            {                
                obj = (Generic)serializer.Deserialize(reader);
            }
            return obj;
        }

		/// <summary>
		/// Construct and return default TIBCO namespaces.  
		/// </summary>
		/// <returns>
		/// A <see cref="XmlSerializerNamespaces"/> that contains:
		/// <list>
		/// 		<item>
		/// 			xmlns:xpdl12="http://www.wfmc.org/2008/XPDL2.1"
		/// 		</item>
		/// 	    <item>
		/// 			xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance"
		/// 		</item>
		/// 		<item>
		/// 			xmlns:xpdExt="http://www.tibco.com/XPD/xpdExtension1.0.0"
		/// 		</item>
		/// </list>
		/// </returns>
        public static XmlSerializerNamespaces ConstructNamespaces()
        {
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add("database", "ttp://www.tibco.com/XPD/database1.0.0");
            namespaces.Add("eaiJava", "http://www.tibco.com/XPD/EAIJava1.0.0");
            namespaces.Add("email", "http://www.tibco.com/XPD/email1.0.0");
            namespaces.Add("iProcessExt", "http://www.tibco.com/XPD/iProcessExt1.0.0");
            namespaces.Add("orchestrator", "http://www.tibco.com/XPD/orchestrator1.0.0");
            namespaces.Add("order", "http://www.tibco.com/XPD/order1.0.0");
            namespaces.Add("simulation", "http://www.tibco.com/xpd/Simulation1.0.1");
            namespaces.Add("xpdl2", "http://www.wfmc.org/2008/XPDL2.1");
            namespaces.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance");
            namespaces.Add("xpdExt", "http://www.tibco.com/XPD/xpdExtension1.0.0");
            return namespaces;
        }

		/// <summary>
		/// Construct and return empty namespaces. 
		/// </summary>
		/// <returns>
		/// A <see cref="XmlSerializerNamespaces"/> that contains nothing.
		/// </returns>
        public static XmlSerializerNamespaces ConstructEmptyNamespaces()
        {
            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add("", "");
            return namespaces;
        }

		/// <summary>
		/// Construct and return empty XMLWriterSettings. This removes any XML declaration on
		/// top of the file.
		/// </summary>
		/// <returns>
		/// A <see cref="XmlWriterSettings"/> that contains nothing.
		/// </returns>
        public static XmlWriterSettings ConstructEmptySettings()
        {
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.OmitXmlDeclaration = true;
            settings.Indent = true;
            return settings;
        }

		/// <summary>
		/// Initialize test case that fully tests BPMVE_XPDL_Library objects. Both files must be
		/// exactly the same to pass the test. This method assumes that both files has no
		/// namespaces and no default xml header.
		/// </summary>
		/// <param name="baseDir">
		/// A <see cref="System.String"/> that represents the base directory of "inFilename" and
		/// "outFilename".
		/// </param>
		/// <param name="inFilename">
		/// A <see cref="System.String"/> that represents the filename of the input file 
		/// to be tested.
		/// </param>
		/// <param name="outFilename">
		/// A <see cref="System.String"/> that represents the filename of the output file 
		/// to be tested.
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/> value that represents the test result. 
		/// Return true if and only if object that was deserialized from input file fully equals to
		/// the object that was deserialized from the output file.
		/// </returns>
        public static bool InitializeFullTest<Generic>(string baseDir, string inFilename, string outFilename)
        {
            Generic inValue, outValue;

            inValue = DeserializeToObject<Generic>(baseDir + inFilename, null);

            SerializeToFile(inValue, baseDir + outFilename, EmptyNamespaces, EmptySettings);

            outValue = DeserializeToObject<Generic>(baseDir + outFilename, null);

            return inValue.Equals(outValue);
        }

        public static bool InitializeTIBCOTest<Generic>(string baseDir, string inFilename, string outFilename)
        {
            Generic inValue, outValue;
            XmlWriterSettings settings = new XmlWriterSettings();
			settings.Indent = true;

            inValue = DeserializeToObject<Generic>(baseDir + inFilename, DefaultNamespace);

            SerializeToFile(inValue, baseDir + outFilename, DefaultNamespace, ConstructNamespaces(), settings);

            outValue = DeserializeToObject<Generic>(baseDir + outFilename, DefaultNamespace);

            return inValue.Equals(outValue);
        }
		
		/// <summary>
		/// Initialize test case that tests XML file generated by Visual Studio 2010 based on the
		/// XSD file (version 3.1) from XPDL official website. Both files must be exactly the same
		/// to pass the test. This method assumes that both files has xmlns:p1="otherNS" and
		/// default XML header in it.
		/// </summary>
		/// <param name="baseDir">
		/// A <see cref="System.String"/> that represents the base directory of "inFilename" and
		/// "outFilename".
		/// </param>
		/// <param name="inFilename">
		/// A <see cref="System.String"/> that represents the filename of the input file 
		/// to be tested.
		/// </param>
		/// <param name="outFilename">
		/// A <see cref="System.String"/> that represents the filename of the output file 
		/// to be tested.
		/// </param>
		/// <returns>
		/// A <see cref="System.Boolean"/> value that represents the test result. 
		/// Return true if and only if object that was deserialized from input file fully equals to
		/// the object that was deserialized from the output file.
		/// </returns>
		public static bool InitializeVSXMLTest<Generic>(string baseDir, string inFilename, string outFilename)
		{
			Generic inValue, outValue;
			XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add("p1", "otherNS");
			XmlWriterSettings settings = new XmlWriterSettings();
			settings.Indent = true;
			
			inValue = DeserializeToObject<Generic>(baseDir + inFilename, DefaultNamespace);
			
			SerializeToFile(inValue, baseDir + outFilename, DefaultNamespace, namespaces, settings);
			
			outValue = DeserializeToObject<Generic>(baseDir + outFilename, DefaultNamespace);
			
			return inValue.Equals(outValue);
		}

        public static void CreateAndSerializeFile(object obj, string baseDir, string filename)
        {
            SerializeToFile(obj, baseDir + filename, EmptyNamespaces, EmptySettings);
        }
    }
}
