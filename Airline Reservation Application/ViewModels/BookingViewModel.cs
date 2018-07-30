using Airline_Reservation_Application.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Airline_Reservation_Application.ViewModels
{
    class BookingViewModel
    {
        static List<Seat> Seats;

        public static List<Seat> GetSeats()
        {
            if (Seats == null)
            {
                string seatsFilePath;
                string jsonData;
                List<Seat> seats;

                var localPath = Windows.ApplicationModel.Package.Current.InstalledLocation;


                string file = "\\Static\\Seats.json";

                seatsFilePath = Path.Combine(localPath.Path, file);
                jsonData = System.IO.File.ReadAllText(localPath.Path + file);
                Seats = JsonConvert.DeserializeObject<List<Seat>>(jsonData);
            }

            return Seats;
        }

        public static List<Seat> GetAvailableSeats()
        {
            return Seats.FindAll(seat => !seat.IsBooked);
        }

        public static List<Seat> BookSeat(Seat newSeat)
        {
            var index = Seats.FindIndex(seat => seat.Number == newSeat.Number);

            if (index < 0 || index > Seats.Count)
            {
                throw new IndexOutOfRangeException("Error");
            }


            if (Seats != null)
            {
                Seats[index] = newSeat;

            }

            return Seats;
        }

    }
}

