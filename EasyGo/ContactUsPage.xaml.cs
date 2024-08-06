using System;
using System.Windows;
using System.Windows.Controls;
//using EasyGo.Data;
using EasyGo.Models;

namespace EasyGo
{
    public partial class ContactUsPage : Page
    {
        private ApplicationDbContext _context;

        public ContactUsPage()
        {
            InitializeComponent();
            _context = new ApplicationDbContext();
        }

        private void SubmitButton_Click(object sender, RoutedEventArgs e)
        {
            // Collect data from the form
            string name = NameTextBox.Text;
            string email = EmailTextBox.Text;
            string subject = SubjectTextBox.Text;
            string message = MessageTextBox.Text;

            // Perform validation (you can add more sophisticated validation here)
            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) ||
                string.IsNullOrWhiteSpace(subject) || string.IsNullOrWhiteSpace(message))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            // Create a new ContactForm object
            var contactForm = new ContactForm
            {
                Name = name,
                Email = email,
                Subject = subject,
                Message = message
            };

            // Save the contact form to the database
            _context.ContactForms.Add(contactForm);
            _context.SaveChanges();

            // Provide feedback to the user
            MessageBox.Show("Thank you for contacting us! We will get back to you soon.", "Form Submitted", MessageBoxButton.OK, MessageBoxImage.Information);

            // Clear the form
            NameTextBox.Clear();
            EmailTextBox.Clear();
            SubjectTextBox.Clear();
            MessageTextBox.Clear();
        }
    }
}
