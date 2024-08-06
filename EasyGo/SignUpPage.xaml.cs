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

            var viewModel = DataContext as SignUpViewModel;
            if (viewModel != null)
            {
                viewModel.Username = username;
                viewModel.Password = password;
                // viewModel.ExecuteSignUp(null);
                viewModel.SignUpCommand.Execute(null);
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


