
class Event
{
    protected string _title;
    protected string _desc;
    protected string _date;
    protected string _time;
    protected Address _address;

    
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
        return $"Title: {_title} ~ Description: {_desc} ~ Date: {_date} ~ Time: {_time} ~ Address: {_address.GetAddressName()}";
    }
    public string GetShortDetails()
    {
        return $"{GetType().Name} ~ Title: {_title} ~ Date: {_date}";
    }

}