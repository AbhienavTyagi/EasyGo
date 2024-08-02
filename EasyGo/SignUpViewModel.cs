using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;



namespace EasyGo
{
    public class SignUpViewModel : INotifyPropertyChanged
    {
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

        public ICommand SignUpCommand { get; }

        public SignUpViewModel()
        {
            SignUpCommand = new RelayCommand(ExecuteSignUp);
        }

        private void ExecuteSignUp()
        {
            if (string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password))
            {
                Message = "Please enter a valid username and password.";
                return;
            }

            var userRegistered = UserRepository.RegisterUser(Username, Password);

            if (userRegistered)
            {
                Message = "Registration successful!";
                // Navigate to the home page or any other page
            }
            else
            {
                Message = "Registration failed. User already exists.";
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}



