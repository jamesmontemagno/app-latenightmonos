using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace LateNightMonos.View
{
    [QueryProperty(nameof(Count), "count")]
    public partial class Page3 : ContentPage
    {
        public Page3()
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
    }
}
