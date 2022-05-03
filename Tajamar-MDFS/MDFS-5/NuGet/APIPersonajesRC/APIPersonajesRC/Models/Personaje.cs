using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace APIPersonajesRC.Models
{
    public class Personaje
    {
        /*
         * 
    "idPersonaje": 0,
    "nombre": "string",
    "imagen": "string",
    "idSerie": 0
         */
        [JsonProperty("idPersonaje")]
        public int IdPersonaje { get; set; }
        [JsonProperty("nombre")]
        public String Nombre { get; set; }
        [JsonProperty("imagen")]
        public String Imagen { get; set; }
        [JsonProperty("idSerie")]
        public int IdSerie { get; set; }
    }
}
