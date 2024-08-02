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
    public partial class SignUpPage : UserControl
    {
        public SignUpPage()
        {
            InitializeComponent();
            DataContext = new SignUpViewModel(); // Set the DataContext to the ViewModel
        }

        private void UsernameTextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (UsernameTextBox != null && UsernamePlaceholder != null)
            {
                if (string.IsNullOrEmpty(UsernameTextBox.Text))
                {
                    UsernamePlaceholder.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void UsernameTextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (UsernameTextBox != null && UsernamePlaceholder != null)
            {
                if (string.IsNullOrEmpty(UsernameTextBox.Text))
                {
                    UsernamePlaceholder.Visibility = Visibility.Visible;
                }
                else
                {
                    UsernamePlaceholder.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void PasswordBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordBox != null && PasswordPlaceholder != null)
            {
                if (string.IsNullOrEmpty(PasswordBox.Password))
                {
                    PasswordPlaceholder.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void PasswordBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (PasswordBox != null && PasswordPlaceholder != null)
            {
                if (string.IsNullOrEmpty(PasswordBox.Password))
                {
                    PasswordPlaceholder.Visibility = Visibility.Visible;
                }
                else
                {
                    PasswordPlaceholder.Visibility = Visibility.Collapsed;
                }
            }
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            if (DataContext is SignUpViewModel viewModel)
            {
                // Update the ViewModel with the password from the PasswordBox
                viewModel.Password = PasswordBox.Password;

                // Validate input
                if (string.IsNullOrWhiteSpace(UsernameTextBox.Text))
                {
                    MessageBox.Show("Username cannot be empty.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                if (string.IsNullOrWhiteSpace(PasswordBox.Password))
                {
                    MessageBox.Show("Password cannot be empty.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Warning);
                    return;
                }

                // Execute Sign-Up Command
                if (viewModel.SignUpCommand.CanExecute(null))
                {
                    viewModel.SignUpCommand.Execute(null);
                }
            }
            else
            {
                MessageBox.Show("ViewModel not found. Ensure DataContext is set correctly.", "Error", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}


