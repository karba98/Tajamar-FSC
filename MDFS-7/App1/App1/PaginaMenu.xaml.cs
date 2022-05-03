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
    public partial class PaginaMenu : ContentPage
    {
        public PaginaMenu()
        {
            
            InitializeComponent();
            boton.Clicked += Boton_Clicked;
            botonce.Clicked += Botonce_Clicked;
            botonframe.Clicked += Botonframe_Clicked;
            botonalerts.Clicked += Botonalerts_Clicked;
           
        }

        private async void Botonalerts_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TiposAlertas());
        }

        private void Botonframe_Clicked(object sender, EventArgs e)
        {
            framee.IsVisible = true;
        }

        private async void Botonce_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new StackLayoutView());
        }

        private async void Boton_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Page2());
        }
    }
}