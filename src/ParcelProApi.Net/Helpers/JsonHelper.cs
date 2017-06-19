using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
using System.Text;

namespace ParcelProApi.Net.Helpers
{
    /// <summary>
    /// Summary description for JsonHelper
    /// </summary>
    public class JsonHelper
    {
        public static string Serialize<T>(T obj)
        {
            string retVal;
            var serializer = new DataContractJsonSerializer(obj.GetType(), new DataContractJsonSerializerSettings { DateTimeFormat = new DateTimeFormat("yyyy-MM-ddHH:mm:ss") });
            using (var ms = new MemoryStream())
            {
                serializer.WriteObject(ms, obj);
                retVal = Encoding.UTF8.GetString(ms.ToArray());
            }
            return retVal;
        }

        public static T Deserialize<T>(string json)
        {
            T obj;
            using (var ms = new MemoryStream(Encoding.UTF8.GetBytes(json)))
            {
                var serializer = new DataContractJsonSerializer(typeof(T), new DataContractJsonSerializerSettings { DateTimeFormat = new DateTimeFormat("yyyy-MM-ddHH:mm:ss") });
                obj = (T)serializer.ReadObject(ms);
                ms.Close();
            }
            return obj;
        }
    }
}