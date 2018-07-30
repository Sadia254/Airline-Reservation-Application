using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airline_Reservation_Application.Models;

namespace Airline_Reservation_Application.ViewModels
{
    class Login
    {
        string UserName;
        string Password;

        public static bool LoginAction(string username, string password)
        {
            Database database = new Database();

            return database.Login(username, password);
        }
    }
}

