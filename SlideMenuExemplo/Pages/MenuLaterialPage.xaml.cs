using System;
using System.Collections.Generic;
using SlideOverKit;
using Xamarin.Forms;

namespace SlideMenuExemplo
{
    public partial class MenuLaterialPage : SlideMenuView
    {
        public MenuLaterialPage()
        {
            InitializeComponent();

            this.IsFullScreen = true;
            this.WidthRequest = 250;
            this.MenuOrientations = MenuOrientation.RightToLeft;

            this.BackgroundColor = Color.White;
            this.BackgroundViewColor = Color.FromHex("#CE766C");
        }
    }
}
