using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SlideMenuExemplo.Menu;
using Xamarin.Forms;

namespace SlideMenuExemplo
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        void MenuInferior_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MenuInferiorExemploPage());
        }

        void MenuLateral_Clicked(object sender, System.EventArgs e)
        {
            Navigation.PushAsync(new MenuLateralExemploPage());
        }
    }
}
