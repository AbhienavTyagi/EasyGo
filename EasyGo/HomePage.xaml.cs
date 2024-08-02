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
    public partial class HomePage : UserControl
    {
        public HomePage()
        {
            InitializeComponent();
        }

        private void ShopNowButton_Click(object sender, RoutedEventArgs e)
        {
            var mainWindow = Window.GetWindow(this) as MainWindow;
            mainWindow?.ShowLoginPage(); // Example action; adjust as needed
        }

        private void ViewDetailsButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Details for the selected product will be shown here.");
            // Navigate to product details page or show product details in a popup
        }
    }
}
