using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ShellIntro.Views
{
    [QueryProperty("Count", "count")]
    public partial class Page2 : ContentPage
    {
        public Page2()
        {
            InitializeComponent();
        }

        string count;
        public string Count
        {
            get => count;
            set => count = Uri.UnescapeDataString(value ?? string.Empty);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            LabelInfo.Text = $"Count: {Count}";
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await Shell.Current.GoToAsync("..");

        }
    }
}