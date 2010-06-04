using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.2. Package Definition
    /// It is possible To define several processes within One package, which may share the same 
    /// tools AND participants. We recommend creating One package per business process which should 
    /// contain All the necessary processes as well as All the associated tools AND participants,
    /// although it is not required. It is also possible To define just parts of One process 
    /// definition OR common parts of several processes within One package (e.g. a participant 
    /// list OR an application list).
    /// The details of Package are All in PackageType. The xml included in Package checks for 
    /// referential integrity: it makes sure that elements that refer To Other elements using 
    /// id in fact refer To elements that exist.
    /// </summary>
    public class Package : IValidate
    {
        /// <summary>
        /// A set of elements specifying package characteristics.
        /// </summary>
        [XmlElement("PackageHeader")]
        public PackageHeader PackageHeader { get; set; }
        [XmlIgnore]
        public bool PackageHeaderSpecified { get { return PackageHeader != null; } }

        /// <summary>
        /// A set of elements AND attributes used by Both the Package AND Process definitions.
        /// </summary>
        [XmlElement("RedefinableHeader")]
        public RedefinableHeader RedefinableHeader { get; set; }
        [XmlIgnore]
        public bool RedefinableHeaderSpecified { get { return RedefinableHeader != null; } }

        /// <summary>
        /// Structural restriction on process definitions in this package. See section 7.2.3.
        /// </summary>
        [XmlElement("ConformanceClass")]
        public ConformanceClass ConformanceClass { get; set; }
        [XmlIgnore]
        public bool ConformanceClassSpecified { get { return ConformanceClass != null; } }

        /// <summary>
        /// Identifies the scripting language used in expressions.
        /// </summary>
        [XmlElement("Script")]
        public Script Script { get; set; }
        [XmlIgnore]
        public bool ScriptSpecified { get { return Script != null; } }

        /// <summary>
        /// Reference To another Package definition defined in a separate document.
        /// </summary>
        //[XmlElement("ExternalPackage")]
        [XmlArray("ExternalPackages")]
        public List<ExternalPackage> ExternalPackages { get; set; }
        [XmlIgnore]
        public bool ExternalPackagesSpecified { get { return ExternalPackages == null ? false : ExternalPackages.Count != 0; } }

        /// <summary>
        /// A list of Data Types used in the package. See section 7.13.
        /// </summary>
        //[XmlElement("TypeDeclarations")]
        [XmlArray("TypeDeclarations")]
        public List<TypeDeclaration> TypeDeclarations { get; set; }
        [XmlIgnore]
        public bool TypeDeclarationsSpecified { get { return TypeDeclarations == null ? false : TypeDeclarations.Count != 0; } }

        /// <summary>
        /// A list of resources used in implementing processes in the package. See section 7.11.
        /// </summary>
        //[XmlElement("Participants")]
        [XmlArray("Participants")]
        public List<Participant> Participants { get; set; }
        [XmlIgnore]
        public bool ParticipantsSpecified { get { return Participants == null ? false : Participants.Count != 0; } }

        /// <summary>
        /// A list of Application Declarations. See section 7.3.
        /// </summary>
        //[XmlElement("Applications")]
        [XmlArray("Applications")]
        public List<Application> Applications { get; set; }
        [XmlIgnore]
        public bool ApplicationsSpecified { get { return Applications == null ? false : Applications.Count != 0; } }

        /// <summary>
        /// A list of Relevant Data fields defined for the package. See section 7.12.
        /// </summary>
        //[XmlElement("DataFields")]
        [XmlArray("DataFields")]
        public List<DataField> DataFields { get; set; }
        [XmlIgnore]
        public bool DataFieldsSpecified { get { return DataFields == null ? false : DataFields.Count != 0; } }

        /// <summary>
        /// Partner Link types for this package. See section 7.8.1.
        /// </summary>
        [XmlElement("PartnerLinkTypes")]
        public List<PartnerLinkType> PartnerLinkTypes { get; set; }
        [XmlIgnore]
        public bool PartnerLinkTypesSpecified { get { return PartnerLinkTypes == null ? false : PartnerLinkTypes.Count != 0; } }

        /// <summary>
        /// 
        /// </summary>
        //[XmlElement("Pages")]
        [XmlArray("Pages")]
        public List<Page> Pages { get; set; }
        [XmlIgnore]
        public bool PagesSpecified { get { return Pages == null ? false : Pages.Count != 0; } }

        /// <summary>
        /// A list of Pools for the Package. See section 7.4.
        /// </summary>
        //[XmlElement("Pools")]
        [XmlArray("Pools")]
        public List<Pool> Pools { get; set; }
        [XmlIgnore]
        public bool PoolsSpecified { get { return Pools == null ? false : Pools.Count != 0; } }

        /// <summary>
        /// A list of MessageFlows which go between Pools OR activities in two pools. See section 7.8.
        /// </summary>
        //[XmlElement("MessageFlows")]
        [XmlArray("MessageFlows")]
        public List<MessageFlow> MessageFlows { get; set; }
        [XmlIgnore]
        public bool MessageFlowsSpecified { get { return MessageFlows == null ? false : MessageFlows.Count != 0; } }

        /// <summary>
        /// A list of Associations which associate information AND Artifacts with Flow Objects.
        /// See section 7.10.
        /// </summary>
        //[XmlElement("Associations")]
        [XmlArray("Associations")]
        public List<Association> Associations { get; set; }
        [XmlIgnore]
        public bool AssociationsSpecified { get { return Associations == null ? false : Associations.Count != 0; } }

        /// <summary>
        /// A list of Artifacts that can be linked To the existing Flow Objects through 
        /// Associations. See sections 6.4.7. AND 7.1.9.
        /// </summary>
        //[XmlElement("Artifacts")]
        [XmlArray("Artifacts")]
        public List<Artifact> Artifacts { get; set; }
        [XmlIgnore]
        public bool ArtifactsSpecified { get { return Artifacts == null ? false : Artifacts.Count != 0; } }

        /// <summary>
        /// A list of the Processes that comprise this package. See section 7.5.
        /// </summary>
        //[XmlElement("WorkflowProcesses")]
        [XmlArray("WorkflowProcesses")]
        public List<WorkflowProcess> Processes { get; set; }
        [XmlIgnore]
        public bool ProcessesSpecified { get { return Processes == null ? false : Processes.Count != 0; } }

        /// <summary>
        /// A list of vendor-defined extensions that may be added To the package. See section 7.1.1.
        /// </summary>
        //[XmlElement("ExtendedAttributes")]
        [XmlArray("ExtendedAttributes")]
        public List<ExtendedAttribute> ExtendedAttributes { get; set; }
        [XmlIgnore]
        public bool ExtendedAttributesSpecified { get { return ExtendedAttributes == null ? false : ExtendedAttributes.Count != 0; } }

        /// <summary>
        /// Used To identify the package.
        /// </summary>
        [XmlAttribute("Id")]
        public string Id { get; set; }

        /// <summary>
        /// Text. Used To identify the package.
        /// </summary>
        [XmlAttribute("Name")]
        public string Name { get; set; }
        [XmlIgnore]
        public bool NameSpecified { get { return !string.IsNullOrEmpty(Name); } }

        /// <summary>
        /// This holds the code for the language in which text is written as specified by ISO 639-2. 
        /// Optionally this may be suffixed with a country code as specified by ISO 3166 To permit 
        /// distinction between national dialects of the given language. The default is  ̳en_US‘.
        /// </summary>
        [XmlAttribute("Language")]
        public string Language { get; set; }
		[XmlIgnore]
		public bool LanguageSpecified { get { return !string.IsNullOrEmpty(Language); } }        

        /// <summary>
        /// A Language MAY be provided so that the syntax of queries used in the Diagram can be 
        /// understood. [Editors Note: Is this different than Scripting Language? TBD by BPMN.]
        /// </summary>
        [XmlAttribute("QueryLanguage")]
        public string QueryLanguage { get; set; }
		[XmlIgnore]
		public bool QueryLanguageSpecified { get { return !string.IsNullOrEmpty(QueryLanguage); } }

       

        public Package()
        {
        }

		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Package value = obj as Package;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.ConformanceClass, this.Id, this.Language, this.Name, this.PackageHeader,
					this.QueryLanguage, this.RedefinableHeader, this.Script
                };

                List<object> listB = new List<object>
                {
                    value.ConformanceClass, value.Id, value.Language, value.Name, value.PackageHeader,
					value.QueryLanguage, value.RedefinableHeader, value.Script
                };

                #region Debug_Code

                //if (!Utilities.IsListEqual<Application>(this.Applications, value.Applications))
                //    return false;
                
                //if (!Utilities.IsListEqual<Artifact>(this.Artifacts, value.Artifacts))
                //    return false;
                
                //if (!Utilities.IsListEqual<Association>(this.Associations, value.Associations))
                //    return false;
                
                //if (!Utilities.IsListEqual<DataField>(this.DataFields, value.DataFields))
                //    return false;
                
                //if (!Utilities.IsListEqual<ExtendedAttribute>(this.ExtendedAttributes, value.ExtendedAttributes))
                //    return false;
                
                //if (!Utilities.IsListEqual<MessageFlow>(this.MessageFlows, value.MessageFlows))
                //    return false;
                
                //if (!Utilities.IsListEqual<Page>(this.Pages, value.Pages))
                //    return false;
                
                //if (!Utilities.IsListEqual<Participant>(this.Participants, value.Participants))
                //    return false;
                
                //if (!Utilities.IsListEqual<PartnerLinkType>(this.PartnerLinkTypes, value.PartnerLinkTypes))
                //    return false;
                
                //if (!Utilities.IsListEqual<Pool>(this.Pools, value.Pools))
                //    return false;
                
                //if (!Utilities.IsListEqual<TypeDeclaration>(this.TypeDeclarations, value.TypeDeclarations))
                //    return false;
                
                //if (!Utilities.IsListEqual<WorkflowProcess>(this.Processes, value.Processes))
                //    return false;

                #endregion

                if (!Utilities.IsListEqual<Application>(this.Applications, value.Applications) ||
                    !Utilities.IsListEqual<Artifact>(this.Artifacts, value.Artifacts) ||
                    !Utilities.IsListEqual<Association>(this.Associations, value.Associations) ||
                    !Utilities.IsListEqual<DataField>(this.DataFields, value.DataFields) ||
                    !Utilities.IsListEqual<ExtendedAttribute>(this.ExtendedAttributes, value.ExtendedAttributes) ||
                    !Utilities.IsListEqual<ExternalPackage>(this.ExternalPackages, value.ExternalPackages) ||
                    !Utilities.IsListEqual<MessageFlow>(this.MessageFlows, value.MessageFlows) ||
                    !Utilities.IsListEqual<Page>(this.Pages, value.Pages) ||
                    !Utilities.IsListEqual<Participant>(this.Participants, value.Participants) ||
                    !Utilities.IsListEqual<PartnerLinkType>(this.PartnerLinkTypes, value.PartnerLinkTypes) ||
                    !Utilities.IsListEqual<Pool>(this.Pools, value.Pools) ||
                    !Utilities.IsListEqual<TypeDeclaration>(this.TypeDeclarations, value.TypeDeclarations) ||
                    !Utilities.IsListEqual<WorkflowProcess>(this.Processes, value.Processes))
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