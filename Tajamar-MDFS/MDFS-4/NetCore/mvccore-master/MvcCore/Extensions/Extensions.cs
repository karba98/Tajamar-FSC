using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using MvcCore.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcCore.Extensions
{
    //EXTENSIONES DE METODOS
    public static class Extensions
    {
        #region Session
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
        #endregion
        #region TempData
        public static void SetTempObject(this ITempDataDictionary tempdata, String key, object value)
        {
            tempdata[key] = ToolKit.Serialize(value);
        }
        public static T GetTempObject<T>(this ITempDataDictionary tempdata, String key)
        {
            if (tempdata[key] == null)
            {
                return default(T);
            }
            else
            {
                return ToolKit.Deserialize<T>(tempdata[key].ToString());
            }
        }

        #endregion
    }
}
