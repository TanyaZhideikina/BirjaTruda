using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace Labor
{
    /// <summary>
    /// Interaction logic for RegistrationPerson.xaml
    /// </summary>
    public partial class ClientBaseWorkSpace : Window
    {
        public ClientBaseWorkSpace()
        {
            InitializeComponent();
           
        }

        private void CreateNewUser(object sender, RoutedEventArgs e)
        {
            RegistrationPerson registrationPerson = new RegistrationPerson();
            //this.Content = registrationPerson;
            registrationPerson.Show();
            registrationPerson.Activate();
        }

    }
}
