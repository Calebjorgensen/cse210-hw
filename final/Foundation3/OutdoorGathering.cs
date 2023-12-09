class OutdoorGathering : Event
{
    private string _weatherForcast;
    public OutdoorGathering(string title, string desc, string date, string time, Address address, string weatherForcast) : base(title, desc, date, time, address)
    {
        this._weatherForcast = weatherForcast;
    }
    public string GetFullDetails()
    {
        return $"OutdoorGathering: {_title}, {_desc}, {_date}, {_time}, {_address.GetAddressName()}, {_weatherForcast}";
    }

}