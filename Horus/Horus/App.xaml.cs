using Horus.Models;
using Horus.Views;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Horus
{
    public partial class App : Application
    {
        public static string APIUrl = "https://horuschallenges.azurewebsites.net/api/";
        public static LoginResponse LoggedUser;
        public App()
        {
            InitializeComponent();

            //MainPage = new MainPage();
            var navigationPage = new NavigationPage(new Login())
            {
                BarBackgroundColor = Color.White,
                BarTextColor = Color.Black
            };
            MainPage = navigationPage;
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
