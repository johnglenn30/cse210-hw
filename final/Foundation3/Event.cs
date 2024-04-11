class Event
{
    protected string _title;
    private string _description;
    protected DateTime _date;
    private TimeSpan _time;

    private Address _address;

    public Event(string title, string description, DateTime date, TimeSpan time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    public virtual string StandardDetails()
    {
        return $"Title: {_title}\nDescription: {_description} \nDate: {_date.ToShortDateString}\nTime: {_time}\nAddress: {_address}";
    }

    public virtual string FullDetails()
    {
        return StandardDetails();
    }

    public virtual string ShortDetails()
    {
        return $"Type: Event\nTitle: {_title}\nDate: {_date.ToShortDateString()}";
    }
}