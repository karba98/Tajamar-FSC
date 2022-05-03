using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.StyleSheets;
using Xamarin.Forms.Xaml;

namespace PersonalizarDispositivos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PaginaEstilosCSS : ContentPage
    {
        public PaginaEstilosCSS()
        {
            InitializeComponent();
            this.Resources.Add(StyleSheet.FromAssemblyResource(
            IntrospectionExtensions.GetTypeInfo(typeof(PaginaEstilosCSS)).Assembly,
            "PersonalizarDispositivos.styles.estilos.css"));
        }
    }
}