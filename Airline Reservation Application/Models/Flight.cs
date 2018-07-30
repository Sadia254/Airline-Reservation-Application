using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Airline_Reservation_Application.Models
{
    class Flight
    {
        public string Origin { get; set; }
        public string Destination { get; set; }
        public string Plane { get; set; }
        public string Airline { get; set; }
        public string DepartureTime { get; set; }
        public string FlightNumber { get; set; }

        public string FlightDetail
        {
            get => String.Format("{0} {1} ({2} -> {3}). ", Airline, FlightNumber, Origin, Destination);
        }

        public string DepartureDetail { get => String.Format("Plane: {0} Departure: {1}", Plane, DepartureTime); }
    }
}

    

