using System;
using System.Xml.Serialization;

namespace XmlSerializerMemo
{
    public class Person
    {
        public enum Sex
        {
            [XmlEnum("Male")]
            Male,
            [XmlEnum("Female")]
            Female,
            [XmlEnum("Other")]
            Other
        }
        /// <summary>
        /// ID
        /// example for attribute, integer
        /// </summary>
        [XmlAttribute("id")]
        public int Id { get; set; }
        /// <summary>
        /// First Name
        /// </summary>
        [XmlElement("firstname")]
        public string FirstName { get; set; }
        /// <summary>
        /// Middle Name
        /// example for null and empty element
        /// </summary>
        [XmlElement("middlename")]
        public string MiddleName { get; set; }
        /// <summary>
        /// Last Name
        /// </summary>
        [XmlElement("lastname")]
        public string LastName { get; set; }
        /// <summary>
        /// Birth Day
        /// </summary>
        [XmlElement("birthday")]
        public DateTime Birthday { get; set; }
        /// <summary>
        /// Address
        /// private won't be serialized
        /// </summary>
        [XmlElement("address")]
        private string Address { get; set; }
        /// <summary>
        /// Age
        /// for Ignore
        /// </summary>
        [XmlIgnore]
        public int Age { get; set; } = 0;
        /// <summary>
        /// Sex
        /// for Enum
        /// </summary>
        [XmlElement("sex")]
        public Sex Sexual { get; set; }

        public override string ToString() => $"ID = {Id}, FirstName = {FirstName}, MiddleName = {MiddleName}, LastName = {LastName}, Birthday = {Birthday}, Address = {Address}, Age = {Age}, Sex = {Sexual}";
    }
}