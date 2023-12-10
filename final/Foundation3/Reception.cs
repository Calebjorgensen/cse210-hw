class Reception : Event
{
    private string _rsvp;
    public Reception(string title, string desc, string date, string time, Address address, string rsvp) : base (title, desc, date, time, address)
    {
        this._rsvp = rsvp;
    }
    public string GetFullDetails()
    {
        return $"Reception: Title: {_title} ~ Description: {_desc} ~ Date: {_date} ~ Time: {_time} ~ Address: {_address.GetAddressName()} ~ RSVP to: {_rsvp}";
    }

}