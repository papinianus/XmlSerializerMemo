using System.Collections.Generic;
using System.Linq;

namespace XmlSerializerMemo
{
    [System.Xml.Serialization.XmlRoot("persons")]
    public class Persons
    {
        /// <summary>
        /// Person
        /// </summary>
        [System.Xml.Serialization.XmlElement("person")]
        public List<Person> Members { get; set; }

        /// <summary>
        /// description
        /// </summary>
        /// <returns> string </returns>
        [System.Xml.Serialization.XmlElement("description")]
        public string Description { get; set; }

        public override string ToString() => $"{Description}{System.Environment.NewLine}{string.Join(System.Environment.NewLine,Members.Select(e=>e.ToString()))}";
    }
}