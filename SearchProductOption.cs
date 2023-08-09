namespace SimpleInventory
{
    class SearchProductOption : IObjectInteractive
    {
        public void Execute(Inventory inventory)
        {
            Console.WriteLine("Enter the product name you are looking for:");
            string name = Console.ReadLine();
            var product = inventory.RetrieveProduct(name);
            if (product != null)
            {
                Console.WriteLine($"{product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
            }
            else
            {
                Console.WriteLine("The product does not exist!");
            }

        }
    }
}