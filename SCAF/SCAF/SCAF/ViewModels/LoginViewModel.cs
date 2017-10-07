using SCAF.Helpers;
using SCAF.Services;
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
        private readonly ApiServices _apiServices = new ApiServices();

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

        public ICommand LoginCommand
        {
            get
            {
                return new Command(async () =>
                {
                    var accesstoken = await _apiServices.LoginAsync(Username, Password);
                    if (!string.IsNullOrEmpty(accesstoken))
                    { Settings.Accesstoken = accesstoken; }
                    else
                    {
                        Message = "O nome do usuário ou senha está incorreto";
                    }

                });
            }

        }

        public LoginViewModel()
        {
            Username = Settings.Username;
            Password = Settings.Password;
        }
    }
}
