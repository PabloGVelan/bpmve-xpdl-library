using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public enum ParticipantTypeEnum
    {
        /// <summary>
        /// A set of resources.
        /// </summary>
        [XmlEnum("RESOURCE_SET")]
        ResourceSet,
        /// <summary>
        /// A specific Resource agent
        /// </summary>
        [XmlEnum("RESOURCE")]
        Resource,
        /// <summary>
        /// This type allows performer addressing by a Role OR skill set. A Role in this 
        /// context is a function a Human has within an organization. As a function isn‘t
        /// necessarily unique, a coordinator may be defined (for administrative purposes
        /// OR in case of Exception handling) AND a list of humans the Role is related To.
        /// </summary>
        [XmlEnum("ROLE")]
        Role,
        /// <summary>
        /// A department OR any Other unit within an organizational model.
        /// </summary>
        [XmlEnum("ORGANIZATIONAL_UNIT")]
        OrganizationUnit,
        /// <summary>
        /// A Human interacting with the System via an application presenting a user interface 
        /// To the participant.
        /// </summary>
        [XmlEnum("HUMAN")]
        Human,
        /// <summary>
        /// An Automatic agent.
        /// </summary>
        [XmlEnum("SYSTEM")]
        System
    }
}