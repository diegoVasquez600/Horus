using Horus.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Horus.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Login : ContentPage
    {
        bool showPassword = true;
        public Login()
        {
            InitializeComponent();
            //BindingContext = new LoginViewModel();
        }

        private void PasswordIcon_Clicked(object sender, EventArgs e)
        {
            if (showPassword)
            {
                passwordIcon.Source = "eye_none_b.png";
                txtPassword.IsPassword = false;
                showPassword = false;
            }
            else
            {
                passwordIcon.Source = "eye_b.png";
                txtPassword.IsPassword = true;
                showPassword = true;
            }
        }

        private void ForgotPassword_Tapped(object sender, EventArgs e)
        {
            ShowDialog("¡Olvidaste tu Contraseña!");
        }


        private void ShowDialog(string name)
        {
            DisplayAlert("Alerta", name, "Ok");
        }


        private void InstagramButton_Clicked(object sender, EventArgs e)
        {
            ShowDialog("¡Instragram!");
        }

        private void FacebookButton_Clicked(object sender, EventArgs e)
        {
            ShowDialog("¡Facebook!");
        }

        private void registerButton_Clicked(object sender, EventArgs e)
        {
            ShowDialog("¡Registrate!");
        }
    }
}