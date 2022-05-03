using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ToolKitJuniorNet
{
    public class ServiceText
    {
        public static bool CompareBytes(byte[] a, byte[]b)
        {
            bool iguales = true;
            if (a.Length != b.Length) iguales = false;
            for (int i = 0; i < a.Length; i++)
            {
                if (a[i].Equals(b[i]) == false) { iguales = false; break; }
            }
            return iguales;
            //else if (a.SequenceEqual(b)) iguales = true;
            return iguales;

        }
        public static string NormalizeFileName(string fileName)
        {
            string invalidChars = System.Text.RegularExpressions.Regex.Escape(
                 new string(System.IO.Path.GetInvalidFileNameChars())
            );
            string invalidRegStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", invalidChars);

            return System.Text.RegularExpressions.Regex.Replace(fileName, invalidRegStr, "_");
        }

        public static string NormalizeDirName(string dirName)
        {
            string invalidChars = System.Text.RegularExpressions.Regex.Escape(
                 new string(System.IO.Path.GetInvalidPathChars())
            );
            string invalidRegStr = string.Format(@"([{0}]*\.+$)|([{0}]+)", invalidChars);

            return System.Text.RegularExpressions.Regex.Replace(dirName, invalidRegStr, "_");
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
