using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.9.4. Message Type
    /// The Message type element is used in the definition of attributes for a Start Event, 
    /// End Event, Intermediate Event, Task, Message Flow, etc.
    /// </summary>
    public class Message : IValidate
    {
        /// <summary>
        /// A list of parameters that compose the Message. See section 7.1.5.3.
        /// </summary>
        [XmlArray("ActualParameters")]
        public List<ActualParameter> ActualParameters { get; set; }
        [XmlIgnore]
        public bool ActualParametersSpecified { get { return ActualParameters == null ? false : ActualParameters.Count != 0; } }

        /// <summary>
        /// Alternative approach To build the Message. See section 7.6.5.4.7.
        /// </summary>
        [XmlArray("DataMappings")]
        public List<DataMapping> DataMappings { get; set; }
        [XmlIgnore]
        public bool DataMappingsSpecified { get { return DataMappings == null ? false : DataMappings.Count != 0; } }

        /// <summary>
        /// Id of the Message.
        /// </summary>
        [XmlAttribute("Id")]
        public string Id { get; set; }

        /// <summary>
        /// Text description of the Message.
        /// </summary>
        [XmlAttribute("Name")]
        public string Name { get; set; }
		[XmlIgnore]
		public bool NameSpecified { get { return Name != ""; } }

        /// <summary>
        /// Optional, but if present must be the name of a Participant (see section 7.4.1) /Process
        /// </summary>
        [XmlAttribute("From")]
        public string From { get; set; }
		[XmlIgnore]
		public bool FromSpecified { get { return From != ""; } }

        /// <summary>
        /// Optional, but if present must be the name of a Participant (see section 7.4.1) /Process
        /// </summary>
        [XmlAttribute("To")]
        public string To { get; set; }
		[XmlIgnore]
		public bool ToSpecified { get { return To != ""; } }

        /// <summary>
        /// When the Message is an Error Message (for example an Error response To a request), 
        /// the FaultName corresponds To the fault (Exception). See WebServiceFaultCatch To 
        /// handle the Error in the receiving End
        /// </summary>
        [XmlAttribute("FaultName")]
        public string FaultName { get; set; }
		[XmlIgnore]
		public bool FaultNameSpecified { get { return FaultName != ""; } }



        public Message()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Message value = obj as Message;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Id, this.Name, this.From, this.To, this.FaultName
                };

                List<object> listB = new List<object>
                {
                    value.Id, value.Name, value.From, value.To, value.FaultName
                };

                if (!Utilities.IsListEqual<ActualParameter>(this.ActualParameters, value.ActualParameters) ||
                    !Utilities.IsListEqual<DataMapping>(this.DataMappings, value.DataMappings))
                {
                    return false;
                }

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