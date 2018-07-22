using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airline_Reservation_Application.Models;

namespace Airline_Reservation_Application.ViewModel
{
    class ViewModel
    {
        public class LoginPageViewModel
        {

            List<User> allUsers = new List<User>();

            void CreateUsersForTesting()
            {
                allUsers.Add(new User { FullName = "John Doe", UserName = "JDoe", Password = "abc", Email = "jdoe@msn.com" });
                allUsers.Add(new User { FullName = "Sadia Saleh", UserName = "Ssal", Password = "cds", Email = "sadia@yahoo.com" });

            }

            bool findUser(string userName){
                allUsers=

                return false;
}
        }

     
    }

}