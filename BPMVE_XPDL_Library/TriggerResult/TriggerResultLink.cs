using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.4.5.4. TriggerResultLink
    /// For an Intermediate Event: Table 48: Event Result Multiple Description
    /// List of All applicable result elements.
    /// Paired Intermediate Events can be used as ―Go To‖ objects within a Process.
    /// For All Event Types: The Name MUST be entered.
    /// </summary>
    public class TriggerResultLink : TriggerResult, IValidate
    {
        [XmlAttribute("CatchThrow")]
        [DefaultValue(CatchThrowEnum.Catch)]
        public CatchThrowEnum CatchThrow { get; set; }
        //[XmlIgnore]
        //public bool CatchThrowSpecified { get { return CatchThrow != null; } }

        /// <summary>
        /// Unique name for this Link. The Link can only be used within One process 
        /// as a shorthand for a long sequence flow.
        /// </summary>
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlIgnore]
        public bool NameSpecified { get { return Name != ""; } }



        public TriggerResultLink()
        {
            CatchThrow = CatchThrowEnum.Catch;
        }
        
        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            TriggerResultLink value = obj as TriggerResultLink;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Name, this.CatchThrow
                };

                List<object> listB = new List<object>
                {
                    value.Name, value.CatchThrow
                };

                return (Utilities.IsEqual(listA, listB));
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