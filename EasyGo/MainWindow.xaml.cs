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


namespace EasyGo
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            ShowHomePage();
        }

        public void ShowHomePage()
        {
            MainContent.Content = new HomePage();
        }

        public void ShowLoginPage()
        {
            MainContent.Content = new LoginPage();
        }

        private void HomeMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ShowHomePage();
        }

        private void AboutUsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new AboutUsPage();
        }

        private void LoginMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ShowLoginPage();
        }

        private void SignUpMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new SignUpPage();
        }

        private void ViewProductsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Content = new ViewProductsPage();
        }
    }
}

