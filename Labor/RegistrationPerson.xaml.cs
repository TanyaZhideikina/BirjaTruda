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
    public partial class RegistrationPerson : Window
    {
        public RegistrationPerson()
        {
            InitializeComponent();
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "C:/Users/tanya/Downloads/Labor (1)/Labor/Labor/Resources/background.jpg"));
            this.Background = myBrush;
        }

      
    }
}
