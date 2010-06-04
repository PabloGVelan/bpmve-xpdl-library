using System;

using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.5.4. Activity Set
    /// An activity set is a self-contained set of activities AND transitions. Transitions in the set 
    /// should refer only To activities in the same set AND there should be no transitions into 
    /// OR out of the set. Activity sets can be executed by block activities (see section 7.6.3). 
    /// An Activity Set is re-usable; it may be referred To by more than One Block Activity.
    /// The xml at the End of ActivitySet, starting with keyname, ensures referential integrity.
    /// </summary>
    public class ActivitySet : IValidate
    {
        /// <summary>
        /// A list of activities that comprise the process. See section 7.6.
        /// </summary>
        [XmlArray("Activities")]
        public List<Activity> Activities { get; set; }
		[XmlIgnore]
		public bool ActivitiesSpecified { get { return Activities == null ? false : Activities.Count != 0; } }

        /// <summary>
        /// A list of the transitions that connect the process activities. See section 7.7.
        /// </summary>
        [XmlArray("Transactions")]
        public List<Transition> Transitions { get; set; }
        [XmlIgnore]
        public bool TransitionsSpecified { get { return Transitions == null ? false : Transitions.Count != 0; } }

        /// <summary>
        /// See section 7.1.9.4.
        /// </summary>
        [XmlElement("Object")]
        public Object_XPDL Object { get; set; }
        [XmlIgnore]
        public bool ObjectSpecified { get { return Object != null; } }

        /// <summary>
        /// Used To identify the process.
        /// </summary>
        [XmlAttribute("Id")]
        public string Id { get; set; }

        /// <summary>
        /// Name of the activity set/embedded sub-process.
        /// </summary>
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlIgnore]
        public bool NameSpecified { get { return Name != ""; } }

        /// <summary>
        /// See section 7.5.9.
        /// </summary>
        [XmlAttribute("AdHoc")]
        [DefaultValue(false)]
        public bool Adhoc { get; set; }
        //[XmlIgnore]
        //public bool AdhocSpecified { get { return Adhoc != null; } }

        /// <summary>
        /// See section 7.5.9.
        /// </summary>
        [XmlAttribute("AdHocOrdering")]
        [DefaultValue(OrderingEnum.Parallel)]
        public OrderingEnum AdhocOrdering { get; set; }
        //[XmlIgnore]
        //public bool AdhocOrderingSpecified { get { return AdhocOrdering != null; } }

        /// <summary>
        /// See section 7.5.9.
        /// </summary>
        [XmlAttribute("AdHocCompletionCondition")]
        public string AdhocCompletionCondition { get; set; }
		[XmlIgnore]
		public bool AdhocCompletionConditionSpecified { get { return AdhocCompletionCondition != ""; } }

        /// <summary>
        /// Unless Otherwise specified in the ActivitySet invocation (BlockActivity 7.6.3), this 
        /// is where the activity set will Start executing. If present, it must be the id of a 
        /// Start activity in the activity set. If not present it is assumed the activity set 
        /// contains exactly One Start activity.
        /// </summary>
        [XmlAttribute("DefaultStartActivityId")]
        public string DefaultStartActivityId { get; set; }
		[XmlIgnore]
		public bool DefaultStartActivityIdSpecified { get { return DefaultStartActivityId != ""; } }



        public ActivitySet()
        {
            Adhoc = false;
            AdhocOrdering = OrderingEnum.Parallel;
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            ActivitySet value = obj as ActivitySet;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Adhoc, this.AdhocOrdering, this.AdhocCompletionCondition, this.Id, 
					this.DefaultStartActivityId, this.Name, this.Object
                };

                List<object> listB = new List<object>
                {
                    value.Adhoc, value.AdhocOrdering, value.AdhocCompletionCondition, value.Id, 
					value.DefaultStartActivityId, value.Name, value.Object
                };

                if (!Utilities.IsListEqual<Activity>(this.Activities, value.Activities) ||
				    !Utilities.IsListEqual<Transition>(this.Transitions, value.Transitions))
                    return false;

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