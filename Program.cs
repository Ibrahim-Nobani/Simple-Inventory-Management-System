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
                    inventory.ViewAllProducts();
                }
                else if (choice == 3){
                    Console.WriteLine("Enter the product name you wish to modify: ");
                    string name = Console.ReadLine();
                    inventory.EditProduct(name);
                }
                else if (choice == 5)
                {
                    Console.WriteLine("Enter the product name you are looking for:");
                    string name = Console.ReadLine();
                    inventory.SearchProduct(name);

                }
                else if (choice == 6)
                {
                    Console.WriteLine("Getting the Fuck out");
                    return;
                }
                else
                {
                    Console.WriteLine("Invalid choice. Please try again.");
                }

                Console.WriteLine();
            }
        }
    }

}
