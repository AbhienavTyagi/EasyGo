using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Windows.Input;

using System.Runtime.CompilerServices;
using System.Windows;

namespace EasyGo
{
    public class LoginViewModel : INotifyPropertyChanged
    {
       // public event PropertyChangedEventHandler PropertyChanged;
        public event Action LoginSuccessful; // Event to notify login success

        private string _username;
        private string _password;
        private string _message;

        public string Username
        {
            get => _username;
            set
            {
                _username = value;
                OnPropertyChanged();
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                _password = value;
                OnPropertyChanged();
            }
        }

        public string Message
        {
            get => _message;
            set
            {
                _message = value;
                OnPropertyChanged();
            }
        }

        public RelayCommand LoginCommand { get; }

        public LoginViewModel()
        {
            LoginCommand = new RelayCommand(ExecuteLogin);
        }

        private void ExecuteLogin(object parameter)
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                Message = "Please enter a valid username and password.";
                return;
            }

            var user = UserRepository.GetUser(Username, Password);

            if (user != null)
            {
                Message = "Login successful!";
                // Navigate to the home page or any other page
                LoginSuccessful?.Invoke(); // Trigger the event
            }
            else
            {
                Message = "Invalid username or password.";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
