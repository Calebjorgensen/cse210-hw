class Lectures : Event
{
    private string _speakerName;
    private string _capacity;

    // Child Constuctor with a base to the parent
    public Lectures(string title, string desc, string date, string time, Address address, string speakerName, string capacity): base(title, desc, date, time, address)
    {
        this._speakerName = speakerName;
        this._capacity = capacity;
    }

    public string GetFullDetails()
    {
        return $"Lecture: {_title}, {_speakerName}, {_desc}, {_date}, {_time}, {_address.GetAddressName()}, {_capacity}";
    }

}