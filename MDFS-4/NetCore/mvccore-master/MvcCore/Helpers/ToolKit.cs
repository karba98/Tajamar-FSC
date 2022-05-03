using MvcCore.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Threading.Tasks;

namespace MvcCore.Helpers
{
    public class ToolKit
    {
        public static bool CompareBytes(byte[] a, byte[]b)
        {
            bool iguales = true;
            if (a.Length != b.Length) iguales = false;
            //for(int i=0;i<a.Length;i++)
            //{
            //    if (a[i].Equals(b[i]) == false) { iguales = false;break; }
            //}
            //return iguales;
            else if (a.SequenceEqual(b)) iguales = true;
            return iguales;

        }
        public static String NormalizeFileName(String FileName)
        {
            return null;
        }
        // Convert an object to a byte array
        public static byte[] ObjectToByteArray(Object obj)
        {
            if (obj == null)
                return null;

            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);

                return ms.ToArray();
            }
        }

        // Convert a byte array to an Object
        public static Object ByteArrayToObject(byte[] arrBytes)
        {
            if (arrBytes == null) return null;
            BinaryFormatter binForm = new BinaryFormatter();
            using (MemoryStream memStream = new MemoryStream())
            {
                memStream.Write(arrBytes, 0, arrBytes.Length);
                memStream.Seek(0, SeekOrigin.Begin);
                Object obj = (Object)binForm.Deserialize(memStream);

                return obj;
            }
        }
        public static String Serialize(Object objeto)
        {
            return JsonConvert.SerializeObject(objeto);
            
        }
        public static T Deserialize<T>(String json)
        {
            return JsonConvert.DeserializeObject<T>(json);
            
        }

    }
}
