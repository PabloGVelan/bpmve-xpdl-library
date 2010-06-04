using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class Event : IValidate
    {
        [XmlElement("StartEvent")]
        public StartEvent StartEvent { get; set; }
		[XmlIgnore]
		public bool StartEventSpecified { get { return StartEvent != null; } }

        [XmlElement("EndEvent")]
        public EndEvent EndEvent { get; set; }
		[XmlIgnore]
		public bool EndEventSpecified { get { return EndEvent != null; } }

        [XmlElement("IntermediateEvent")]
        public IntermediateEvent IntermediateEvent { get; set; }
		[XmlIgnore]
		public bool IntermediateEventSpecified { get { return IntermediateEvent != null; } }



        public Event()
        {
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Event value = obj as Event;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.StartEvent, this.EndEvent, this.IntermediateEvent
                };

                List<object> listB = new List<object>
                {
                    value.StartEvent, value.EndEvent, value.IntermediateEvent
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