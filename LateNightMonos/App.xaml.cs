﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
namespace LateNightMonos
{
    public partial class App : Application
    {

        public App()
        {
            InitializeComponent();

            MainPage = new AppShell();
        }

        protected override async void OnAppLinkRequestReceived(Uri uri)
        {
            base.OnAppLinkRequestReceived(uri);

            if (uri.Host == "monkeys" && uri.AbsolutePath == "/detail")
                await Shell.Current.GoToAsync($"//{uri.Host}{uri.PathAndQuery}");
            
            
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
