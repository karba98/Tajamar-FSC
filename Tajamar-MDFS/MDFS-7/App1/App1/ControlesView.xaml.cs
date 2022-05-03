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
    public partial class ControlesView : ContentPage
    {
        public ControlesView()
        {
            InitializeComponent();
            this.boton.Clicked += Boton_Clicked;
            //this.boton.Clicked += (sender,args) =>{
            //
            //};
        }

        private void Boton_Clicked(object sender, EventArgs e)
        {
            int botones = int.Parse(entry.Text);
            for(int i = 1; i <= botones; i++)
            {
                Button b = new Button();
                b.Text = "boton " + i;
                contenedor.Children.Add(b);
            }
        }
    }
}