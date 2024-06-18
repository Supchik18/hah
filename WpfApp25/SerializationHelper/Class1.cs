using System.Text.Json;

namespace SerializationHelper
{
    public class Class1
    {
        public static T Deserialize<T>(string jsonData)
        {
            return JsonSerializer.Deserialize<T>(jsonData);
        }

        public static string Serialize<T>(T obj)
        {
            return JsonSerializer.Serialize(obj);
        }
    }
}