﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilsonInformer.Helpers
{
    public class ToolKit
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
        public static String NormalizeFileName(String FileName)
        {
            return null;
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
