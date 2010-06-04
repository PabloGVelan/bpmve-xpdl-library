using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.5.3.9. TaskUser 
    /// A User Task is a typical ―workflow‖ task where a Human performer performs the Task with the
    /// assistance of a software application AND is scheduled through a task list manager of some sort.
    /// </summary>
    public class TaskUser : IValidate
    {
        /// <summary>
        /// One OR more Performers MAY be entered. The Performers attribute defines the Human
        /// Resource that will be performing the Task. The Performers entry could be in the form
        /// of a specific individual, a group, OR an organization.
        /// </summary>
        [XmlArray("Performers")]
        public List<Performer> Performers { get; set; }
        [XmlIgnore]
        public bool PerformersSpecified { get { return Performers == null ? false : Performers.Count != 0; } }

        /// <summary>
        /// A Message for the InMessage attribute may be entered. This indicates that the Message 
        /// will be sent at the Start of the Task, After the availability of any defined InputSets. 
        /// A corresponding outgoing Message Flow MAY be shown on the diagram. However, the display
        /// of the Message Flow is not required. See section 7.9.4.
        /// </summary>
        [XmlElement("MessageIn")]
        public Message MessageIn { get; set; }
		[XmlIgnore]
		public bool MessageInSpecified { get { return MessageIn  != null; } }

        /// <summary>
        /// A Message for the OutMessage attribute may be entered. The sending of this Message marks
        /// the completion of the Task, which may cause the production of an OutputSet. One OR more
        /// corresponding outgoing Message Flows MAY be shown on the diagram. However, the display of
        /// the Message Flow is not required. The Message is applied To All outgoing Message Flows AND
        /// the Message will be sent down All outgoing Message Flows at the completion of a single 
        /// instance of the Task. See section 7.9.4.
        /// </summary>
        [XmlElement("MessageOut")]
        public Message MessageOut { get; set; }
		[XmlIgnore]
		public bool MessageOutSpecified { get { return MessageOut  != null; } }

        /// <summary>
        /// Describes the web services operation To be used by this task. See section 7.9.6.
        /// </summary>
        [XmlElement("WebServiceOperation")]
        public WebServiceOperation WebServiceOperation{ get; set; }
		[XmlIgnore]
		public bool WebServiceOperationSpecified { get { return WebServiceOperation != null; } }

        /// <summary>
        /// WebService | Other | Unspecified
        /// </summary>
        [XmlAttribute("Implementation")]
        [DefaultValue(ImplementationEnum.WebService)]
        public ImplementationEnum Implementation { get; set; }
        //[XmlIgnore]
        //public bool ImplementationSpecified { get { return Implementation != null; } }



        public TaskUser()
        {
            Implementation = ImplementationEnum.WebService;
        }
		
        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            TaskUser value = obj as TaskUser;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Implementation, this.MessageIn, this.MessageOut, this.WebServiceOperation
                };

                List<object> listB = new List<object>
                {
                    value.Implementation, value.MessageIn, value.MessageOut, value.WebServiceOperation
                };

                if (!Utilities.IsListEqual<Performer>(this.Performers, value.Performers))
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