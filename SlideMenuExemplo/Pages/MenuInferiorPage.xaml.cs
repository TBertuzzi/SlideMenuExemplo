using System;
using System.Collections.Generic;
using SlideOverKit;
using Xamarin.Forms;

namespace SlideMenuExemplo
{
    public partial class MenuInferiorPage : SlideMenuView
    {
        public MenuInferiorPage()
        {
            InitializeComponent();

            this.HeightRequest = 250;

            this.IsFullScreen = true;
            this.MenuOrientations = MenuOrientation.BottomToTop;

            this.BackgroundColor = Color.Black;
            this.BackgroundViewColor = Color.Transparent;

            if (Device.RuntimePlatform == Device.Android)
                this.HeightRequest += 50;
        }
    }
}
