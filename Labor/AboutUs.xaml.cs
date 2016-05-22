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

namespace Labor
{
    /// <summary>
    /// Interaction logic for AboutUs.xaml
    /// </summary>
    public partial class AboutUs : Window
    {
        private Page priveosPage;
        public AboutUs(Page priveosPage)
        {
            InitializeComponent();
            this.priveosPage = priveosPage;
        }

        private void AboutUsExit_click(object sender, RoutedEventArgs e)
        {
            
            this.aboutUsFrame.Navigate(priveosPage);
           // this.Content = priveosPage;
        }
    }
}
