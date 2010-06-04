using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Serialization;
using System.ComponentModel;

namespace BPMVE_XPDL_Library
{
    public class Object_XPDL : IValidate
    {
        [XmlArray("Categories")]
        public List<Category> Categories { get; set; }
		[XmlIgnore]
		public bool CategoriesSpecified 
        {
            get { return Categories == null ? false : Categories.Count != 0; } 
        }

        [XmlElement("Documentation")]
        public Documentation Documentation { get; set; }
		[XmlIgnore]
		public bool DocumentationSpecified { get { return Documentation != null; } }

        [XmlAttribute("Id")]
        public string Id { get; set; }

        [XmlAttribute("Name")]
        public string Name { get; set; }
		[XmlIgnore]
		public bool NameSpecified { get { return Name != ""; } }



        public Object_XPDL()
        {
        }

        public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		public override bool Equals(object obj)
        {
            Object_XPDL value = obj as Object_XPDL;

            if (value != null)
            {
                List<object> listA = new List<object>
                {
                    this.Documentation, this.Id, this.Name
                };

                List<object> listB = new List<object>
                {
                    value.Documentation, value.Id, value.Name
                };

                if (!Utilities.IsListEqual<Category>(this.Categories, value.Categories))
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
