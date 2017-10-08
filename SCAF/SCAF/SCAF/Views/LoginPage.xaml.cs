using SCAF.Helpers;
using SCAF.Model;
using SCAF.Services;
using SCAF.ViewModels;
using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SCAF.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LoginPage : ContentPage
    {
        private readonly ApiServices _apiServices = new ApiServices();
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
            //Button_Entrar.Visibility = ViewStates.Gone;
            Entry_Login.Completed += (s, e) => Entry_Senha.Focus();
            Entry_Senha.Completed += (s, e) => EntrarProcedure(s, e);
           
        }

        private async void EntrarProcedure(object sender, EventArgs e)
        {
            try
            {
                var accesstoken = await _apiServices.LoginAsync(Entry_Login.Text, Entry_Senha.Text);
                if (!string.IsNullOrEmpty(accesstoken))
                {
                    Settings.Accesstoken = accesstoken;
                    await Navigation.PushAsync(new MainPage());
                }
                else
                {
                    await DisplayAlert("Menssagem", "O nome do usuário ou senha está incorreto", "OK");
                    await Navigation.PushAsync(new MainPage());
                }
            }
            catch (Exception)
            {
                await DisplayAlert("Menssagem", "Erro Exception", "OK");
                await Navigation.PushAsync(new MainPage());
            }
        }
    }
}