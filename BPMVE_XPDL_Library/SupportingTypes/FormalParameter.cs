using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class FormalParameter : IValidate
    {
        [XmlElement("DataType")]
        public DataType DataType { get; set; }
		[XmlIgnore]
		public bool DataTypeSpecified { get { return DataType != null; } }

        [XmlElement("InitialValue")]
        public Expression InitialValue { get; set; }
		[XmlIgnore]
		public bool InitialValueSpecified { get { return InitialValue != null; } }

        [XmlElement("Description")]
        public Description Description { get; set; }
		[XmlIgnore]
		public bool DescriptionSpecified { get { return Description != null; } }

        [XmlElement("Length")]
        public string Length { get; set; }
		[XmlIgnore]
		public bool LengthSpecified { get { return Length != ""; } }

        [XmlAttribute("Id")]
        public string Id { get; set; }

        [XmlAttribute("Mode")]
        [DefaultValue(FormalParameterMode.In)]
        public FormalParameterMode Mode { get; set; }
        //[XmlIgnore]
        //public bool ModeSpecified { get { return Mode != null; } }

        [XmlAttribute("Name")]
        public string Name { get; set; }
		[XmlIgnore]
		public bool NameSpecified { get { return Name != ""; } }

        [XmlAttribute("ReadOnly")]
        [DefaultValue(false)]
        public bool IsReadOnly { get; set; }
        //[XmlIgnore]
        //public bool IsReadOnlySpecified { get { return IsReadOnly != null; } }

        [XmlAttribute("Required")]
        [DefaultValue(false)]
        public bool IsRequired { get; set; }
        //[XmlIgnore]
        //public bool IsRequiredSpecified { get { return IsRequired != null; } }

        [XmlAttribute("IsArray")]
        [DefaultValue(false)]
        public bool IsArray { get; set; }
        //[XmlIgnore]
        //public bool IsArraySpecified { get { return IsArray != null; } }



        public FormalParameter()
        {
            Mode = FormalParameterMode.In;
            IsReadOnly = false;
            IsRequired = false;
            IsArray = false;
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            FormalParameter value = obj as FormalParameter;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.DataType, this.InitialValue, this.Description, this.Length, this.Id, 
                    this.Mode, this.Name, this.IsReadOnly, this.IsRequired, this.IsArray
                };

                List<object> listB = new List<object>
                {
                    value.DataType, value.InitialValue, value.Description, value.Length, value.Id, 
                    value.Mode, value.Name, value.IsReadOnly, value.IsRequired, value.IsArray
                };

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