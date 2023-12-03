class Product
{
    private string _name;
    private string _productId;
    private int _price;
    private string _quantity;

    public Product(string name, string productId, int price, string quantity)
    {
        _name = name;
        _productId = productId;
        _price = price;
        _quantity = quantity;
    }
    public Product(int price)
    {
        price = 0;
    }
    public int GetPrice()
    {
        int price = 10;
        return price;
    }

}