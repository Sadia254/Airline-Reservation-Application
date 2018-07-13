using System;
using System.Collections.Generic;
using System.IO;
using System.IO.IsolatedStorage;
using System.Runtime.Serialization;
using System.Text.RegularExpressions;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using WinUX.Mvvm.Services;
// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Airline_Reservation_Application.Views
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Signup_page : Page
    {
        IsolatedStorageFile ISOFile = IsolatedStorageFile.GetUserStoreForApplication();
       // private MessageBox MessageBox;
        
        private string gender;

        public IEnumerable<object> ObjUserDataList { get; private set; }

        private void Submit_Click(object sender, RoutedEventArgs e)

        {

            //UserName Validation   

            if (!Regex.IsMatch(TxtUserName.Text.Trim(), @"^[A-Za-z_][a-zA-Z0-9_\s]*$"))

            {

              //  //MessgeBox.Show("Invalid UserName");

            }



            //Password length Validation   

            else if (TxtPwd.Password.Length < 6)

            {

                //MessageBox.Show("Password length should be minimum of 6 characters!");

            }



            //Address Text Empty Validation   

            else if (TxtAddr.Text == "")

            {

                //MessageBox.Show("Please enter your address!");

            }



            //Gender Selection Empty Validation   

            else if (gender == "")

            {

                //MessageBox.Show("Please select gender!");

            }



            //Phone Number Length Validation   

            else if (TxtPhNo.Text.Length != 10)

            {

                //MessageBox.Show("Invalid PhonNo");

            }



            //EmailID validation   

            else if (!Regex.IsMatch(TxtEmail.Text.Trim(), @"^([a-zA-Z_])([a-zA-Z0-9_\-\.]*)@(\[((25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\.){3}|((([a-zA-Z0-9\-]+)\.)+))([a-zA-Z]{2,}|(25[0-5]|2[0-4][0-9]|1[0-9][0-9]|[1-9][0-9]|[0-9])\])$"))

            {

                //MessageBox.Equals("Invalid EmailId");

            }



            //After validation success ,store user detials in isolated storage   

            else if (TxtUserName.Text != "" && TxtPwd.Password != "" && TxtAddr.Text != "" && TxtEmail.Text != "" && gender != "" && TxtPhNo.Text != "")

            {

                UserData ObjUserData = new UserData();

                ObjUserData.UserName = TxtUserName.Text;

                ObjUserData.Password = TxtPwd.Password;

                ObjUserData.Address = TxtAddr.Text;

                ObjUserData.Email = TxtEmail.Text;

                ObjUserData.Gender = gender;

                ObjUserData.PhoneNo = TxtPhNo.Text;

                int Temp = 0;

                foreach (var UserLogin in ObjUserDataList)

                {

                    //if (ObjUserData.UserName == UserLogin.UserName)

                    //{

                    //    Temp = 1;

                    //}

                }

                //Checking existing user names in local DB   

                if (Temp == 0)

                {

                  //  ObjUserDataList.Add(ObjUserData);

                    if (ISOFile.FileExists("RegistrationDetails"))

                    {

                        ISOFile.DeleteFile("RegistrationDetails");

                    }

                    using (IsolatedStorageFileStream fileStream = ISOFile.OpenFile("RegistrationDetails", FileMode.Create))

                    {

                        DataContractSerializer serializer = new DataContractSerializer(typeof(List<UserData>));



                        serializer.WriteObject(fileStream, ObjUserDataList);



                    }

                    //MessageBox.Show("Congrats! your have successfully Registered.");

                  //  NavigationService.Navigate(new Uri("/Views/Login.xaml", UriKind.Relative));

                }

                else

                {

                    //MessageBox.Show("Sorry! user name is already existed.");

                }



            }

            else

            {

                //MessageBox.Show("Please enter all details");

            }

        }
    }

    internal class UserData
    {
        internal string UserName;

        public string Password { get; internal set; }
        public string Address { get; internal set; }
        public string Email { get; internal set; }
        public string Gender { get; internal set; }
        public string PhoneNo { get; internal set; }
    }
}
