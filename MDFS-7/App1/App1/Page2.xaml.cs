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
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
            this.sld.ValueChanged += Sld_ValueChanged;
            List<string> cosas = new List<string>()
            {
                "Hola","Mundo","xD"
            };
            foreach(String s in cosas){
                picker.Items.Add(s);
            }
            picker.SelectedIndexChanged += (sender, args) =>
            {
                lblvalue.Text = picker.SelectedItem.ToString();
            };

            
        }



        private void Sld_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            var value = e.NewValue;
            lblvalue.Text = value.ToString();
        }
    }
}