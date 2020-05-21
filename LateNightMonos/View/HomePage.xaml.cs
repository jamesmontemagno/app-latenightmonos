using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LateNightMonos.View
{
    [QueryProperty(nameof(Count), "count")]
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = this;
        }

        string count;

        public string Count
        {
            get => count;
            set
            {
                count = Uri.UnescapeDataString(value ?? string.Empty);
                OnPropertyChanged();
            }
        }


        async void Button_Clicked(System.Object sender, System.EventArgs e)
        {
            var info = EntryInfo.Text;
            var route = $"detail?data={info}&phone=Pixel 2 XL";
            await Shell.Current.GoToAsync(route);
        }
    }
}
