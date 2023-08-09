namespace SimpleInventory
{
    public class DeleteProductOption : IObjectInteractive
    {
        public void Execute(Inventory inventory)
        {
            Console.WriteLine("Enter the product name you wish to delete: ");
            string name = Console.ReadLine();
            if (inventory.DeleteProduct(name))
            {
                Console.WriteLine("The product has been deleted");
            }
            else {
                Console.WriteLine("The product has not been found");
            }
        }
    }

}