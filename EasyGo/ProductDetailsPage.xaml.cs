using System.Windows.Controls;
using EasyGo.Models;

namespace EasyGo
{
    public partial class ProductDetailsPage : UserControl
    {
        private Product _product;

        public ProductDetailsPage(Product product)
        {
            InitializeComponent();
            _product = product;
            DataContext = _product;
        }
    }
}
