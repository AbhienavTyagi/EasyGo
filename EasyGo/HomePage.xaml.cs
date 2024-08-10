using EasyGo.Models;
using System;
using System.Collections.Generic;
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
    public partial class HomePage : UserControl
    {
        public List<Product> Products { get; set; }
        public HomePage()
        {
            InitializeComponent();
            LoadProducts();
            DataContext = this;

        }

        private void LoadProducts()
        {
            Products = new List<Product>
            {
                new Product
                {
                    Name = "Mountain Bike",
                    ImagePath = "Images/bike1.jpg",
                    Price = 499.99m,
                    Description = "A rugged mountain bike suitable for all terrains."
                },
                new Product
                {
                    Name = "Road Bike",
                    ImagePath = "Images/bike2.jpg",
                    Price = 399.99m,
                    Description = "A sleek road bike for smooth and fast rides."
                },
                // Add more products as needed
            };
        }

        private void ViewDetailsButton_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            Product selectedProduct = button?.DataContext as Product;

            if (selectedProduct != null)
            {
               // ((MainWindow)Application.Current.MainWindow).NavigateToPage(new ProductDetailsPage(selectedProduct));
            }
        }

        private void ShopNowButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow?.ShowLoginPage(); // Example action; adjust as needed
        }

        //private void ViewDetailsButton_Click(object sender, RoutedEventArgs e)
        //{
        //    MessageBox.Show("Details for the selected product will be shown here.");
        //    // Navigate to product details page or show product details in a popup
        //}
    }
}
