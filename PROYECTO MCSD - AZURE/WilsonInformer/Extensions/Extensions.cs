using Microsoft.AspNetCore.Http;
using WilsonInformer.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilsonInformer.Extensions
{
    public static class Extensions
    {
        //CREAR UN GET/SET OBJECT EN SESSINO
        //SALTANDONOS LA REGLA DE SOLO STRING E INT

        //this indica el objeto del que vamos a extender metodos
        public static void SetObject(this ISession session, String key, object value)
        {
            String json = ToolKit.Serialize(value);
            session.SetString(key, json);
        }
        public static T GetObject<T>(this ISession sesion, String key)
        {
            String data = sesion.GetString(key);
            if (data == null) return default(T);
            else return ToolKit.Deserialize<T>(data);
        }
    }
}
