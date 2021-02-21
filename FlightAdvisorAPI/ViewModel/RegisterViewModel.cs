using FlightAdvisorAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlightAdvisorAPI.ViewModel
{
    public class RegisterViewModel
    {
        public Window Window { get; set; } = new Window();
        public String Firstname { get; set; }
        public String Lastname { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public String Salt { get; set; }
        public String HashedPass { get; set; }
        public String Role { get; set; }
        public MyICommand AddUser { get; set; }
        public MyICommand LoginPage { get; set; }

        public RegisterViewModel()
        {
            AddUser = new MyICommand(onAddNew);
            LoginPage = new MyICommand(OnLoginPage);

        }

        public void OnLoginPage()
        {
            Window.Hide();
            Window = new MainWindow();
            Window.DataContext = new LoginViewModel() { Window = Window };
            Window.Show();
        }

        public void onAddNew()
        {
            bool check = true;
            #region proveraUnosa
            if (String.IsNullOrEmpty(Firstname))
            {
                check = false;
                MessageBox.Show("You did not fill firstname box!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (Firstname.Length < 4)
                {
                    check = false;
                    MessageBox.Show("Firstname must contains at least 4 characters!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            if (String.IsNullOrEmpty(Lastname))
            {
                check = false;
                MessageBox.Show("You did not fill lastname box!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (Lastname.Length < 4)
                {
                    check = false;
                    MessageBox.Show("Lastname must contains at least 4 characters!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            if (String.IsNullOrEmpty(Username))
            {
                check = false;
                MessageBox.Show("You did not fill Username box!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (Username.Length < 4)
                {
                    check = false;
                    MessageBox.Show("Username must contains at least 4 characters!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }
            if (String.IsNullOrEmpty(Password))
            {
                check = false;
                MessageBox.Show("You did not fill Password box!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            else
            {
                if (Password.Length < 4)
                {
                    check = false;
                    MessageBox.Show("Password must contains at least 4 characters!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                }
            }

            #endregion

            if (check)
            {
                Users novi = new Users();
                novi.InsertUsers(Firstname, Lastname, Username, Password,Salt);

                MessageBox.Show("You have succsessfuly added new user:\nUsername: " + Username + "\nFull name: " + Firstname + "," + Lastname, "Info", MessageBoxButton.OK, MessageBoxImage.Information);

            }
            
        }
    }
}
