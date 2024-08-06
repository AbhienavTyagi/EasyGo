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
using System.Windows.Shapes;

namespace EasyGo
{
    public partial class MainWindow : Window
    {
        private LoginViewModel loginViewModel;
        public MainWindow()
        {
            InitializeComponent();
            ShowHomePage();
        }

        public void ShowHomePage()
        {
            MainContent.Navigate(new HomePage());
        }

        public void ShowLoginPage()
        {
            var loginPage = new LoginPage();
            loginViewModel = loginPage.DataContext as LoginViewModel;
            if (loginViewModel != null)
            {
                loginViewModel.LoginSuccessful += OnLoginSuccessful;
            }
            MainContent.Content = loginPage;
        }

        private void OnLoginSuccessful()
        {
            ShowHomePage();
        }

        // public void ShowLoginPage()
        //{
        //    MainContent.Navigate(new LoginPage());
        //}

        private void HomeMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ShowHomePage();
        }

        private void AboutUsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new AboutUsPage());
        }

        private void LoginMenuItem_Click(object sender, RoutedEventArgs e)
        {
            ShowLoginPage();
        }

        private void SignUpMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new SignUpPage());
        }

        private void ViewProductsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new ViewProductsPage());
        }

        private void ContactUsMenuItem_Click(object sender, RoutedEventArgs e)
        {
            MainContent.Navigate(new ContactUsPage());
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

