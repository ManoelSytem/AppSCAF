using System;
using SCAF.Data;
using SQLite;
using System.IO;
using SCAF.iOS.Data;

[assembly: Xamarin.Forms.Dependency(typeof(SQLiteIOS))]
namespace SCAF.iOS.Data
{
    public class SQLiteIOS : ISQlite
    {
        public SQLiteIOS() { }

        public SQLiteConnection GetConnection()
        {
            var SqliteFileName = "SCAF.db3";
            string documentsPath = System.Environment.GetFolderPath(System.Environment.SpecialFolder.Personal);
            var libraryPath = Path.Combine(documentsPath, ",,", "Library");
            var path = Path.Combine(libraryPath, SqliteFileName);
            var conn = new SQLite.SQLiteConnection(path);
            return conn;
        }
    }
}