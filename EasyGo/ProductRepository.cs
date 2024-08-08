using EasyGo.Models;
using System.Collections.Generic;

public class ProductRepository
{
    public List<Product> GetProducts()
    {
        return new List<Product>
        {
            new Product { Name = "Mountain Bike", Price = 499.99m, ImagePath = "Images/bike1.jpg", Description = "A great mountain bike for off-road adventures." },
            new Product { Name = "Road Bike", Price = 399.99m, ImagePath = "Images/bike2.jpg", Description = "Perfect for smooth rides on paved roads." },
            // Add other products
        };
    }
}
