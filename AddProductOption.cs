namespace SimpleInventory
{
    class AddProductOption : IObjectInteractive
    {
        public void Execute(Inventory inventory)
        {
            Console.WriteLine("Enter the product name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter the product price:");
            decimal price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the product quantity:");
            int quantity = int.Parse(Console.ReadLine());

            inventory.AddProduct(new Product(name, price, quantity));
        }
    }
}