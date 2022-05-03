using System;
using System.Collections.Generic;
using System.Text;

namespace Receiver.Models
{
    public class MensajeUsuario
    {
        public String Asunto { get; set; }
        public String Mensaje { get; set; }
        public String Email { get; set; }
        public DateTime Fecha{ get; set; }
    }
}
