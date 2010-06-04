using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.1.9.5. Data Object
    /// In BPMN, a Data Object is considered an Artifact AND not a Flow Object. It is considered a
    /// n Artifact because it does not have any direct affect on the Sequence Flow OR Message Flow 
    /// of the Process, but it does provide information about what the Process does. That is, how 
    /// documents, Data, AND Other objects are used AND updated during the Process. While the name
    /// ―Data Object‖ may imply an electronic document, it can be used To represent many different 
    /// types of objects, Both electronic AND physical.
    /// As an Artifact, Data Objects generally will be associated with Flow Objects. An Association 
    /// will be used To make the connection between the Data Object AND the Flow Object. This means 
    /// that the behavior of the Process can be modeled without Data Objects for modelers who want 
    /// To reduce clutter. The same Process can be modeled with Data Objects for modelers who want 
    /// To include more information without changing the basic behavior of the Process.
    /// In some cases, the Data Object will be shown being sent From One activity To another, via a 
    /// Sequence Flow. Data Objects will also be associated with Message Flow. They are not To be 
    /// confused with the Message itself, but could be thought of as the ―payload‖ OR content of 
    /// some messages.
    /// In Other cases, the same Data Object will be shown as being an input, then an output of a 
    /// Process. Directionality added To the Association will show whether the Data Object is an 
    /// input OR an output. Also, the state attribute of the Data Object can change To show the
    /// impact of the Process on the Data Object.
    /// </summary>
    public class DataObject : IValidate
    {
        /// <summary>
        /// A list of Data fields.
        /// </summary>
        [XmlElement("DataField")]
        public List<DataField> DataFields { get; set; }
        [XmlIgnore]
        public bool DataFieldsSpecified { get { return DataFields == null ? false : DataFields.Count != 0; } }

        [XmlAttribute("Id")]
        public string Id { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }
		[XmlIgnore]
		public bool NameSpecified { get { return Name != ""; } }

        /// <summary>
        /// State is an optional attribute that indicates the impact the Process has had on the 
        /// Data Object. Multiple Data Objects with the same name MAY share the same state within
        /// One Process.
        /// </summary>
        [XmlAttribute("State")]
        public string State { get; set; }
        [XmlIgnore]
        public bool StateSpecified { get { return State != ""; } }

        /// <summary>
        /// Deprecated in BPMN 1.1
        /// </summary>
        [XmlAttribute("RequiredForStart")]
        [DefaultValue(false)]
        public bool IsRequiredForStart { get; set; }
        //[XmlIgnore]
        //public bool IsRequiredForStartSpecified { get { return IsRequiredForStart != null; } }

        /// <summary>
        /// Deprecated in BPMN 1.1
        /// </summary>
        [XmlAttribute("ProducedAtCompletion")]
        [DefaultValue(false)]
        public bool IsProducedAtCompletion { get; set; }
        //[XmlIgnore]
        //public bool IsProducedAtCompletionSpecified { get { return IsProducedAtCompletion != null; } }



        public DataObject()
        {
            IsRequiredForStart = false;
            IsProducedAtCompletion = false;
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            DataObject value = obj as DataObject;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.State, this.Id, this.Name, this.IsProducedAtCompletion, this.IsRequiredForStart
                };

                List<object> listB = new List<object>
                {
                    value.State, value.Id, value.Name, value.IsProducedAtCompletion, value.IsRequiredForStart
                };

                if (!Utilities.IsListEqual<DataField>(this.DataFields, value.DataFields))
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