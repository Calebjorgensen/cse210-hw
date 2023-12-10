class OutdoorGathering : Event
{
    private string _weatherForcast;
    public OutdoorGathering(string title, string desc, string date, string time, Address address, string weatherForcast) : base(title, desc, date, time, address)
    {
        this._weatherForcast = weatherForcast;
    }
    public string GetFullDetails()
    {
        return $"OutdoorGathering: Title: {_title} ~ Description: {_desc} ~ Date: {_date} ~ Time: {_time} ~ Address: {_address.GetAddressName()} ~ Weather Report: {_weatherForcast}";
    }

}