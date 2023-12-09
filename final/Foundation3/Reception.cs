class Reception : Event
{
    private string _rsvp;
    public Reception(string title, string desc, string date, string time, Address address, string rsvp) : base (title, desc, date, time, address)
    {
        this._rsvp = rsvp;
    }
    public string GetFullDetails()
    {
        return $"Reception: {_title}, {_desc}, {_date}, {_time}, {_address.GetAddressName()}, {_rsvp}";
    }

}