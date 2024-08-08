using System.Windows;
using System.Windows.Controls;


namespace EasyGo
{
    public partial class SignUpPage : Page
    {
        public SignUpPage()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            var username = UsernameTextBox.Text;
            var password = PasswordBox.Password;
            var firstName = FirstNameTextBox.Text;
            var lastName = LastNameTextBox.Text;
            var city = CityTextBox.Text;
            var postalCode = PostalCodeTextBox.Text;
            var mobileNumber = MobileNumberTextBox.Text;

            var viewModel = DataContext as SignUpViewModel;
            if (viewModel != null)
            {
                viewModel.Username = username;
                viewModel.Password = password;
                viewModel.FirstName = firstName;
                viewModel.LastName = lastName;
                viewModel.City = city;
                viewModel.PostalCode = postalCode;
                viewModel.MobileNumber = mobileNumber;

                // Execute the command
                //viewModel.SignUpCommand.Execute(null);
                viewModel.ExecuteSignUp(null);

                // Set the message on successful registration
                //MessageTextBlock.Text = viewModel.Message;  // Ensure MessageTextBlock is defined in your XAML
            }
        }
        private void PasswordBox_PasswordChanged(object sender, RoutedEventArgs e)
        {
            if (this.DataContext != null)
            {
                ((SignUpViewModel)this.DataContext).Password = ((PasswordBox)sender).Password;
            }
        }
    }
}


