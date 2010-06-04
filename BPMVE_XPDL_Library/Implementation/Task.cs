using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class Task : IValidate
    {
        [XmlElement("TaskService")]
        public TaskService TaskService { get; set; }
        [XmlIgnore]
        public bool TaskServiceSpecified { get { return TaskService != null; } }

        [XmlElement("TaskReceive")]
        public TaskReceive TaskReceive { get; set; }
        [XmlIgnore]
        public bool TaskReceiveSpecified { get { return TaskReceive != null; } }

        [XmlElement("TaskManual")]
        public TaskManual TaskManual { get; set; }
        [XmlIgnore]
        public bool TaskManualSpecified { get { return TaskManual != null; } }

        [XmlElement("TaskReference")]
        public TaskReference TaskReference { get; set; }
		[XmlIgnore]
		public bool TaskReferenceSpecified { get { return TaskReference != null; } }

        [XmlElement("TaskScript")]
        public TaskScript TaskScript { get; set; }
		[XmlIgnore]
		public bool TaskScriptSpecified { get { return TaskScript != null; } }

        [XmlElement("TaskSend")]
        public TaskSend TaskSend { get; set; }
        [XmlIgnore]
        public bool TaskSendSpecified { get { return TaskSend != null; } }

        [XmlElement("TaskUser")]
        public TaskUser TaskUser { get; set; }
		[XmlIgnore]
		public bool TaskUserSpecified { get { return TaskUser != null; } }

        [XmlElement("TaskApplication")]
        public TaskApplication TaskApplication { get; set; }
        [XmlIgnore]
        public bool TaskApplicationSpecified { get { return TaskApplication != null; } }



        public Task()
        {
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Task value = obj as Task;
            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.TaskReference, this.TaskScript, this.TaskManual, this.TaskApplication,
					this.TaskSend, this.TaskService, this.TaskUser, this.TaskReceive
                };

                List<object> listB = new List<object>
                {
                    value.TaskReference, value.TaskScript, value.TaskManual, value.TaskApplication,
					value.TaskSend, value.TaskService, value.TaskUser, value.TaskReceive
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