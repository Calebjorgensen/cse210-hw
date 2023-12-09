
class Event
{
    protected string _title;
    protected string _desc;
    protected string _date;
    protected string _time;
    protected Address _address;

    // This is the Parent Constuctor, This is all the details that are needed for Standard details. 
    public Event(string title, string desc, string date, string time, Address address)
    {
        this._title = title;
        this._desc = desc;
        this._date = date;
        this._time = time;
        this._address = address;
    }

    public string GetStandardDetails()
    {
        return $"{_title}, {_desc}, {_date}, {_time}, {_address.GetAddressName()}";
    }
    public string GetShortDetails()
    {
        return $"{GetType().Name}: {_title}, {_date}";
    }

}