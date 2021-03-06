﻿using System;
using SlideOverKit;
using Xamarin.Forms;

namespace SlideMenuExemplo.Menu
{
    public class MenuInferiorExemploPage : MenuContainerPage
    {
        public MenuInferiorExemploPage()
        {
            Content = new StackLayout
            {
                VerticalOptions = LayoutOptions.Center,
                Spacing = 10,
                Children = {
                    new Button{
                        Text ="Exibir Menu",
                        Command = new Command(()=>{
                            this.ShowMenu();
                        })
                    },
                    new Button{
                        Text ="Esconder Menu",
                        Command = new Command(()=>{
                            this.HideMenu();
                        })
                    },
                }
            };

            this.SlideMenu = new MenuInferiorPage();
        }
    }
}

