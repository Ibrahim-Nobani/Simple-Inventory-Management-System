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

    public void ViewAllProducts()
    {
        foreach (Product product in products)
        {
            Console.WriteLine($"{product.GetName()}, Price: {product.Price}, Quantity: {product.Quantity}");
        }
    }
    }
}