using JsonToSource.Interfaces;
using Newtonsoft.Json;
using System.IO;

namespace JsonToSource
{
    public sealed class JsonConverter<T> 
        : IJsonConverter<T>
    {
        private string _dirPath;

        public JsonConverter(string dirPath)
        {
            _dirPath = dirPath;
            
            //Only create dir if it doesn't exist, otherwise ignore.
            Directory.CreateDirectory(_dirPath);
        }

        /// <summary>
        /// Converts JSON string into XML and will save as a file
        /// </summary>
        public void ConvertJsonToSource(string jsonString, string fileName)
        {
            var xmlDoc = JsonConvert.DeserializeXmlNode("{\"root\":" + jsonString);
            xmlDoc.Save(Path.Combine(_dirPath, fileName));
        }

        /// <summary>
        /// Converts a Json string from object(s) into XML and will save as a file
        /// </summary>
        public void ConvertObjectToSource(T obj, string fileName)
        {
            //Deserialises the order object into JSON so that it can later be converted to XML
            var jsonString = JsonConvert.SerializeObject(obj);
            var xmlDoc = JsonConvert.DeserializeXmlNode("{\"root\":" + jsonString);

            xmlDoc.Save(Path.Combine(_dirPath, fileName));
        }
    }
}
