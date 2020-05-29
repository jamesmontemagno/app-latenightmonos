using ShellIntro.Views;
using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace ShellIntro
{
    public partial class AppShell : Xamarin.Forms.Shell
    {
        public AppShell()
        {
            InitializeComponent();

            Routing.RegisterRoute("page2", typeof(Page2));
        }
    }
}
