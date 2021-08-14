using System;
using System.Collections.Generic;
using System.Globalization;

// http://park1.wakwak.com/~ima/dotnet_cs_xmlserializer0001.html
namespace XmlSerializerMemo
{
    class Program
    {
        static void Main(string[] args)
        {
            const string kennedy = "Kennedy";
            const string dateFormat = "yyyy年MM月dd日";
            var jack = new Person
            {
                Id = 1,
                FirstName = "John",
                MiddleName = "Fitzgerald",
                LastName = kennedy,
                Birthday = DateTime.ParseExact("1917年05月29日", dateFormat, CultureInfo.CurrentCulture),
                Age = 46,
            };
            var bobby = new Person
            {
                Id = 2,
                FirstName = "Robert",
                MiddleName = string.Empty, //Francis
                LastName = kennedy,
                Birthday = DateTime.ParseExact("1925年11月20日", dateFormat, CultureInfo.CurrentCulture),
                Age = 42,
            };
            var jacky = new Person
            {
                Id = 3,
                FirstName = "Jacqueline",
                MiddleName = null, //Jacqueline Lee Bouvier Kennedy Onassis
                LastName = $"{kennedy} Onassis",
                Birthday = DateTime.ParseExact("1929年07月28日", dateFormat, CultureInfo.CurrentCulture),
                Age = 64,
            };
            var kennedies = new Persons
            {
                Description = "kennedy family",
                Members = new List<Person>(){jack, bobby, jacky},
            };
#if DEBUG
            Console.WriteLine(kennedies);
#endif
            XmlHelper.Serialize("test.xml",kennedies);

            kennedies = XmlHelper.Deserialize<Persons>("test.xml");
            Console.WriteLine(kennedies);
        }
    }
}