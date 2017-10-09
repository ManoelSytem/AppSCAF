using SCAF.Helpers;
using Xamarin.Forms;

namespace SCAF.ViewModels
{
    public class LoginViewModel : BaseViewModel
    {

        public string Username { get; set; }

        public string Password { get; set; }

        public ImageSource i_con;
        public ImageSource Icon
        {
            get
            {
                return i_con;
            }
            set
            {
                SetProperty(ref i_con, value);
            }
        }

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
            Icon = ImageSource.FromResource("SCAF.Resource.SCAF_logo.jpg");
        }
    }
}
