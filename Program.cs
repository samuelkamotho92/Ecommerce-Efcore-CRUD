
using Ecommerce.Services.Products;
Console.WriteLine("Choose Options present");
Dictionary<int,string> options = new Dictionary<int,string>();
options.Add(1, "Create Products");
options.Add(2, "Read Products");
options.Add(3, "Update Product");
options.Add(4, "Delete Product");

foreach (var option in options)
{
    Console.WriteLine($"{option.Key}:{option.Value}");
}
int userInput = int.Parse(Console.ReadLine());
if(userInput == 1)
{
    Create productOne = new Create();
    productOne.createProduct();
}
else if(userInput == 2)
{
    Read read = new Read();
    read.readProducts();
} else if (userInput == 3)
{
    Console.WriteLine("Update Products");
    Update prodOne = new Update();
    prodOne.updateProd();
}else if(userInput == 4)
{
    Console.WriteLine("Deleting Product...");
    Delete deleteOne = new Delete();
    deleteOne.deleteProd();
}
else
{
    Console.WriteLine("Log out of application");
}


