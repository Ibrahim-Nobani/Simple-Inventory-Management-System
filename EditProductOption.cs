namespace SimpleInventory
{
    public class EditProductOption : IObjectInteractive
    {
        public void Execute(Inventory inventory)
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
    }

}