using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.13. Loop
    /// The attributes of Tasks AND Sub-Processes will determine if they are repeated OR performed
    /// once. There are two types of loops: Standard AND Multi-Instance.
    /// Subtyped: LoopStandard, LoopMultiInstance
    /// </summary>
    public class Loop : IValidate
    {
        [XmlAttribute("LoopType")]
        [DefaultValue(LoopTypeEnum.Standard)]
        public LoopTypeEnum LoopType { get; set; }
        //[XmlIgnore]
        //public bool LoopTypeSpecified { get { return LoopType != null; } }

        [XmlElement("LoopMultiInstance")]
        public LoopMultiInstance LoopMultiInstance { get; set; }
		[XmlIgnore]
		public bool LoopMultiInstanceSpecified { get { return LoopMultiInstance != null; } }

        [XmlElement("LoopStandard")]
        public LoopStandard LoopStandard { get; set; }
		[XmlIgnore]
		public bool LoopStandardSpecified { get { return LoopStandard != null; } }



        public Loop()
        {
            LoopType = LoopTypeEnum.Standard;
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Loop value = obj as Loop;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.LoopType, this.LoopMultiInstance, this.LoopStandard
                };

                List<object> listB = new List<object>
                {
                    value.LoopType, value.LoopMultiInstance, value.LoopStandard
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