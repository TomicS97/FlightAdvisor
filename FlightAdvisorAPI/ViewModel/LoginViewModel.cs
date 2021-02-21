using FlightAdvisorAPI.Model;
using FlightAdvisorAPI.View;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace FlightAdvisorAPI.ViewModel
{
    public class LoginViewModel
    {
        public Window Window { get; set; }
        public String Username { get; set; }
        public String Password { get; set; }
        public string UsernameLogin { get; set; }
        public MyICommand LoginCommand { get; set; }
        public MyICommand RegisterCommand { get; set; }
        

        public LoginViewModel()
        {
            LoginCommand = new MyICommand(OnLogin);
            RegisterCommand = new MyICommand(OnRegister);
        }

        private void OnRegister()
        {
            Window.Title = "Flight Advisor - Registration";
            Window.Content = new Register();
            Window.DataContext = new RegisterViewModel() { Window = Window };
        }

        public void OnLogin()
        {
            bool check = true;
            bool logged = false;
            bool userNull = false;
            bool passNull = false;

            if (String.IsNullOrEmpty(Username))
            {
                userNull = true;
                check = false;
                MessageBox.Show("You need to fill username box to proceed!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (!userNull && Username.Length < 2)
            {
                check = false;
                MessageBox.Show("Username must contains 2 caracters at least!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (String.IsNullOrEmpty(Password))
            {
                MessageBox.Show("You need to fill password box to proceed!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!passNull && Password.Length < 2)
            {
                check = false;
                MessageBox.Show("Password must contains 2 caracters at least!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (check)
            {
                List<Tuple<string, string>> pp = new List<Tuple<string, string>>();
                Users sql = new Users();

                pp = sql.getAllUsers();                       

                int role = 0;
                string usernick;

                foreach (var item in pp)
                {
                    usernick = item.Item1.Substring(1);
                    if (usernick == Username && item.Item2==Password)
                    {
                        logged = true;
                        role = Int32.Parse(item.Item1.Substring(0, 1));
                        UsernameLogin = usernick;
                        break;
                    }
                    

                }
                if (!logged)
                {
                    MessageBox.Show("You entered username or password wrong! Try again", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
                }
                switch (role)
                {
                    case 1:
                        Window.Title = "Flight Advisor - Welcome " + UsernameLogin;
                        Window.Content = new AdminView();
                        Window.DataContext = new AdminViewModel(UsernameLogin) { Window = Window };
                        MessageBox.Show("Ulogovali ste se.\nUloga: Admin", "OK", MessageBoxButton.OK, MessageBoxImage.Information);
                        
                        break;
                    case 2:
                        Window.Title = "Flight Advisor - Welcome " + UsernameLogin;
                        Window.Content = new Regular();
                        Window.DataContext = new RegularViewModel(UsernameLogin) { Window = Window };
                        MessageBox.Show("Ulogovali ste se.\nUloga: Regular", "OK", MessageBoxButton.OK, MessageBoxImage.Information);
                        break;
                    default:

                        break;
                }

            }
        }
        
    }
}
