using FlightAdvisorAPI.Model;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace FlightAdvisorAPI.ViewModel
{
    public class AdminViewModel
    {
        public Window Window { get; set; }
        public String CityName { get; set; }
        public String CountryName { get; set; }
        public String DescriptCity { get; set; }
        public String SelectedPath { get; set; }
        public String IspisPutanje { get; set; }
        public String User { get; set; }
        public MyICommand AddCity { get; set; }
        public MyICommand Logout { get; set; }
        public MyICommand Browse { get; set; }


        public AdminViewModel(string username)
        {
            AddCity = new MyICommand(OnAddCity);
            Logout = new MyICommand(OnLogout);
            Browse = new MyICommand(OnBrowse);

            User = username;
        }

        private void OnBrowse()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Textfiles|*.txt";
            openFileDialog.Multiselect = false;
            Nullable<bool> dialogOK = openFileDialog.ShowDialog();

            if (dialogOK == true)
            {
                foreach (var item in openFileDialog.FileNames)
                {
                    IspisPutanje = item.ToString();
                }
            }
        }

        public void OnLogout()
        {
            Window.Hide();
            Window = new MainWindow();
            Window.DataContext = new LoginViewModel() { Window = Window };
            Window.Show();
        }

        public void OnAddCity()
        {
            bool check = true;
            //bool logged = false;
            bool ciname = false;
            bool coname = false;
            bool descname = false;

            if (String.IsNullOrEmpty(CityName))
            {
                ciname = true;
                check = false;
                MessageBox.Show("You need to fill City name box to proceed!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (!ciname && CityName.Length < 2)
            {
                check = false;
                MessageBox.Show("City name must contains 2 caracters at least!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (String.IsNullOrEmpty(CountryName))
            {
                coname = true;
                MessageBox.Show("You need to fill Country name box to proceed!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            if (!coname && CountryName.Length < 2)
            {
                check = false;
                MessageBox.Show("Country name must contains 2 caracters at least!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            if (String.IsNullOrEmpty(DescriptCity))
            {
                descname = true;
                check = false;
                MessageBox.Show("You need to fill Description box to proceed!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (!descname && DescriptCity.Length < 2)
            {
                check = false;
                MessageBox.Show("Description must contains 2 caracters at least!", "Error!", MessageBoxButton.OK, MessageBoxImage.Error);
            }

            if (check)
            {
                City sql = new City();
                sql.InserCity(CityName, CountryName, DescriptCity);
                Airports a = new Airports();
                a.SqlAir();
                Routes r = new Routes();
                r.UpdateNewRoute(CityName);
                MessageBox.Show("Dodali ste novi grad", "OK", MessageBoxButton.OK, MessageBoxImage.Information);

            }
        }
    }
}
