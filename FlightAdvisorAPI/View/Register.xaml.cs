using FlightAdvisorAPI.ViewModel;
using System;
using System.Collections.Generic;
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

namespace FlightAdvisorAPI.View
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
            this.DataContext = new RegisterViewModel() { Password = PasswordInput.Password };
        }


        private void PasswordInput_PasswordChanged(object sender, RoutedEventArgs e)
        {
                ((RegisterViewModel)this.DataContext).Password = PasswordInput.Password;
        }
    }
}
