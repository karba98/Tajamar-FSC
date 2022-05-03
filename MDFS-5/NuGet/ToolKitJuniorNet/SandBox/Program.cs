using System;
using ToolKitJuniorNet;
namespace SandBox
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            String Salt = ServiceCypher.GenerateRandomSalt();
            String file  = ToolKitJuniorNet.ServiceCypher.SimpleEncryptKey("admin1234",20,Salt);
            Console.WriteLine(file);
        }
    }
}
