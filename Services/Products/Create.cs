using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services.Products
{
    public class Create
    {
        public void createProduct()
        {
            try
            {
                //Input enter value
                Console.WriteLine("Enter Product Name");
                string productName = Console.ReadLine();
                Console.WriteLine("Enter Product Description");
                string productDesc = Console.ReadLine();
                Console.WriteLine("Enter Product Price");
                decimal productPrice = int.Parse(Console.ReadLine());


                ProductContext context = new ProductContext();
                Product product = new Product()
                {
                    name = productName,
                    description = productDesc,
                    price = productPrice
                };
                Console.WriteLine($"Before adding content the entry state {context.Entry(product).State}");               
                context.products.Add(product);
                Console.WriteLine($"Before adding content the entry state {context.Entry(product).State}");
                context.SaveChanges();
                Console.WriteLine($"After saving content the entry state {context.Entry(product).State}");
                Console.WriteLine($"created {product.name} successfully");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
