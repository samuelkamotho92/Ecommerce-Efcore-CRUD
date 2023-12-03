using Ecommerce.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.Services.Products
{
    public class Delete
    {
        public void deleteProd()
        {
            try
            {
                ProductContext context = new ProductContext();
                //get context check on what you want to remove then remove it
                var prod = context.products.Find(10);
                if(prod != null)
                {
                    Console.WriteLine($"Entity state before removing {context.Entry(prod).State}");
                    context.products.Remove(prod);
                    Console.WriteLine($" state After removing {context.Entry(prod).State}");
                    context.SaveChanges();
                    Console.WriteLine($"After state saving {context.Entry(prod).State}");
                    Console.WriteLine("Successfuly deleted product");
                }
                else
                {
                    Console.WriteLine("The product with the Id does not exists");
                }
            


            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
