﻿using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Juan_Taco_Tarea_S2
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new Tarea_S2();
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
