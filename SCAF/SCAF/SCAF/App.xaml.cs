using SCAF.Data;
using SCAF.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace SCAF
{
    public partial class App : Application
    {
        static TokenDataBaseControl tokenDataBase;
        static UserDatabaseController UserdataBase;
        public App()
        {
            InitializeComponent();

            MainPage = new LoginPage();
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }

        protected override void OnResume()
        {
            // Handle when your app resumes
        }

        public static UserDatabaseController UserDataBase
        {
            get
            {
                if (UserdataBase == null)
                {
                    UserdataBase = new UserDatabaseController();
                }
                return UserdataBase;
            }
        }

        public static TokenDataBaseControl TokenDataBase
        {
            get
            {
                if (UserdataBase == null)
                {
                    tokenDataBase = new TokenDataBaseControl();
                }
                return tokenDataBase;
            }
        }
    }
}
