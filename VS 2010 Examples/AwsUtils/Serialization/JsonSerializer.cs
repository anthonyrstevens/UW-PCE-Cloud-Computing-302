using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Json;
using System.Text;

namespace AwsUtils.Serialization
{
    public static class JsonSerializer
    {
        public static string SerializeToJson<T>(this T data)
        {
            try
            {
                var serializer = new DataContractJsonSerializer(typeof(T));
                var stream = new MemoryStream();
                serializer.WriteObject(stream, data);
                var jsonData = Encoding.UTF8.GetString(stream.ToArray(), 0, (int)stream.Length);
                stream.Close();
                return jsonData;
            }
#if DEBUG
            catch (Exception exc)
            {
                Trace.TraceError(exc.ToString());
                throw;
            }
#else
            catch
            {
                return "";
            }
#endif
        }

        public static T DeserializeFromJson<T>(this string jsonData)
        {
            var slzr = new DataContractJsonSerializer(typeof(T));
            var stream = new MemoryStream(Encoding.UTF8.GetBytes(jsonData));
            var data = (T)slzr.ReadObject(stream);
            stream.Close();
            return data;
            
        }
        
    }
}
