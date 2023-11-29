class Lectures : Event
{
    private string _speakerName;
    private string _capacity;
    public Lectures(string title, string desc, string date, string time, Address address, string speakerName, string capacity): base(title, desc, date, time, address)
    {
        _speakerName = speakerName;
        _capacity = capacity;
    }

    public string GetFullDetails()
    {
        return $"Lecture: {_title}, {_speakerName}, {_desc}, {_date}, {_time}, {_address.GetAddressName()}, {_capacity}";
    }
    public string GetShortDetails()
    {
        return $"Lecture: {_title}, {_date}";
    }
}