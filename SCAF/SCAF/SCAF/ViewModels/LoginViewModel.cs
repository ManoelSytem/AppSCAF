using Android.Content.Res;
using SCAF.Helpers;
using SCAF.Services;
using SCAF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace SCAF.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {

        public string Username { get; set; }

        public string Password { get; set; }

        private string _message;
        public string Message {
            get
            {
                return _message;
            }
            set
            {
                SetProperty(ref _message, value);
            }
        }

        public LoginViewModel()
        {
            Username = Settings.Username;
            Password = Settings.Password;
        }
    }
}
