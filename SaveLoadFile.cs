using System.Xml;
using System.Xml.Serialization;

namespace Lessons
{
    internal class SaveLoadFile<T> where T : class
    {
        public void SerializeObject(T serializableObject, string filePath)
        {
            if (serializableObject == null || filePath == null) { throw new ArgumentException(); }

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                XmlSerializer serializer = new XmlSerializer(serializableObject.GetType());
                using (MemoryStream stream = new MemoryStream())
                {
                    serializer.Serialize(stream, serializableObject);
                    stream.Position = 0;
                    xmlDocument.Load(stream);
                    xmlDocument.Save(filePath);
                }
            }
            catch { }
        }

        public T DeSerializeObject(string filePath)
        {
            if (string.IsNullOrEmpty(filePath)) { return default(T)!; }

            T objectOut = default(T)!;

            try
            {
                XmlDocument xmlDocument = new XmlDocument();
                xmlDocument.Load(filePath);
                string xmlString = xmlDocument.OuterXml;

                using (StringReader read = new StringReader(xmlString))
                {
                    Type outType = typeof(T);

                    XmlSerializer serializer = new XmlSerializer(outType);
                    using (XmlReader reader = new XmlTextReader(read))
                    {
                        objectOut = (T)serializer.Deserialize(reader)!;
                    }
                }
            }
            catch { }

            return objectOut;
        }
    }
}