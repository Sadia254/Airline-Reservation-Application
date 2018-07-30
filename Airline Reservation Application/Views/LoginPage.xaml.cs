using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
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
    public sealed partial class LoginPage : Page
    {
        public string Username;
        public string Password;

        public LoginPage()
        {
            this.InitializeComponent();
        }

        private void AcceptBtn_Click(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(HomePage));
       
        }

        private async void LoginButton_Click(object sender, RoutedEventArgs e)
        {
            string error = String.Empty;


            if (Username == String.Empty)
            {
                error += "User name can't be empty\n";
            }

            if (Username == String.Empty)
            {
                error += "Password can't be empty\n";
            }

            if (error == String.Empty)
            {
                if (Login.LoginAction(Username, Password))
                {
                    this.Frame.Navigate(typeof(HomePage));
                }
            }
            else
            {
                var dialog = new MessageDialog(error);
                await dialog.ShowAsync();
            }

        }
    }
}

