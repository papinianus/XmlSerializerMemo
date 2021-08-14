using System;
using System.IO;
using System.Xml.Serialization;

namespace XmlSerializerMemo
{
    public static class XmlHelper
    {
        public static void Serialize<T>(string path,T data)
        {
            using var stream = new FileStream(path, FileMode.Create);
            using var writer = new StreamWriter(stream, System.Text.Encoding.UTF8);

            //名前空間出力抑制
            var ns = new XmlSerializerNamespaces();
            ns.Add(string.Empty, string.Empty);
            
            var serializer = new XmlSerializer(typeof(T));
            serializer.Serialize(writer, data, ns);
        }

        public static T Deserialize<T>(string path)
        {
            using var fs = new FileStream(path, FileMode.Open);
            var serializer = new XmlSerializer(typeof(T));
            return (T)serializer.Deserialize(fs);
        }
    }
}