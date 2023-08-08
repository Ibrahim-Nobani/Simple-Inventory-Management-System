namespace SimpleInventory
{
    public class Inventory
    {
        public List<Product> products;
        public Inventory()
        {
            products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            products.Add(product);
        }
        public bool SearchProduct(String name)
        {
            foreach (Product product in products)
            {
                if (product.GetName().Equals(name))
                {
                    Console.WriteLine("The product you are looking for exists!");
                    return true;
                }
            }
            Console.WriteLine("The product you are looking is no where to be found!");
            return false;
        }

        public void ViewAllProducts()
        {
            foreach (Product product in products)
            {
                Console.WriteLine($"{product.GetName()}, Price: {product.Price}, Quantity: {product.Quantity}");
            }
        }
    }
}