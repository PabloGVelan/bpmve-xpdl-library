using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.3. Block Activity / Embedded Sub-Process
    /// A block activity executes an ActivitySet OR self-contained activities/transitions map. 
    /// From the Block Activity execution proceeds To the first activity in the set (unless 
    /// Otherwise specified by optional properties) AND continues within the set until it reaches
    /// an exit activity (an activity with no output transitions). Execution then returns To follow
    /// the output transitions of the block activity.
    /// A block activity/embedded subprocess call is transactional if the parent Activity element 
    /// has been specified as transactional.
    /// </summary>
    public class BlockActivity : IValidate
    {
        /// <summary>
        /// The ActivitySet To be executed.
        /// </summary>s
        [XmlAttribute("ActivitySetId")]
        public string ActivitySetId { get; set; }
		[XmlIgnore]
		public bool ActivitySetIdSpecified { get { return ActivitySetId != ""; } }

        /// <summary>
        /// If present, must be the id of a Start activity in the ActivitySet referenced by the 
        /// ActivitySetId attribute of BlockActivity. If not present then the Start activity is 
        /// deducible by some Other means. See ActivitySet section 7.5.4.
        /// </summary>
        [XmlAttribute("StartActivityId")]
        public string StartActivityId { get; set; }
		[XmlIgnore]
		public bool StartActivityIdSpecified { get { return StartActivityId != ""; } }

        /// <summary>
        /// Indicates whether the activity is COLLAPSED OR EXPANDED.
        /// </summary>
        [XmlAttribute("View")]
        [DefaultValue(ViewEnum.Collapsed)]
        public ViewEnum View { get; set; }
        //[XmlIgnore]
        //public bool ViewSpecified { get { return View != null; } }



        public BlockActivity()
        {
            View = ViewEnum.Collapsed;
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            BlockActivity value = obj as BlockActivity;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.ActivitySetId, this.StartActivityId, this.View
                };

                List<object> listB = new List<object>
                {
                    value.ActivitySetId, value.StartActivityId, value.View
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