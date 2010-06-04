using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.4.5.2. ResultError
    /// This is used for Error handling--Both To set (throw) AND To react To (catch) errors. 
    /// It sets (throws) an Error if the Event is part of a Normal Flow (either Intermediate
    /// OR End Event). It reacts To (catches) a named Error, OR To any Error if a name is not 
    /// specified, when attached To the boundary of an activity.
    /// For an End Event: If the Result is an Error, then the ErrorCode MUST be supplied. This
    /// ―throws‖ the Error. For an Intermediate Event within Normal Flow: If the Trigger is an 
    /// Error, then the ErrorCode MUST be entered. This ―throws‖ the Error.
    /// For an Intermediate Event attached To the boundary of an Activity: If the Trigger is an
    /// Error, then the ErrorCode MAY be entered. This Event ―catches‖ the Error. If there is no
    /// ErrorCode, then any Error SHALL trigger the Event. If there is an ErrorCode, then only 
    /// an Error that matches the ErrorCode SHALL trigger the Event.
    /// </summary>
    public class ResultError : TriggerResult, IValidate
    {
        /// <summary>
        /// String designates the Error Code.
        /// </summary>
        [XmlAttribute("ErrorCode")]
        public string ErrorCode { get; set; }
		[XmlIgnore]
		public bool ErrorCodeSpecified { get { return ErrorCode != ""; } }



        public ResultError()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            ResultError value = obj as ResultError;
            if (value != null)
            {
                if (this.ErrorCode != null &&
                    value.ErrorCode != null)
                    return (value.ErrorCode == this.ErrorCode);
            }

            return false;
        }

        #region IValidate Members

        public bool Validate()
        {
            return true;
        }

        #endregion
    }
}