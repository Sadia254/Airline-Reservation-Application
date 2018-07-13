using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airline_Reservation_Application.Models;

namespace Airline_Reservation_Application
{
    class ViewModel
    {

        public User mainUser;


        public void CreateDummyUsers() {
            mainUser = new User { FullName = "John Doe", UserName = "jDoe", Password = "password" };

        }

        //public bool UserIsValid() {
        //    return true;

        //}




    }
}
