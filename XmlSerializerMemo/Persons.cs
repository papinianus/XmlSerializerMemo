using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using static System.Environment;

namespace XmlSerializerMemo
{
    [XmlRoot("persons")]
    public class Persons
    {
        /// <summary>
        /// Person
        /// </summary>
        [XmlElement("person")]
        public List<Person> Members { get; set; }

        /// <summary>
        /// description
        /// </summary>
        /// <returns> string </returns>
        [XmlElement("description")]
        public string Description { get; set; }

        public override string ToString() => $"{Description}{NewLine}{string.Join(NewLine,Members.Select(e=>e.ToString()))}";
    }
}