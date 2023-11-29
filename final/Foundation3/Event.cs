class Event
{
    protected string _title;
    protected string _desc;
    protected string _date;
    protected string _time;
    protected Address _address;

    public Event(string title, string desc, string date, string time, Address address)
    {
        _title = title;
        _desc = desc;
        _date = date;
        _time = time;
        _address = address;
    }

    public string GetStandardDetails()
    {
        return $"{_title}, {_desc}, {_date}, {_time}, {_address.GetAddressName()}";
    }
}