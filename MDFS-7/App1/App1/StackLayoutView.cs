using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace App1
{
    public class StackLayoutView : ContentPage
    {
        public StackLayoutView()
        {
            StackLayout principal = new StackLayout();
            Label header = new Label()
            {
                Text = "Nuevo label",
                FontSize = 20,
                TextColor = Color.Red
            };
            StackLayout contenido = new StackLayout();
            Label lbl1 = new Label()
            {
                HorizontalOptions = LayoutOptions.Start,
                Text = "Otro label"
            };
            contenido.Children.Add(header);
            contenido.Children.Add(lbl1);
            principal.Children.Add(contenido);
            this.Content = principal;

        }
    }
}