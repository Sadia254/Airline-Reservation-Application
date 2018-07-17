using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SQLite.Net;

namespace Airline_Reservation_Application.Models
{
    class Database
    {
        string path;
        SQLiteConnection conn;

        public Database()
        {
            path = Path.Combine(Windows.Storage.ApplicationData.Current.LocalFolder.Path, "MyDatabase.sqlite");
            conn = new SQLiteConnection(new SQLite.Net.Platform.WinRT.SQLitePlatformWinRT(), path);
            conn.CreateTable<User>();
        }

        public int Register(User user)
        {
            return conn.Insert(new User()
            {
                UserName = user.UserName,
                Password = user.Password,
                Email = user.Email

            });
        }

        public bool Login(string user, string password)
        {
            var query = conn.Table<User>().
            Where(t => t.UserName == user && t.Password == password);
            if (query.Count() > 0)
                return true;
            else
                return false;
        }
    }
}
    

