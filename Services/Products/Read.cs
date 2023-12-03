using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services.Products
{
    public class Read
    {
        public void readProducts()
        {
            try
            {
            ProductContext context = new ProductContext();
            //used mosly in querying db
            List<Product> products = context.products.ToList();
                Console.WriteLine("Get All products from Database");
            foreach (var prod in products)
            {
                    Console.WriteLine($"{prod.id}:{prod.name}: at {Convert.ToInt32(prod.price)} ksh");
            }
            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
