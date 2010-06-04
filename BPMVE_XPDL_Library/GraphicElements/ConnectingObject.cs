using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public abstract class ConnectingObject : GraphicalObject, IValidate
    {
        /// <summary>
        /// See section 7.1.2.4.
        /// </summary>
        [XmlArray("ConnectorGraphicsInfos")]
        public abstract List<ConnectorGraphicsInfo> ConnectorGraphicsInfos { get; set; }
        [XmlIgnore]
        public abstract bool ConnectorGraphicsInfosSpecified { get; }

        /// <summary>
        /// Used To identify the ConnectingObject.
        /// </summary>
        [XmlAttribute("Id")]
        public abstract override string Id { get; set; }

        /// <summary>
        /// Name of the ConnectingObject.
        /// </summary>
        [XmlAttribute("Name")]
        public abstract override string Name { get; set; }
        [XmlIgnore]
        public abstract override bool NameSpecified { get; }

        /// <summary>
        /// See section 7.1.9.4.
        /// </summary>
        [XmlElement("Object")]
        public abstract override Object_XPDL Object { get; set; }
        [XmlIgnore]
        public abstract override bool ObjectSpecified { get; }

        #region IValidate Members

        public abstract bool Validate();

        #endregion
    }
}