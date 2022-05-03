using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App1
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Modal : ContentPage
    {
        public String dato { get; set; }
        public Modal()
        {
            InitializeComponent();
            cerrar.Clicked += Cerrar_Clicked;
        }

        private async void Cerrar_Clicked(object sender, EventArgs e)
        {
            this.dato = "Ventana cerrada";
            await Navigation.PopModalAsync();
        }
    }
}