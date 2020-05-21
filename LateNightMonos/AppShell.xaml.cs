using System;
using System.Collections.Generic;
using LateNightMonos.View;
using Xamarin.Forms;

namespace LateNightMonos
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("detail", typeof(DetailPage));
            Routing.RegisterRoute("page3", typeof(Page3));
        }
    }
}
