using SCAF.Model;
using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SCAF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
       
        public LoginPage()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            BackgroundColor = Constats.BackgroundColor;
            Lbl_Login.TextColor = Constats.MainTextColor;
            Lbl_Senha.TextColor = Constats.MainTextColor;
            ActivitySpinner.IsVisible = false;
            LoginIncon.HeightRequest = Constats.LoginIconAltura;

            Entry_Login.Completed += (s,e) => Entry_Senha.Focus();
            Entry_Senha.Completed += (s, e) => EntrarProcedure(s,e);
        }

        private void EntrarProcedure(object sender, EventArgs e)
        {
            User user = new User(Entry_Login.Text, Entry_Senha.Text);
            if(user.CheckInformacao())
            {
               
                App.UserDataBase.SaveUser(user);
                DisplayAlert("Login", "Login Realizado com Sucesso!"+user.Username+"", "Ok");
            }
            else
            {
                DisplayAlert("Login", "Usuário ou Senha estão Incorretos!", "Ok");
            }
            
        }
    }
}