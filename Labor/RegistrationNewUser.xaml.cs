using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;

namespace Labor
{
    /// <summary>
    /// Interaction logic for RegistrationNewUser.xaml
    /// </summary>
    public partial class RegistrationNewUser : Window
    {
        public RegistrationNewUser()
        {
            InitializeComponent();
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "background.jpg"));
            this.Background = myBrush;
        }

        private void Registration(object sender, RoutedEventArgs e)
        {
            
            //MainWindow mainWindow = new MainWindow();
            //this.Content = mainWindow.Content;
      
        }
    }
}
