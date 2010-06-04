using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.5.3.8.TaskScript A Task Type of Script MUST NOT have an incoming OR an outgoing Message Flow.
    /// A Script Task is executed by a business process engine. The modeler OR implementer defines a 
    /// script in a language that the engine can interpret. When the Task is Ready To Start, the engine
    /// will execute the script. When the script is Completed, the Task will also be Completed.
    /// </summary>
    public class TaskScript : IValidate
    {
        /// <summary>
        /// The modeler MAY include a script that can be run when the Task is performed. 
        /// If a script is not included, then the Task will act equivalent To a TaskType of None.
        /// </summary>
        [XmlElement("Script")]
        public Expression Script { get; set; }
		[XmlIgnore]
		public bool ScriptSpecified { get { return Script != null; } }



        public TaskScript()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            TaskScript value = obj as TaskScript;
            if (value != null)
            {
                if (this.Script != null && value.Script != null)
                    return this.Script.Equals(value.Script);
                else if (this.Script == null && value.Script == null)
                    return true;
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