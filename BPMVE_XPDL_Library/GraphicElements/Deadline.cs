using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;
using System.Text;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// Deadlines are used To raise an Exception upon the expiration of a specific period of time.
    /// Note that BPMN provides the Timer Event as a general method for handling Deadlines. 
    /// See sction 7.6.4.5.11.
    /// Upon the arrival of a deadline, an Exception Condition is raised AND the appropriate Exception 
    /// transitions are followed. If the deadline is synchronous, then the activity is terminated 
    /// Before flow continues on the Exception path. If the deadline is asynchronous, then an implicit
    /// AND SPLIT is performed, AND a new thread of processing is started on the appropriate Exception 
    /// transition. Asynchronous exceptions can cause side effects, AND should be used carefully. Some 
    /// of these side effects are discussed later in this section.
    /// </summary>
    public class Deadline : IValidate
    {
        /// <summary>
        /// An expression indicating the time of the deadline. This expression is implementation 
        /// dependent AND may include at least:
        /// Times relative To the beginning of the activity. (2 days)
        /// Fixed times (January 1) OR (January 1, 2002)
        /// Times computed using relevant Data Standard (varName days)
        /// </summary>
        [XmlElement("DeadlineDuration")]
        public Expression DeadlineDuration { get; set; }
		[XmlIgnore]
		public bool DeadlineDurationSpecified { get { return DeadlineDuration != null; } }

        /// <summary>
        /// The name of the Exception To be raised on arrival of the deadline.
        /// This name should match that specified in
        /// Transition/Condition/Expression
        /// </summary>
        [XmlElement("ExceptionName")]
        public string ExceptionName { get; set; }
		[XmlIgnore]
		public bool ExceptionNameSpecified { get { return ExceptionName != ""; } }

        /// <summary>
        /// Define the System behaviour on raising the arrival of the deadline
        /// ASYNCHR - The deadline is To be raised asynchronously. This is an implicit AND SPLIT 
        /// operation, where the activity continues AND another thread is started following the 
        /// named Exception transition. Another deadline may occur on the same activity, because
        /// it continues running.
        /// SYNCHR - The activity is Completed abnormally AND flow continues on the named Exception transition.
        /// </summary>
        [XmlAttribute("Execution")]
        [DefaultValue(ExecutionSyncMode.Synchronous)]
        public ExecutionSyncMode Execution { get; set; }
        //[XmlIgnore]
        //public bool ExecutionSpecified { get { return Execution != null; } }



        public Deadline()
        {
            Execution = ExecutionSyncMode.Synchronous;
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Deadline value = obj as Deadline;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Execution, this.DeadlineDuration, this.ExceptionName
                };

                List<object> listB = new List<object>
                {
                    value.Execution, value.DeadlineDuration, value.ExceptionName
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