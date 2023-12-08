class Customer
{
    private string _name;
    private Address _address;
    public Customer(string name, Address address)
    {
        this._name = name;
        this._address = address;
    }

    public bool IsUsaCustomer()
    {
        return _address.IsUsa();
    }

    public string GetCustomerName()
    {
        return _name;
    }
    public string GetAddress()
    {
        return _address.GetAddressName();
    }
}