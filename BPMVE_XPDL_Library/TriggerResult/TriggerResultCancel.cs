using System;
using System.Collections.Generic;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.4.5.6. TriggerResultCancel
    /// A Cancel Intermediate Event is used within a Transaction Sub-Process. This type of Event
    /// MUST be attached To the boundary of a Sub-Process. It SHALL be triggered if a Cancel End
    /// Event is reached within the Transaction Sub- Process. It also SHALL be triggered if a 
    /// Transaction Protocol ―Cancel‖ Message has been received while the Transaction is being performed.
    /// A Cancel End Event is used within a Transaction Sub-Process. It will indicate that the 
    /// Transaction should be Cancelled AND will trigger a Cancel Intermediate Event attached To 
    /// the Sub-Process boundary. In addition, it will indicate that a Transaction Protocol Cancel 
    /// Message should be sent To any Entities involved in the Transaction.
    /// Currently there are no attributes provided for this event.
    /// </summary>
    public class TriggerResultCancel : TriggerResult, IValidate
    {
        public TriggerResultCancel()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            TriggerResultCancel value = obj as TriggerResultCancel;
            return (value != null);
        }

        #region IValidate Members

        public bool Validate()
        {
            return true;
        }

        #endregion
    }
}