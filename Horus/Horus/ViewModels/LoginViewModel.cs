using Horus.Models;
using Horus.Services;
using Horus.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace Horus.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {
        private string _username;
        private string _password;
        private readonly DataStoreLogin _dataStoreLogin;

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
        private readonly INavigation _navigation;
        public Command LoginCommand { get; }

        public LoginViewModel(INavigation navigation)
        {
            _dataStoreLogin = new DataStoreLogin();
            LoginCommand = new Command(LoginAsync);
            _navigation = navigation;
        }

        private async void LoginAsync()
        {
            try
            {
                
                User user = new User()
                {
                    Email = Username,
                    Password = Password
                };

                if (user.Email != null && user.Password != null)
                {
                    // TODO: Implement login logic
                    var response = await _dataStoreLogin.Login(user);
                    if (response != null)
                    {
                        // Store AuthorizationToken 
                        App.LoggedUser = response;
                        var gamification = new Gamification();
                        await _navigation.PushAsync(gamification);
                    }
                }
                else
                {
                    await Application.Current.MainPage.DisplayAlert("Login Fallido", "Debes llenar todos los campos", "Ok");
                }
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", ex.Message, "Ok");
                throw new Exception(ex.Message);
            }
        }

    }
}
