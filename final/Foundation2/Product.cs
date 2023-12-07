class Product
{
    private string _name;
    private string _productId;
    private int _price;
    private int _quantity;

    public Product(string name, string productId, int price, int quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public string GetProduct()
    {
        return $"Product Name: {_name}, Product ID: {_productId}, Cost: {_price}, Qauntity: {_quantity}";
    }
    // Remember to look at the learning activity to help this part.
}