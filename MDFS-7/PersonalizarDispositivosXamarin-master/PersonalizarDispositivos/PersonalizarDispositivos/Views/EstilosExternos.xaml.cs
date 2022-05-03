using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PersonalizarDispositivos.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class EstilosExternos : ContentPage
    {
        public EstilosExternos()
        {
            InitializeComponent();
            Label lbl = new Label
            {
                Text = "Piensa Macfly, piensa...",
                FontFamily = Device.RuntimePlatform == Device.Android ?
                "BTTF.ttf#Back to the future 2002" : null
            };
            this.contenedor.Children.Add(lbl);
            Label lbl2 = new Label
            {
                FontSize = 100,
                Text = "Disney Pixar",
                FontFamily = Device.RuntimePlatform == Device.Android ?
                "Disney family 1.ttf#Disney family 1" : null
            };
            this.contenedor.Children.Add(lbl2);
        }
    }
}