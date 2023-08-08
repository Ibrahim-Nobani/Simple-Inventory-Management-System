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
        public void EditProduct(String name)
        {
            Product product = SearchProduct(name);
            if (product != null)
            {
                Console.WriteLine("Enter The new Product name: ");
                string newName = Console.ReadLine();
                Console.WriteLine("Enter the new Product price: ");
                decimal newPrice = decimal.Parse(Console.ReadLine());
                Console.WriteLine("Enter the new Product quantity: ");
                int newQuantity = int.Parse(Console.ReadLine());
                product.SetName(newName);
                product.Price = newPrice;
                product.Quantity = newQuantity;
                //Console.WriteLine($"{product.GetName()}, Price: {product.Price}, Quantity: {product.Quantity}");
            }
        }
        public Product SearchProduct(String name)
        {
            foreach (Product product in products)
            {
                if (product.GetName().Equals(name))
                {
                    Console.WriteLine("The product you are looking for exists!");
                    return product;
                }
            }
            Console.WriteLine("The product you are looking is no where to be found!");
            return null;
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