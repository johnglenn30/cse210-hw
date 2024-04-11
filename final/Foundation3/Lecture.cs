class Lecture : Event
{
    private string _speaker;
    private int _capacity;

    public Lecture(string title, string description, DateTime date,string speaker, TimeSpan time, Address address, int capacity) : base(title, description, date, time, address)
    {
        _speaker = speaker;
        _capacity = capacity;
        
    }

    public override string FullDetails()
    {
        return $"{base.FullDetails()}\nType: Lecture\nSpeaker: {_speaker}\nCapacity: {_capacity}\nDate:{_date.ToShortDateString()}";
    }

    public override string ShortDetails()
    {
        return $"Type: Lecture\nTitle: {_title}\nDate: {_date.ToShortDateString()} ";
    }

}