using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Airline_Reservation_Application.Models;
using Airline_Reservation_Application.ViewModels;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Popups;
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
    public sealed partial class BookingPage : Page
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string Company { get; set; }
        string PhoneNumber { get; set; }

        List<Seat> AllSeats { get; set; }
        List<Seat> AvailableSeats { get; set; }
        Seat SelectedSeat { get; set; }
        int SelectedIndex { get; set; }

        public BookingPage()
        {
            this.InitializeComponent();
            FirstName = String.Empty;
            LastName = String.Empty;
            Company = String.Empty;
            PhoneNumber = String.Empty;
            SelectedIndex = -1;
        }

        private void BackButton_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.GoBack();
        }

        private async void BookPassengerButton_Click(object sender, RoutedEventArgs e)
        {
            string error = String.Empty;


            if (FirstName == String.Empty)
            {
                error += "First name can't be empty\n";
            }

            if (LastName == String.Empty)
            {
                error += "Last name can't be empty\n";
            }

            if (PhoneNumber == String.Empty)
            {
                error += "Phone Number can't be empty\n";
            }

            if (SelectedIndex == -1)
            {
                error += "You need to select a seat number\n";
            }

            if (error == String.Empty)
            {
                this.AllSeats = BookingViewModel.BookSeat(new Seat()
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    Company = Company,
                    PhoneNumber = PhoneNumber,
                    Number = SelectedSeat.Number,
                    IsBooked = true
                });

                var dialog = new MessageDialog(String.Format("Seat #{0} booked succesfully.", SelectedSeat.Number));
                await dialog.ShowAsync();

                this.Frame.GoBack();
            }
            else
            {
                var dialog = new MessageDialog(error);
                await dialog.ShowAsync();
            }



        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.AllSeats = new List<Seat>();
            this.AllSeats.AddRange(BookingViewModel.GetSeats());
            CalculateAvailableSeats();
        }

        private void CalculateAvailableSeats()
        {
            this.AvailableSeats = new List<Seat>();
            this.AvailableSeats.AddRange(AllSeats.FindAll(seat => !seat.IsBooked));
        }
    }
}
