﻿using Xamarin.Forms;

namespace MySabinoRoad
{
    public partial class App : Application
    {
        public static bool IsUserLoggedIn = false;

        public App()
        {
            //InitializeComponent();
            
            //MainPage = new NavigationPage(new View.NavPage());

            if (!IsUserLoggedIn)
            {
                MainPage = new NavigationPage(new MySabinoPage());
            }
            else
            {
                MainPage = new NavigationPage(new View.NavPage());
            }            
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            IsUserLoggedIn = false;
        }
    }
}
