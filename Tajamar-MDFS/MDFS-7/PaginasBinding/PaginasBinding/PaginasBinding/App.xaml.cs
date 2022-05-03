﻿using PaginasBinding.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PaginasBinding
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Menu();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
