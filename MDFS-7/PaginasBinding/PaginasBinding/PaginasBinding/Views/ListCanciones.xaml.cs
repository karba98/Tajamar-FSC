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
    public partial class ListCanciones : ContentPage
    {
        public ListCanciones()
        {
            InitializeComponent();
            List<Cancion> canciones = new List<Cancion>();
            Cancion c = new Cancion()
            {
                Titulo = "Canción",
                Artista = "Mi artista favorito",
                Imagen = "https://cdn.icon-icons.com/icons2/1880/PNG/512/iconfinder-music-4341309_120542.png"
            };
            for(int i = 0; i < 40; i++)
            {
                canciones.Add(c);
            }
            this.listcanciones.ItemsSource = canciones;
        }
    }
}