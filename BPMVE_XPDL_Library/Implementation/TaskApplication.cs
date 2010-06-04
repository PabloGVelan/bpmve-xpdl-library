using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.5.3.10. TaskApplication (Tool) 
    /// The Activity is implemented by (One OR more) tools. A tool may be an application program 
    /// (Link To entity Application);
    /// which may be invoked via Interface 3 (WfMC) - see the Workflow Client Application API 
    /// (WAPI - Interface 2).
    /// </summary>
    public class TaskApplication : IValidate
    {
        /// <summary>
        /// A list of parameters To be passed To the subflow/subprocess. See section 7.1.5.3.
        /// </summary>
        [XmlArray("ActualParameters")]
        public List<ActualParameter> ActualParameters { get; set; }
		[XmlIgnore]
		public bool ActualParametersSpecified { get { return ActualParameters == null ? false : ActualParameters.Count != 0; } }

        /// <summary>
        /// Alternative approach To passing values between process AND application. 
        /// See section 7.6.5.4.7.
        /// </summary>
        [XmlArray("DataMappings")]
        public List<DataMapping> DataMappings { get; set; }
		[XmlIgnore]
		public bool DataMappingsSpecified { get { return DataMappings == null ? false : DataMappings.Count != 0; } }

        /// <summary>
        /// Textual description.
        /// </summary>
        [XmlElement("Description")]
        public Description Description { get; set; }
		[XmlIgnore]
		public bool DescriptionSpecified { get { return Description != null; } }

        ///// <summary>
        ///// Optional extensions To meet individual implementation needs.
        ///// </summary>
        //public List<ExtendedAttribute> ExtendedAttributes_TaskApplication { get; set; }

        /// <summary>
        /// Identifier used To identify the application OR procedure, depending on the Type.
        /// </summary>
        [XmlAttribute("Id")]
        public string Id { get; set; }

        /// <summary>
        /// Name used To identify the application OR procedure.
        /// </summary>
        [XmlAttribute("Name")]
        public string Name { get; set; }
		[XmlIgnore]
		public bool NameSpecified { get { return Name != ""; } }

        /// <summary>
        /// Used if the application is not in this package.
        /// </summary>
        [XmlAttribute("PackageRef")]
        public string PackageRef { get; set; }
		[XmlIgnore]
		public bool PackageRefSpecified { get { return PackageRef != ""; } }



        public TaskApplication()
        {
        }
        
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            TaskApplication value = obj as TaskApplication;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Description, this.Id, this.Name, this.PackageRef
                };

                List<object> listB = new List<object>
                {
                    value.Description, value.Id, value.Name, value.PackageRef
                };

                if (!Utilities.IsListEqual<ActualParameter>(this.ActualParameters, value.ActualParameters) ||
				    !Utilities.IsListEqual<DataMapping>(this.DataMappings, value.DataMappings))
                    return false;

                return (Utilities.IsEqual(listA, listB));
            }

            return false;
        }

        #region IValidate Members

        public bool Validate()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}