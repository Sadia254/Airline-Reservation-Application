using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Airline_Reservation_Application.Models;

namespace Airline_Reservation_Application.ViewModels
{
    class FlightsViewModel
    {
        public static List<Flight> Flights;

        public static void Initialize()
        {
            Flights = new List<Flight>
            {
                // >: 4 8 15 16 23 42_
                // Execute
                new Flight
                {
                    Origin = "Sydney, Australia",
                    Destination = "Los Angeles, CA",
                    Airline = "Oceanic Airlines",
                    Plane = "Boeing 777",
                    DepartureTime = "09:00 AM",
                    FlightNumber = "815"
                },
                new Flight
                {
                    Origin = "NY",
                    Destination = "CA",
                    Airline = "Virgin",
                    Plane = "Boeing 747",
                    DepartureTime = "09:00 AM",
                    FlightNumber = "123"
                },
                new Flight
                {
                    Origin = "FL",
                    Destination = "WA",
                    Airline = "Generic",
                    Plane = "Boeing 737",
                    DepartureTime = "10:00 AM",
                    FlightNumber = "345"
                },
                new Flight
                {
                    Origin = "FL",
                    Destination = "CA",
                    Airline = "Airwave",
                    Plane = "Boeing 747",
                    DepartureTime = "09:00 AM",
                    FlightNumber = "567"
                },
                new Flight
                {
                    Origin = "NY",
                    Destination = "CA",
                    Airline = "Virgin",
                    Plane = "Boeing 747",
                    DepartureTime = "09:00 AM",
                    FlightNumber = "789"
                },
                new Flight
                {
                    Origin = "NY",
                    Destination = "London, UK",
                    Airline = "Oceanic",
                    Plane = "Boeing 747",
                    DepartureTime = "09:00 AM",
                    FlightNumber = "666"
                },
                new Flight
                {
                    Origin = "Sydney, Australia",
                    Destination = "Los Angeles, CA",
                    Airline = "Oceanic Airlines",
                    Plane = "Boeing 777",
                    DepartureTime = "09:00 AM",
                    FlightNumber = "815"
                },
                new Flight
                {
                    Origin = "NY",
                    Destination = "CA",
                    Airline = "Virgin",
                    Plane = "Boeing 747",
                    DepartureTime = "09:00 AM",
                    FlightNumber = "123"
                },
                new Flight
                {
                    Origin = "FL",
                    Destination = "WA",
                    Airline = "Generic",
                    Plane = "Boeing 737",
                    DepartureTime = "10:00 AM",
                    FlightNumber = "345"
                },
                new Flight
                {
                    Origin = "FL",
                    Destination = "CA",
                    Airline = "Airwave",
                    Plane = "Boeing 747",
                    DepartureTime = "09:00 AM",
                    FlightNumber = "567"
                },
                new Flight
                {
                    Origin = "NY",
                    Destination = "CA",
                    Airline = "Virgin",
                    Plane = "Boeing 747",
                    DepartureTime = "09:00 AM",
                    FlightNumber = "789"
                },
                new Flight
                {
                    Origin = "NY",
                    Destination = "London, UK",
                    Airline = "Oceanic",
                    Plane = "Boeing 747",
                    DepartureTime = "09:00 AM",
                    FlightNumber = "666"
                }

            };
        }

        public static List<Flight> GetFlights()
        {
            if (Flights == null)
            {
                Initialize();
            }

            return Flights;
        }
    }
}

