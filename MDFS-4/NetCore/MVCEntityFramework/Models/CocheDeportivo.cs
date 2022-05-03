using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCEntityFramework.Models
{
    public class CocheDeportivo :  ICoche
    {
        
        public String Marca { get; set; }
        public String Modelo { get; set; }
        public String Imagen { get; set; }
        public int VelocidadMaxima { get; set; }
        public int Velocidad { get; set; }
        public void Acelerar()
        {
            this.Velocidad += 40;
            if (this.Velocidad >= this.VelocidadMaxima)
            {
                this.Velocidad = this.VelocidadMaxima;
            }
        }
        public void Frenar()
        {
            this.Velocidad -= 40;
            if (this.Velocidad < 0)
            {
                this.Velocidad = 0;
            }
        }
        public CocheDeportivo()
        {
            this.Marca = "Audi";
            this.Modelo = "R7";
            this.Velocidad = 0;
            this.VelocidadMaxima = 300;
            this.Imagen = "audi.jpg";
        }
        public CocheDeportivo(String marca, String modelo, String imagen, int vmaxima)
        {
            this.Marca = marca;
            this.Modelo = modelo;
            this.Velocidad = 0;
            this.VelocidadMaxima = vmaxima;
            this.Imagen = imagen;
        }

    }
}
