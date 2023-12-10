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
        return $"Lecture: Title: {_title} ~ Speaker: {_speakerName} ~ Description: {_desc} ~ Date: {_date} ~ Time: {_time} ~ Address: {_address.GetAddressName()} ~ Seating: {_capacity}";
    }

}