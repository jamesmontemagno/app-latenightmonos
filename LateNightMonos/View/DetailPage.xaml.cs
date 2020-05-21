using System;
using System.Collections.Generic;
using LateNightMonos.ViewModel;
using Xamarin.Forms;

namespace LateNightMonos.View
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage()
        {
            InitializeComponent();
            BindingContext = new DetailViewModel();
        }

        
    }
}
