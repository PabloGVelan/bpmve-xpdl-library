using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.2.3. Conformance Class
    /// The conformance class declaration allows description of the conformance class To which the
    /// definitions in the model definition are restricted. The specified class applies To All the 
    /// contained process definitions, unless it is re-defined locally at the process definition 
    /// level.
    /// There are two independent categories defined for conformance: Graph Conformance AND BPMN 
    /// Model Portability conformance.
    /// </summary>
    public class ConformanceClass : IValidate
    {
        [XmlAttribute("BPMNModelPortabilityConformance")]
        [DefaultValue(BPMNConformanceEnum.None)]
        public BPMNConformanceEnum BPMNModelPortabilityConformance { get; set; }
        //[XmlIgnore]
        //public bool BPMNModelPortabilityConformanceSpecified
        //{
        //    get { return BPMNModelPortabilityConformance != null; }
        //}

        [XmlAttribute("GraphConformance")]
        [DefaultValue(GraphConformanceEnum.NonBlocked)]
        public GraphConformanceEnum GraphConformance { get; set; }
        //[XmlIgnore]
        //public bool GraphConformanceSpecified { get { return GraphConformance != null; } }



        public ConformanceClass()
        {
            BPMNModelPortabilityConformance = BPMNConformanceEnum.None;
            GraphConformance = GraphConformanceEnum.NonBlocked;
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            ConformanceClass value = obj as ConformanceClass;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.BPMNModelPortabilityConformance, this.GraphConformance
                };

                List<object> listB = new List<object>
                {
                    value.BPMNModelPortabilityConformance, value.GraphConformance
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