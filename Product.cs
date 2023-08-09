public class Product
{
    private string _name;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, decimal price, int quantity)
    {
        Name = name;
        Price = price;
        Quantity = quantity;
    }
}
