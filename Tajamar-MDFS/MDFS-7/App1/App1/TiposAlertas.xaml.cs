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
    public partial class TiposAlertas : ContentPage
    {
        public TiposAlertas()
        {
            InitializeComponent();
            alertasimple.Clicked += Alertasimple_Clicked;
            okcancel.Clicked += Okcancel_Clicked;
            modal.Clicked += Modal_Clicked;
            opciones.Clicked += Opciones_Clicked;
        }

        private async void Opciones_Clicked(object sender, EventArgs e)
        {
            String opcion = await DisplayActionSheet("¿Kherés Shope?",
                "No quiero responder", "SI", "NO", "NOSE",
                "BUENO SI SE PERO NO TE VOY A DECIR JAJAJ SALU3");
            lblrespuesta.Text = opcion;
        }

        private async void Modal_Clicked(object sender, EventArgs e)
        {
            //Modal es la pagina creada en XAML
            Modal modal = new Modal();
            await Navigation.PushModalAsync(modal);
        }

        private async void Okcancel_Clicked(object sender, EventArgs e)
        {
            bool respuesta = await
                DisplayAlert("Pregunta..","SI o NO?","SI","NO");
            if(respuesta == true)
            {
                lblrespuesta.Text = "SI hombre";
            }
            else
            {
                lblrespuesta.Text = "NO tio NOOOOOOOO";
            }
        }

        private void Alertasimple_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Titulo", "Mensaje simple", "OK");
        }
    }
}