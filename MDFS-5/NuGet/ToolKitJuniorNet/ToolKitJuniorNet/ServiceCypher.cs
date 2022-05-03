using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ToolKitJuniorNet
{
    public class ServiceCypher
    {

        public static String SimpleEncryptKey(String contenido, int iteraciones,String salt)
        {
            String contenidoSalt = contenido + salt;
            SHA256Managed sha = new SHA256Managed();
            byte[] salida;
            salida = Encoding.UTF8.GetBytes(contenidoSalt);
            for(int i = 1; i <= iteraciones; i++)
            {
                salida = sha.ComputeHash(salida);
            }
            sha.Clear();
            String stringsalida = Encoding.UTF8.GetString(salida);
            return stringsalida;
        }
        public static String GenerateRandomSalt()
        {
            Random r = new Random();
            String salt = "";
            for (int i = 1; i <= 200; i++)
            {
                int aleat = r.Next(0, 9999);
                char letra = Convert.ToChar(aleat);
                salt += letra;
            }
            return salt;
        }
        public static byte[] GeneratePassword(String key, String salt)
        {
            String contenidoSalt = key + salt;
            SHA256Managed sha = new SHA256Managed();
            byte[] salida;
            salida = Encoding.UTF8.GetBytes(contenidoSalt);
            for (int i = 1; i <= 19982; i++)
            {
                salida = sha.ComputeHash(salida);
            }
            sha.Clear();
            return salida;
        }
    }
}
