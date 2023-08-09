namespace SimpleInventory
{
    public class Inventory
    {
        public List<Product> Products;
        public Inventory()
        {
            Products = new List<Product>();
        }

        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public void DeleteProduct(string name)
        {
            Product product = RetrieveProduct(name);
            if (product != null)
            {
                Products.Remove(product);
                Console.WriteLine("The product has been deleted!");
            }
        }
        
        public void EditProduct(Product product, string newName, decimal newPrice, int newQuantity)
        {
            product.Name = newName;
            product.Price = newPrice;
            product.Quantity = newQuantity;
        }

        public Product RetrieveProduct(String name)
        {
            foreach (var product in Products)
            {
                if (product.Name.Equals(name))
                {
                    return product;
                }
            }
            return null;
        }

        public List<Product> RetrieveAllProducts()
        {
            return Products;
        }
    }
}