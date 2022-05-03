using PaginasBinding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaginasBinding.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BindingClass : ContentPage
    {
        public BindingClass()
        {
            InitializeComponent();
            Coche car = new Coche();
            car.Marca = "BMW";
            car.Modelo = "Serie S";
            car.Velocidad = 350;
            car.Imagen = 
                "https://images1.autocasion.com/unsafe/1200x800/actualidad/wp-content" +
                "/uploads/2020/05/BMW-6-Series_Gran_Turismo-2021-1280-04.jpg";
            //ENLAZAMOS INSTANCIA DEL COCHE CON LA PAGINA
            this.BindingContext = car;
        }
    }
}