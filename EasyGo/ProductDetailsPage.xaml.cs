using System.Windows.Controls;

namespace EasyGo
{
    public partial class ProductDetailsPage : UserControl
    {
        public ProductDetailsPage(Product product)
        {
            InitializeComponent();
            DataContext = product;
        }
    }
}
