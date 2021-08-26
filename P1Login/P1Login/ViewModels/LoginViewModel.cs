using Acr.UserDialogs;
using P1Login.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace P1Login.ViewModels
{
    public class LoginViewModel : INotifyPropertyChanged
    {


        public string EmailInput{get; set;}
        public string PasswordInput{get;set;} 
        public ICommand LoginCommand { get; }
        public ICommand NavigateCommand { get; }
            

        public LoginViewModel()
        {
            LoginCommand = new Command<string>(AlertLogin);

            NavigateCommand = new Command(async () =>
            {
                await App.Current.MainPage.Navigation.PushAsync(new RegistrationPage());
            });

        }
        private void AlertLogin(string alertText)
        {
            if(String.IsNullOrEmpty(EmailInput) || String.IsNullOrEmpty(PasswordInput))
            {
                UserDialogs.Instance.Toast($"Favor llenar todos los campos", TimeSpan.FromSeconds(3));

            }

            else
            {
                UserDialogs.Instance.Toast($"Hola de nuevo {EmailInput}!", TimeSpan.FromSeconds(3));
                App.Current.MainPage.Navigation.PushAsync(new HomePage());
            }


        }

        public event PropertyChangedEventHandler PropertyChanged;
    }

}
