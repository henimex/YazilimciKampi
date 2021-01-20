using System;

namespace OOP1
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Masa";
            product1.UnitPrice = 500;
            product1.UnitStock = 3;

            Product product2 = new Product { id = 2, CategoryId = 3, ProductName = "Ayna", UnitStock = 9, UnitPrice = 50 };

            ProductManager pm = new ProductManager();
            pm.Add(product1);
        }
    }
}
