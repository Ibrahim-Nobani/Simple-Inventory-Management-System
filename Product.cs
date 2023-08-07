public class Product
{
    private string name;

    public string GetName()
    {
        return name;
    }

    private void SetName(string value)
    {
        name = value;
    }

    public decimal Price { get; set; }
    public int Quantity { get; set; }

    public Product(string name, decimal price, int quantity)
    {
        SetName(name);
        Price = price;
        Quantity = quantity;
    }
}
