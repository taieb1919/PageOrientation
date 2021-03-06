﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace PageOrientation
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class PortraitPage : ContentPage
    {
        public PortraitPage()
        {
            InitializeComponent();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            DependencyService.Get<IOrientationService>().ForcePortraitOrientation();
        }
    }
}