using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.2. Route Activity
    /// The Route Activity is a ―dummy‖ Activity that permits the explicit expression of the behavior
    /// of diverging (split) OR converging (join) sequence flow (in BPMN, the split AND join behavior
    /// for non-gateway activities is always the same: joins are always Exclusive AND splits are always
    /// Inclusive).
    /// </summary>
    public class Route
    {
        /// <summary>
        /// Specifies the split / join behavior of his gateway activity.
        /// Note that the enumerations XOR, OR AND AND are deprecated AND replaced by the new
        /// enumerations Exclusive, Inclusive AND Parallel respectively. It is recommended that
        /// modellers are capable of reading deprecated values but always write the new enumerations.
        /// When used for BPMN gateways, the GatewayType MUST be specified.
        /// </summary>
        [XmlAttribute("GatewayType")]
        [DefaultValue(GatewayTypeEnum.Exclusive)]
        public GatewayTypeEnum GatewayType { get; set; }
        //[XmlIgnore]
        //public bool GatewayTypeSpecified { get { return GatewayType != null; } }

        /// <summary>
        /// For BPMN ―Exclusive‖ gateways this attribute MAY be specified when the GatewayType is 
        /// specified as ―Exclusive‖, this attribute is used To specify whether the gateway is an 
        /// Exclusive Data-Based gateway (default) OR an Exclusive Event-Based gateway.
        /// For Other gateway types, this attribute MUST NOT be specified.
        /// </summary>
        [XmlAttribute("ExclusiveType")]
        [DefaultValue(ExclusiveTypeEnum.Data)]
        public ExclusiveTypeEnum ExclusiveType { get; set; }
        //[XmlIgnore]
        //public bool ExclusiveTypeSpecified { get { return ExclusiveType != null; } }

        /// <summary>
        /// Exclusive Event-Based Gateways can be defined as the instantiation mechanism for the
        /// Process with the Instantiate attribute. This attribute MAY be set To true if the Gateway
        /// is the first element After the Start Event OR a starting Gateway if there is no 
        /// Start Event (i.e., there are no incoming Sequence Flow).
        /// </summary>
        [XmlAttribute("Instantiate")]
        [DefaultValue(false)]
        public bool IsInstantiate { get; set; }
        //[XmlIgnore]
        //public bool IsInstantiateSpecified { get { return IsInstantiate != null; } }

        /// <summary>
        /// This attribute determines if the XOR Marker is displayed in the center of the Gateway
        /// Diamond (an ―X‖). The marker is displayed if the attribute is True AND it is not displayed
        /// if the attribute is False. By default, the marker is not displayed.
        /// </summary>
        [XmlAttribute("MarkerVisible")]
        [DefaultValue(false)]
        public bool IsMarkerVisible { get; set; }
        //[XmlIgnore]
        //public bool IsMarkerVisibleSpecified { get { return IsMarkerVisible != null; } }

        /// <summary>
        /// For a Complex Gateway, if there are Multiple incoming Sequence Flow, an IncomingCondition 
        /// expression MUST be set by the modeler. This will consist of an expression that can reference
        /// Sequence Flow names AND/OR Process Properties (Data).
        /// </summary>
        [XmlAttribute("IncomingCondition")]
        public string IncomingCondiiton { get; set; }
		[XmlIgnore]
		public bool IncomingCondiitonSpecified { get { return IncomingCondiiton != ""; } }

        /// <summary>
        /// For a Complex Gateway, if there are Multiple outgoing Sequence Flow, an OutgoingCondition
        /// expression MUST be set by the modeler. This will consist of an expression that can 
        /// reference (outgoing) Sequence Flow Ids AND/OR Process Properties (Data).
        /// </summary>
        [XmlAttribute("OutgoingCondition")]
        public string OutgoingCondition { get; set; }
		[XmlIgnore]
		public bool OutgoingConditionSpecified { get { return OutgoingCondition != ""; } }



        public Route()
        {
            GatewayType = GatewayTypeEnum.Exclusive;
            ExclusiveType = ExclusiveTypeEnum.Data;
            IsInstantiate = false;
            IsMarkerVisible = false;
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Route value = obj as Route;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.GatewayType, this.ExclusiveType, this.IsInstantiate,
                    this.IsMarkerVisible, this.IncomingCondiiton, this.OutgoingCondition
                };

                List<object> listB = new List<object>
                {
                    value.GatewayType, value.ExclusiveType, value.IsInstantiate,
                    value.IsMarkerVisible, value.IncomingCondiiton, value.OutgoingCondition
                };

                return (Utilities.IsEqual(listA, listB));
            }

            return false;
        }
    }
}