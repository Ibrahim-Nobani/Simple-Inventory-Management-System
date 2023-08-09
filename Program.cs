using System;
using System.Collections.Generic;
namespace SimpleInventory
{
    class Program
    {
        static void Main(string[] args)
        {
            Inventory inventory = new Inventory();

            IObjectInteractive[] Options = new IObjectInteractive[]
            {
                new AddProductOption(),
                new ViewAllProductsOption(),
                new EditProductOption(),
                new DeleteProductOption(),
                new SearchProductOption()
            };

            while (true)
            {
                DisplayMenu();

                int choice;

                if (!int.TryParse(Console.ReadLine(), out choice) || choice > 6)
                {
                    Console.WriteLine("Invalid input. Please enter a number.");
                    continue;
                }

                if (choice == 6)
                {
                    Console.WriteLine("Exiting...");
                    return;
                }

                Options[choice - 1].Execute(inventory);
                Console.WriteLine();
            }
            void DisplayMenu()
            {
                Console.WriteLine("Select an option:");
                Console.WriteLine("1- Add a product");
                Console.WriteLine("2- View all products");
                Console.WriteLine("3- Edit a product");
                Console.WriteLine("4- Delete a product");
                Console.WriteLine("5- Search for a product");
                Console.WriteLine("6- Exit");
            }
        }
    }
}

