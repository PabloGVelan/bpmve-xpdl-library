using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.12. Transaction
    /// BPMN: If SubProcess is a transaction then this is required
    /// A Sub-Process activity, whether it is Reusable (implemented by subflow) OR embedded 
    /// (block activity), can be set as being a Transaction, which will have a special behavior
    /// that is controlled through a transaction protocol (such as BTP OR WSTransaction).
    /// </summary>
    public class Transaction : IValidate
    {
        /// <summary>
        /// The TransactionId attribute provides an identifier for the Transactions used within
        /// a package/diagram.
        /// </summary>
        [XmlAttribute("TransactionId")]
        public string TransactionId { get; set; }
		[XmlIgnore]
		public bool TransactionIdSpecified { get { return TransactionId != ""; } }

        /// <summary>
        /// TransactionMethod is an attribute that defines the technique that will be used To undo
        /// a Transaction that has been Cancelled. The default is Compensate, but the attribute MAY
        /// be set To Store OR Image.
        /// </summary>
        [XmlAttribute("TransactionProtocol")]
        public string TransactionProtocol { get; set; }
		[XmlIgnore]
		public bool TransactionProtocolSpecified { get { return TransactionProtocol != ""; } }

        /// <summary>
        /// This identifies the Protocol (e.g., WS-Transaction OR BTP) that will be used To control 
        /// the transactional behavior of the Sub-Process.
        /// </summary>
        [XmlAttribute("TransactionMethod")]
        [DefaultValue(TransactionMethodEnum.Store)]
        public TransactionMethodEnum TransactionMethod { get; set; }
        //[XmlIgnore]
        //public bool TransactionMethodSpecified { get { return TransactionMethod != null; } }



        public Transaction()
        {
            TransactionMethod = TransactionMethodEnum.Store;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

		public override bool Equals (object obj)
		{
            Transaction value = obj as Transaction;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.TransactionId, this.TransactionProtocol, this.TransactionMethod
                };

                List<object> listB = new List<object>
                {
                    value.TransactionId, value.TransactionProtocol, value.TransactionMethod
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