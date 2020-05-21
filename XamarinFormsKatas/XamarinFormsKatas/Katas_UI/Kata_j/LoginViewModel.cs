using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace XamarinFormsKatas.Katas_UI.Kata_j
{
    public class LoginViewModel : BindableObject
    {
        private string _username;
        private string _passwd;
        private Command _login;
        public ICommand LoginIcommand => _login;

        public LoginViewModel()
        {
            _login = new Command(BorderColorChanged);
        }

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }
        public string Passwd
        {
            get => _passwd;
            set
            {
                _passwd = value;
                OnPropertyChanged();
            }
        }

        private void BorderColorChanged(object sender)
        {
            

            if (_username == "" || _passwd == "")
            {
                
            }
        }
        
    }
}
