using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;

namespace Airline_Reservation_Application.Models
{
    class Seat
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Company { get; set; }
        public string PhoneNumber { get; set; }
        public int Number { get; set; }
        public bool IsBooked { get; set; }


        public bool IsAvailable { get => !IsBooked; }
        public string FullName { get => String.Join(" ", new string[] { FirstName, LastName }); }
        public string SeatNumber { get => String.Format("Seat Number: {0}", Number); }
        public string Availability { get => IsBooked ? "Reserved" : "Available"; }
        public string SeatImg { get => IsAvailable ? "ms-appx:///Assets/Flight_Seat.png" : "ms-appx:///Assets/Flight_Seat_Gray.png"; }

        public override string ToString()
        {
            if (Number <= 0)
            {
                return String.Empty;
            }

            return String.Format("Seat #{0}", this.Number.ToString());
        }

        public Visibility SetVisibility()
        {
            return (Company == String.Empty) ? Visibility.Collapsed : Visibility.Visible;
        }
    }

}
    

