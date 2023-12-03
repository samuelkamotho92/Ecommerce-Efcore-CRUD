using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;

namespace Ecommerce.Entities
{
    public class ProductContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Load connection file
            var configBuilder = new ConfigurationBuilder().AddJsonFile("applicationSettings.json").Build();

            //reading the fle
          var configSection =  configBuilder.GetSection("ConnectionStrings");

            //get value of string based on the key
          var connectionStrig =  configSection["SQLServerConnection"] ?? null;

            //Connection string
            optionsBuilder.UseSqlServer(connectionStrig);
        }
        
        public DbSet<Product> products { get; set;}
       
    }
}
