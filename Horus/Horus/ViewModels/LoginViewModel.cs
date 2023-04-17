using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Horus.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _username;
        private string _password;

        public string Username
        {
            get { return _username; }
            set
            {
                if (_username != value)
                {
                    _username = value;
                    OnPropertyChanged();
                }
            }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                if (_password != value)
                {
                    _password = value;
                    OnPropertyChanged();
                }
            }
        }

        public Command LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new Command(Login);
        }

        private void Login()
        {
            try
            {
                
                string username = Username;
                string password = Password;
                if (username != null && password != null)
                {
                    // TODO: Implement login logic
                }
                else
                {
                    Application.Current.MainPage.DisplayAlert("Login Fallido", "Debes llenar todos los campos", "Ok");
                }
            }
            catch (Exception ex)
            {
                Application.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
                throw new Exception(ex.Message);
            }
        }

    }
}
