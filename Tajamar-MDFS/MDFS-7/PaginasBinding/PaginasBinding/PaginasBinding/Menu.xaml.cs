using PaginasBinding.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaginasBinding
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Menu : MasterDetailPage
    {
        public Menu()
        {
            InitializeComponent();
            List<MasterPageItem> paginas = new List<MasterPageItem>();
            var pagina1 = new MasterPageItem()
            {
                Titulo = "Carrousel",
                PaginaHija = typeof(Carrousel)
            };
            var pagina2 = new MasterPageItem()
            {
                Titulo = "Tabla Multiplicar",
                PaginaHija = typeof(TablaMultiplicarView)
            }; var pagina3 = new MasterPageItem()
            {
                Titulo = "List Numeros",
                PaginaHija = typeof(ListNumerosColores)
            }; var pagina4 = new MasterPageItem()
            {
                Titulo = "Converter Temperatura",
                PaginaHija = typeof(ConverterTemperatura)
            };
            paginas.Add(pagina2);
            paginas.Add(pagina1);
            paginas.Add(pagina3);
            paginas.Add(pagina4);
            this.listMenu.ItemsSource = paginas;
            //Pagina principal
            this.Detail = new NavigationPage(
                (Page)Activator.CreateInstance(typeof(ConverterTemperatura))
                );
            this.listMenu.ItemSelected += ListMenu_ItemSelected;

        }

        private void ListMenu_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var page = (MasterPageItem)e.SelectedItem;
            Type type = page.PaginaHija;
            this.Detail = new NavigationPage((Page) Activator.CreateInstance(type));
            //Esconder menu al pulsar opcion
            this.IsPresented = false;
        }
    }
}