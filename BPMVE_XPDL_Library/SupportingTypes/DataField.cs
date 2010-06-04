using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.12. Relevant Data Standard/ExclusiveType
    /// Relevant Data fields represent the variables of a process OR Package Definition. 
    /// They are typically used To maintain decision Data (used in conditions) OR reference 
    /// Data values (parameters), which are passed between activities OR subflow. This may
    /// be differentiated From application Data, which is Data managed OR accessed wholly by 
    /// the invoked applications AND which is not accessible To the process OR workflow management 
    /// System. The relevant Data Standard list defines All Data objects which are required by the 
    /// process. The attribute DataType explicitly specifies All information needed for a process 
    /// OR workflow management System To define an appropriate Data object for storing Data, which 
    /// is To be handled by an Active instance of the process. Relevant Data Standard can be defined 
    /// in a process AND in a Package. The scopes differ in that the former may only be accessed by
    /// entities defined inside that process, while the latter may be used also e.g. To define the 
    /// parameters of a process entity. Where parameters are passed To a called subflow outside the 
    /// current model definition (e.g. To support remote process invocation) it is the responsibility
    /// of the process designer(s) To ensure that Data type compatibility exists across the 
    /// parameter set.
    /// </summary>
    public class DataField : IValidate
    {
        /// <summary>
        /// Data type of the process variable. See Section 7.13.
        /// </summary>
        [XmlElement("DataType")]
        public DataType DataType { get; set; }
		[XmlIgnore]
		public bool DataTypeSpecified { get { return DataType != null; } }

        /// <summary>
        /// Pre-assignment of Data for run time.
        /// </summary>
        [XmlElement("InitialValue")]
        public Expression InitialValue { get; set; }
        [XmlIgnore]
        public bool InitialValueSpecified { get { return InitialValue != null; } }

        /// <summary>
        /// The length of the Data.
        /// </summary>
        [XmlElement("Length")]
        public string Length { get; set; }
        [XmlIgnore]
        public bool LengthSpecified { get { return Length != ""; } }

        /// <summary>
        /// Short textual description of the Data defined.
        /// </summary>
        [XmlElement("Description")]
        public Description Description { get; set; }
		[XmlIgnore]
		public bool DescriptionSpecified { get { return Description != null; } }

        /// <summary>
        /// Optional extensions To meet individual implementation needs.
        /// </summary>
        [XmlArray("ExtendedAttributes")]
        public List<ExtendedAttribute> ExtendedAttributes { get; set; }
        [XmlIgnore]
        public bool ExtendedAttributesSpecified { get { return ExtendedAttributes == null ? false : ExtendedAttributes == null ? false : ExtendedAttributes == null ? false : ExtendedAttributes.Count != 0; } }

        /// <summary>
        /// Used To identify the relevant Data Standard.
        /// </summary>
        [XmlAttribute("Id")]
        public string Id { get; set; }

        /// <summary>
        /// Text used To identify the relevant Data Standard.
        /// </summary>
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlIgnore]
        public bool NameSpecified { get { return Name != ""; } }

        /// <summary>
        /// The datafield OR formal parameter is described as readOnly OR as a constant 
        /// AND its value cannot be changed.
        /// </summary>
        [XmlAttribute("ReadOnly")]
        [DefaultValue(false)]
        public bool IsReadOnly { get; set; }
        //[XmlIgnore]
        //public bool IsReadOnlySpecified { get { return IsReadOnly != null; } }

        /// <summary>
        /// Indicates if it is an array.
        /// </summary>
        [XmlAttribute("IsArray")]
        [DefaultValue(false)]
        public bool IsArray { get; set; }
        //[XmlIgnore]
        //public bool IsArraySpecified { get { return IsArray != null; } }

        /// <summary>
        /// Used in BPMN mapping To BPEL.
        /// </summary>
        [XmlAttribute("Correlation")]
        [DefaultValue(false)]
        public bool IsCorrelation { get; set; }
        //[XmlIgnore]
        //public bool IsCorrelationSpecified { get { return IsCorrelation != null; } }



        public DataField()
        {
            IsReadOnly = false;
            IsArray = false;
            IsCorrelation = false;
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            DataField value = obj as DataField;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.DataType, this.IsCorrelation, this.Description, this.Id, 
                    this.InitialValue, this.IsArray, this.IsReadOnly, this.Length, this.Name
                };

                List<object> listB = new List<object>
                {
                    value.DataType, value.IsCorrelation, value.Description, value.Id, 
                    value.InitialValue, value.IsArray, value.IsReadOnly, value.Length, value.Name
                };

                if (!Utilities.IsListEqual<ExtendedAttribute>(this.ExtendedAttributes, value.ExtendedAttributes))
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