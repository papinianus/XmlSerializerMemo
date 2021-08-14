using System;

namespace XmlSerializerMemo
{
    public class Person
    {
        /// <summary>
        /// ID
        /// example for attribute, integer
        /// </summary>
        [System.Xml.Serialization.XmlAttribute("id")]
        public int Id { get; set; }
        /// <summary>
        /// First Name
        /// </summary>
        [System.Xml.Serialization.XmlElement("firstname")]
        public string FirstName { get; set; }
        /// <summary>
        /// Middle Name
        /// example for null and empty element
        /// </summary>
        [System.Xml.Serialization.XmlElement("middlename")]
        public string MiddleName { get; set; }
        /// <summary>
        /// Last Name
        /// </summary>
        [System.Xml.Serialization.XmlElement("lastname")]
        public string LastName { get; set; }
        /// <summary>
        /// Birth Day
        /// </summary>
        [System.Xml.Serialization.XmlElement("birthday")]
        public DateTime Birthday { get; set; }
        /// <summary>
        /// Address
        /// private won't be serialized
        /// </summary>
        [System.Xml.Serialization.XmlElement("address")]
        private string Address { get; set; }

        /// <summary>
        /// Age
        /// for Ignore
        /// </summary>
        [System.Xml.Serialization.XmlIgnore]
        public int Age { get; set; } = 0;

        public override string ToString() => $"ID = {Id}, FirstName = {FirstName}, MiddleName = {MiddleName}, LastName = {LastName}, Birthday = {Birthday}, Address = {Address}, Age = {Age}";
    }
}