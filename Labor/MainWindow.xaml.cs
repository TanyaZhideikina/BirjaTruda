using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Input;

namespace Labor
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            SetImage();
        }

        public void SetImage()
        {
            ImageBrush myBrush = new ImageBrush();
            myBrush.ImageSource = new BitmapImage(new Uri(BaseUriHelper.GetBaseUri(this), "background.jpg"));
            this.Background = myBrush;
        }

        private void EnterClick(object sender, RoutedEventArgs e)
        {
            WorkSpace workspace = new WorkSpace();
            workspace.Show();
            this.Close();
            workspace.Activate();
            //this.Content = workspace;
        }

        private void Hyperlink_Click(object sender, RoutedEventArgs e)
        {
            RegistrationNewUser registrationNewUser = new RegistrationNewUser();
            registrationNewUser.Show();
            registrationNewUser.Activate();
            //this.Content = registrationNewUser;
        }

        private void Key_Down(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.CapsLock)
            {
                if (e.IsToggled)
                {
                    CapsLock.Text = "CapsLock pressed";
                }
                else
                {
                    CapsLock.Text = "CapsLock is not pressed";
                }
            }
        }
    }
}
