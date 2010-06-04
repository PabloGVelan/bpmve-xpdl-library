using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    /// <summary>
    /// 7.1.9.6. Group
    /// The Group object is an Artifact that provides a visual mechanism To group elements of a 
    /// diagram informally. The grouping is tied To the Category supporting element (which is an
    /// attribute of All BPMN elements). That is, a Group is a visual depiction of a single Category. 
    /// The graphical elements within the Group will be assigned the Category of the Group. 
    /// (Note -- Categories can be highlighted through Other mechanisms, such as color, as defined 
    /// by a modeler OR a modeling tool).
    /// As an Artifact, a Group is not an activity OR any Flow Object, AND, therefore, cannot connect
    /// To Sequence Flow OR Message Flow. In addition, Groups are not constrained by restrictions 
    /// of Pools AND Lanes. This means that a Group can stretch across the boundaries of a Pool To 
    /// surround Diagram elements (see Figure below), often To identify activities that exist within
    /// a distributed business-To-business transaction.
    /// Groups are often used To highlight certain sections of a Diagram without adding additional 
    /// constraints for performance-- as a Sub-Process would. The highlighted (grouped) section of 
    /// the Diagram can be separated for reporting AND analysis purposes. Groups do not affect the 
    /// flow of the Process.
    /// </summary>
    public class Group : IValidate
    {
        /// <summary>
        /// Category specifies the Category that the Group represents (Further details about the 
        /// definition of a Category can be found in section 7.1.8). The name of the Category 
        /// provides the label for the Group. The graphical elements within the boundaries of 
        /// the Group will be assigned the Category.
        /// </summary>
        [XmlElement("Category")]
        public Category Category { get; set; }
		[XmlIgnore]
		public bool CategorySpecified { get { return Category != null; } }

        /// <summary>
        /// A list of the IDs of All the Objects in the Group.
        /// </summary>
        [XmlElement("Object")]
        public List<Object_XPDL> Objects { get; set; }
		[XmlIgnore]
		public bool ObjectsSpecified { get { return Objects == null ? false : Objects.Count != 0; } }

        [XmlAttribute("Id")]
        public string Id { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }
		[XmlIgnore]
		public bool NameSpecified { get { return Name != ""; } }



        public Group()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Group value = obj as Group;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Category, this.Id, this.Name
                };

                List<object> listB = new List<object>
                {
                    value.Category, value.Id, value.Name
                };

                if (!Utilities.IsListEqual<Object_XPDL>(this.Objects, value.Objects))
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