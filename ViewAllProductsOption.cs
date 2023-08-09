namespace SimpleInventory
{
    class ViewAllProductsOption : IObjectInteractive
    {
        public void Execute(Inventory inventory)
        {
            foreach (var product in inventory.RetrieveAllProducts())
            {
                Console.WriteLine($"{product.Name}, Price: {product.Price}, Quantity: {product.Quantity}");
            }
        }
    }
}