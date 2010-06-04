using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.6.1. Execution Control Attributes
    /// These are attributes of an Activity that allow the definition of various activity-specific 
    /// features for Activity execution control. Refer To the Table for Process Activity.
    /// Automation mode defines the degree of automation when triggering AND terminating an 
    /// activity. There are two automation modes:
    /// </summary>
    public enum StartAndFinishModeEnum
    {
        /// <summary>
        /// fully controlled by the process OR workflow engine, i.e. the engine proceeds with 
        /// execution of the activity within the process automatically, as soon as any incoming 
        /// transition conditions are satisfied.
        /// Similarly, completion of the activity AND progression To any post activity Conditional
        /// logic occurs automatically on termination of the final invoked application.
        /// </summary>
        [XmlEnum("Automatic")]
        Automatic,
        /// <summary>
        /// requires explicit user interaction To cause activity Start OR finish. In such systems 
        /// the activity Start AND/OR completion is as a result of explicit user action.
        /// </summary>
        [XmlEnum("Manual")]
        Manual
    }
}