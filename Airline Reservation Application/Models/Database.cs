using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Airline_Reservation_Application.Models
{
    class Database
    {
        public string _dbPath;
        public string _jsonData;
        public JArray _users;

        public Database()
        {
            var localPath = Windows.ApplicationModel.Package.Current.InstalledLocation;
            string file = "\\Static\\Users.json";

            this._dbPath = Path.Combine(localPath.Path, file);
            this._jsonData = System.IO.File.ReadAllText(localPath.Path + file);
            this._users = JArray.Parse(this._jsonData);
        }


        public bool Login(string username, string password)
        {
            if (string.IsNullOrWhiteSpace(username))
            {
                throw new ArgumentException("Username can't be empty.", nameof(username));
            }

            if (string.IsNullOrWhiteSpace(password))
            {
                throw new ArgumentException("Password can't be empty.", nameof(password));
            }

            // Querying for users with the same username using LINQ syntax
            var selectedUser = from user in _users
                               where user["username"].ToString() == username
                               select user;

            foreach (var user in selectedUser)
            {
                if (user["password"].ToString() == password)
                {
                    return true;
                }
            }

            return false;
        }
    }
}
    

    
