﻿using System;
using System.Collections.Generic;
using LateNightMonos.ViewModel;
using Xamarin.Forms;

namespace LateNightMonos.View
{
    public partial class HomePage : ContentPage
    {
        public HomePage()
        {
            InitializeComponent();
            BindingContext = new HomeViewModel();
        }

    }
}
