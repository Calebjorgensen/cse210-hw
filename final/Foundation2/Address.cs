class Address
{
    private string _street;
    private string _city;
    private string _state;
    private string _country;

    public Address(string street, string city, string state, string country)
    {
        this._street = street;
        this._city = city;
        this._state = state;
        this._country = country;
    }

    // This is method helps us with knowing if the order is in the USA or not
    public bool IsUsa()
    {
        return _country.ToLower() == "usa";
    }


    // This method will be used as a way to get the address from private and display it.
    public string GetAddressName()
    {
        return $"Address: {_street}, {_city}, {_state}, {_country} ";
    }
}