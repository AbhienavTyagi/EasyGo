using System.Collections.Generic;
using System.Linq;

namespace EasyGo
{
	public class ProductRepository
	{
		private List<Product> products;

		public ProductRepository()
		{
			products = new List<Product>
			{
				//new Product { Id = 1, Name = "Mountain Bike", ImageUrl = "Images/bike1.jpg", Price = 499.99m, Description = "A high-quality mountain bike." },
				//new Product { Id = 2, Name = "Road Bike", ImageUrl = "Images/bike2.jpg", Price = 399.99m, Description = "A fast and light road bike." }
                // Add more products here
            };
		}

		public List<Product> GetAllProducts()
		{
			return products;
		}

		public Product GetProductById(int id)
		{
			return products.FirstOrDefault(p => p.Id == id);
		}
	}
}
