using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using SCAF.Data;
using System.IO;
using System.Runtime.CompilerServices;
using SCAF.Droid.Data;
using Xamarin.Forms;

[assembly: Xamarin.Forms.Dependency(typeof(ISQliteAndroid))]
namespace SCAF.Droid.Data
{
    public class ISQliteAndroid : ISQlite
    {
        public ISQliteAndroid() { }
        public SQLite.SQLiteConnection GetConnection()
        {
            var SqliteFileName = "SCAF.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var path = Path.Combine(documentsPath, SqliteFileName);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }

    }
}