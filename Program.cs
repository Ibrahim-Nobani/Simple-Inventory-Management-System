using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SimpleInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            while (true)
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1. Add a product");
                Console.WriteLine("2. View all products");
                Console.WriteLine("3. Edit a product");
                Console.WriteLine("4. Delete a product");
                Console.WriteLine("5. Search for a product");
                Console.WriteLine("6. Exit");

                int choice;
                if (!int.TryParse(Console.ReadLine(), out choice))
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (choice == 1)
                {
                    Console.WriteLine("Enter the product name:");
                    string name = Console.ReadLine();

                    Console.WriteLine("Enter the product price:");
                    decimal price = decimal.Parse(Console.ReadLine());

                    Console.WriteLine("Enter the product quantity:");
                    int quantity = int.Parse(Console.ReadLine());

                    inventory.AddProduct(new Product(name, price, quantity));
                }
                else if (choice == 2)
                {
                    ViewAllProducts(inventory);
                }
                else if (choice == 3)
                {
                    EditProductDetails(inventory);
                }
                else if (choice == 4)
                {
                    Console.WriteLine("Enter the product name you wish to delete: ");
                    string name = Console.ReadLine();
                    inventory.DeleteProduct(name);
                }
                else if (choice == 5)
                {
                    SearchProduct(inventory);
                }
                else if (choice == 6)
                {
                    Console.WriteLine("Exiting");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

                Console.WriteLine();
            }

            void ViewAllProducts(Inventory inventory)
            {
                foreach (var product in inventory.RetrieveAllProducts())
                {
                    Console.WriteLine($"{product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
                }
            }

            void EditProductDetails(Inventory inventory)
            {
                Console.WriteLine("Enter the product name you wish to modify: ");
                string name = Console.ReadLine();
                Product product = inventory.RetrieveProduct(name);
                if (product != null)
                {
                    Console.WriteLine("Enter The new Product name: ");
                    string newName = Console.ReadLine();
                    Console.WriteLine("Enter the new Product price: ");
                    decimal newPrice = decimal.Parse(Console.ReadLine());
                    Console.WriteLine("Enter the new Product quantity: ");
                    int newQuantity = int.Parse(Console.ReadLine());
                    inventory.EditProduct(product, newName, newPrice, newQuantity);
                }
            }

            void SearchProduct(Inventory inventory)
            {
                Console.WriteLine("Enter the product name you are looking for:");
                string name = Console.ReadLine();
                var product = inventory.RetrieveProduct(name);
                if (product != null)
                {
                    Console.WriteLine($"The product {product.Name} exists!");
                }
                else
                {
                    Console.WriteLine("The product does not exist!");
                }

            }
        }
    }
}
