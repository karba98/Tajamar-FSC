using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WilsonInformer.Utility
{
    public class MapSelectResParte
    {
        public static Dictionary<String,String> GetMapResultados()
        {
            var map = new Dictionary<string, string>();
            map.Add("Seleccione resultado final", null);
            map.Add("DEVUELTO A RMTE", "DEVUELTO A RMTE - Envio localizado, figurando en la intranet" +
                " como devuelto a remitente");
            map.Add("LOCALIZADO", "LOCALIZADO - Envio localizado, figurando datos de entrega en la intranet");
            map.Add("DEFINITIVAMENTE EXTRAVIADO", "DEFINITIVAMENTE EXTRAVIADO - Realizado" +
                " el seguimiento de busqueda y habiendo pasado el periodo de tiempo establecido,el" +
                " envio sigue desaparecido");
            map.Add("LOCLIZADO-BORRADO", "LOCALIZADO - Envio localizado, figurando borrado en la intranet");
            map.Add("LOCALIZADO PARCIAL", "LOCALIZADO PARCIAL -habiendo determinado el resultado " +
                "final de este seguimiento como expedicion incompleta, dado que no todos los bultos " +
                "que formabanla " +
                "expedicion han podido ser entregados. Siguen extraviados los bultos reclamados en el " +
                "expediente");
            return map;
        }
    }
}
