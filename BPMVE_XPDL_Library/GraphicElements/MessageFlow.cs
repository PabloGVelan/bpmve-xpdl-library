using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.9.1. Message Flow
    /// A Message Flow is used To show the flow of messages between two entities that are prepared
    /// To send AND receive them. In BPMN, two separate Pools in the Diagram will represent the two
    /// entities. Thus, Message Flow MUST connect two Pools, either To the Pools themselves OR To
    /// Flow Objects within the Pools. They cannot connect two objects within the same Pool.
    /// </summary>
    public class MessageFlow : ConnectingObject, IValidate
    {
        /// <summary>
        /// Message is an optional attribute that identifies the Message that is being sent. 
        /// See section 7.9.4.
        /// </summary>
        [XmlElement("Message")]
        public Message Message { get; set; }
		[XmlIgnore]
		public bool MessageSpecified { get { return Message != null; } }

        /// <summary>
        /// See section 7.1.9.4.
        /// </summary>
        [XmlElement("Object")]
        public override Object_XPDL Object { get; set; }
        [XmlIgnore]
        public override bool ObjectSpecified { get { return Object != null; } }

        /// <summary>
        /// See section 7.1.2.4.
        /// </summary>
        [XmlArray("ConnectorGraphicsInfos")]
        public override List<ConnectorGraphicsInfo> ConnectorGraphicsInfos { get; set; }
		[XmlIgnore]
		public override bool ConnectorGraphicsInfosSpecified { get { return ConnectorGraphicsInfos == null ? false : ConnectorGraphicsInfos.Count != 0; } }

        /// <summary>
        /// Used To identify the MessageFlow.
        /// </summary>
        [XmlAttribute("Id")]
        public override string Id { get; set; }

        /// <summary>
        /// Name of the MessageFlow.
        /// </summary>
        [XmlAttribute("Name")]
        public override string Name { get; set; }
        [XmlIgnore]
        public override bool NameSpecified { get { return Name != ""; } }

        /// <summary>
        /// Determines the source of a MessageFlow (Activity OR Pool).
        /// </summary>
        [XmlAttribute("Source")]
        public string Source { get; set; }
		[XmlIgnore]
		public bool SourceSpecified { get { return Source != ""; } }

        /// <summary>
        /// Determines the target of a MessageFlow (Activity OR Pool).
        /// </summary>
        [XmlAttribute("Target")]
        public string Target { get; set; }
        [XmlIgnore]
        public bool TargetSpecified { get { return Target != ""; } }



        public MessageFlow()
        {
        }
        
        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            MessageFlow value = obj as MessageFlow;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Message, this.Source, this.Target, this.Id, this.Name, this.Object
                };

                List<object> listB = new List<object>
                {
                    value.Message, value.Source, value.Target, value.Id, value.Name, value.Object
                };

                if (!Utilities.IsListEqual<ConnectorGraphicsInfo>(this.ConnectorGraphicsInfos, value.ConnectorGraphicsInfos))
                    return false;

                return (Utilities.IsEqual(listA, listB));
            }

            return false;
        }

        #region IValidate Members

        public override bool Validate()
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}