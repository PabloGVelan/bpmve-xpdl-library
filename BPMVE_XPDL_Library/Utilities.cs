using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;
using System.IO;
using System.Xml.Schema;
using System.Xml;
using System.Collections;

namespace BPMVE_XPDL_Library
{
	/// <summary>
	/// This class provides handy methods to perform serialization and deserialization, as well as
	/// some generic type methods to perform comparisons operation. 
	/// </summary>
    public static class Utilities
    {
        public static XmlSerializerNamespaces EmptyNamespaces = ConstructEmptyNamespaces();
        public static XmlWriterSettings EmptySettings = ConstructEmptySettings();
		public static string DefaultNamespace = "http://www.wfmc.org/2008/XPDL2.1";
		
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
            serializer.Serialize(writer, obj, ConstructTIBCONamespaces());
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
        public static XmlSerializerNamespaces ConstructTIBCONamespaces()
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
        /// Determines if two given lists of type "T" are equal.
        /// </summary>
        /// <typeparam name="T">Any declared type within the program.</typeparam>
        /// <param name="listA">The first list</param>
        /// <param name="listB">The second list</param>
        /// <returns>Returns true if both lists are completely the same or both empty. 
        /// Returns false if number of items in the lists are not the same, 
        /// or any single element in the list is not equal to the same element in another list.</returns>
        public static bool IsListEqual<T>(List<T> listA, List<T> listB)
        {
            // If both list is null means they are equal
            if (listA != null && listB != null)
            {
                // check number of elements in a list
                int count = listA.Count;
                // return false if list count is not equal
                if (listA.Count != listB.Count)
                    return false;
                // if both list contain nothing return true
                else if (listA.Count == 0 && listB.Count == 0)
                    return true;
                else
                {
                    // recursively check each element
                    for (int i = 0; i < count; i++)
                    {
                        if (listA[i] is WorkflowProcess)
                        {
                            WorkflowProcess w1 = listA[i] as WorkflowProcess;
                            WorkflowProcess w2 = listB[i] as WorkflowProcess;
                            if (!w1.Equals(w2))
                                return false;
                        }
                        // return false any single pair of them is not equal
                        else if (!listA[i].Equals(listB[i]))
                            return false;
                    }
                    // return true if all check can be completed
                    return true;
                }
            }
            else
                return true;
        }

		/// <summary>
		/// Determines if all objects of type "T" in parameter "objA" are equal to the corresponding
		/// objects in parameter "objB".
		/// <list>
		/// 		<item>
		/// 			CAUTIOUS! Both parameters cannot contain any object that implements System.Collections
		/// 			type. Please use IsListEqual() for those objects, otherwise this method will return false.
		/// 		</item>
		/// 		<item>
		/// 			WARNING! Please be aware that this method does not sort the given lists. Objects must be
		/// 			presented in the same order in both lists, otherwise this method will return false.
		/// 		</item>
		/// </list>
		/// </summary>
		/// <typeparam name="T">Any declared type within the program.</typeparam>
		/// <param name="objA">A list of objects</param>
		/// <param name="objB">A list of objects</param>
		/// <returns>
		/// Return true if objects in both list are the same or both list are of zero objects or null.
		/// Return false the number of objects in both lists are not the same, or if any object in 
		/// the first list is not the same as the corresponding object in the second list, or if any
		/// object in any list is of System.Collections type, or either one of the parameters is null.
		/// </returns>
        public static bool IsEqual<T>(List<T> objA, List<T> objB)
        {
            // check if both lists are not null
            if (objA != null && objB != null)
            {
                int countA = objA.Count;
                int countB = objB.Count;

                // returns false if number of items in the lists are not equal
                if (countA != countB)
                    return false;

                // recursively checks if a particular object in both lists are equal
                for (int i = 0; i < countA; i++)
                {
                    if (objA[i] != null && objB[i] != null)
                    {
                        // This determines the type of the object is of collection
                        if (objA[i].GetType().Namespace.Contains("System.Collections")) return false;

                        #region Debug_Code
                        //{
                        //    //if (!IsListEqual<T>((List<T>)objA[i], (List<T>)objB[i]))
                        //    //    return false;
                        //    //FIXME: Now ignoring List type variables
                        //}
                        //else
                        //{
                        //    if (!objA[i].Equals(objB[i]))
                        //        return false;
                        //}
                        #endregion
                        
                        // returns false if it is not the same
                        if (!objA[i].Equals(objB[i]))
                            return false;
                    }
                }

                return true;
            }
            // returns true if both lists are null
            else if (objA == null && objB == null)
                return true;
            // either one of the lists is null, return false
            else
                return false;
        }
    }
}
