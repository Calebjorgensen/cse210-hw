class Order
{
    private Customer _customer;
    private List<Product>  _products;

    public Order(Customer customer, List<Product> products)
    {
        this._customer = customer;
        this._products = products;
    }

    public double CalculateTotalCost()
    {
        double totalPrice = 0;
        foreach(Product product in _products)
        {
            totalPrice += product.GetTotalPrice();
        }

        double shippingCost = _customer.IsUsaCustomer() ? 5 : 35;
        return totalPrice + shippingCost;
    }
    
    public string GetPackingLabel()
    {
        List<string> packinglabels = new List<string>();
        foreach (Product product in _products)
        {
            packinglabels.Add(product.GetProductInfo());
        }
        return string.Join("\n", packinglabels);
    }
    public string GetShippingLabel()
    {
        return $"{_customer.GetCustomerName()}, {_customer.GetAddress()}";
    }
}