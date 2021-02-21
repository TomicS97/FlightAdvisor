using FlightAdvisorAPI.Model;
using FlightAdvisorAPI.View;
using FlightAdvisorAPI.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace FlightAdvisorAPI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            
            InitializeComponent();
            this.DataContext = new LoginViewModel() { Window = this };
            

        }
        private void promena(object sender, RoutedEventArgs e)
        {
            ((LoginViewModel)this.DataContext).Password = passBox.Password;
        }

        private void LoginButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}