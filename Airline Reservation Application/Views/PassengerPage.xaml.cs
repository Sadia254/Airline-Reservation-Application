using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Airline_Reservation_Application.Models;
using Airline_Reservation_Application.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Airline_Reservation_Application.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PassengerPage : Page
    {
        List<Seat> Passengers;

        public PassengerPage()
        {
            this.InitializeComponent();

            Passengers = new List<Seat>();
            Passengers = BookingViewModel.GetSeats().FindAll(seat => seat.IsBooked);

            if (Passengers.Count == 0)
            {
                Passengers.Add(new Seat()
                {
                    FirstName = "There are no Seats booked yet."
                });
            }

            PassengersListView.ItemsSource = Passengers;

        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }
    }
}