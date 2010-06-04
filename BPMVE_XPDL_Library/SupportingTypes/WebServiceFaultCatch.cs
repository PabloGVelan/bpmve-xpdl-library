using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class WebServiceFaultCatch : IValidate
    {
        [XmlElement("Message")]
        public Message Message { get; set; }
		[XmlIgnore]
		public bool MessageSpecified { get { return Message != null; } }

        [XmlElement("BlockActivity")]
        public BlockActivity BlockActivity { get; set; }
		[XmlIgnore]
		public bool BlockActivitySpecified { get { return BlockActivity != null; } }

        [XmlElement("TransitionRef")]
        public TransitionRef TransitionRef { get; set; }
		[XmlIgnore]
		public bool TransitionRefSpecified { get { return TransitionRef != null; } }

        [XmlAttribute("FaultName")]
        public string FaultName { get; set; }
		[XmlIgnore]
		public bool FaultNameSpecified { get { return FaultName != ""; } }



        public WebServiceFaultCatch()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            WebServiceFaultCatch value = obj as WebServiceFaultCatch;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Message, this.BlockActivity, this.TransitionRef, this.FaultName
                };

                List<object> listB = new List<object>
                {
                    value.Message, value.BlockActivity, value.TransitionRef, value.FaultName
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