using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services.Products
{
    public class Update
    {
        public void updateProd()
        {
            try
            {
                //Context
                ProductContext productContext = new ProductContext();
                Product product = new Product();
                var prod = productContext.products.Find(8);
                if (prod != null)
                {
                    //unchanged
                    Console.WriteLine($"Before Updating Entity State: {productContext.Entry(product).State}");
                    prod.name = "Red T-shirt";
                    prod.description = "Red colorful T-shirt";
                    //save changes
                    //modified
                    Console.WriteLine($"After Updating Entity State: {productContext.Entry(product).State}");
                    productContext.SaveChanges();
                    //unchanged - reset to the state
                    Console.WriteLine($"After Saving Entity State: {productContext.Entry(product).State}");
                    Console.WriteLine("Updated successfully");
                }
                else
                {
                    Console.WriteLine("Student with ID not found");
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
