using Acr.UserDialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace P1Login.ViewModels
{
    
        public class RegistrationViewModel : INotifyPropertyChanged
        {

            public string NameInput { get; set; }
            public string EmailInput { get; set; }
            public string PasswordInput { get; set; }

            public string PasswordConfirmationInput { get; set; }

            public ICommand SignInCommand { get; }

            public RegistrationViewModel()
            {
                SignInCommand = new Command<string>(AlertSignIn);
            }
            private void AlertSignIn(string alertText)
            {
                if (!String.IsNullOrEmpty(NameInput) && !String.IsNullOrEmpty(EmailInput) && !String.IsNullOrEmpty(PasswordInput) && !String.IsNullOrEmpty(PasswordConfirmationInput))
                {
                    UserDialogs.Instance.Toast($"Bienvenido {NameInput}", TimeSpan.FromSeconds(3));
                }
                else
                {
                    UserDialogs.Instance.Toast($"Favor llenar todos los campos", TimeSpan.FromSeconds(3));

                }
            }


            public event PropertyChangedEventHandler PropertyChanged;
        
    }
}
