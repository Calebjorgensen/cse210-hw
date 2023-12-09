class Activity
{
    private string _date;
    private int _duration;

    public string Date
    {
        get {return _date;}
        private set {_date = value;}
    }

    public int Duration
    {
        get {return _duration;}
        private set {_duration = value;}
    }
    public Activity(string date, int duration)
    {
        Date = date;
        Duration = duration;
    }

    public virtual double GetDistance()
    {
        return 0.0;
    }
    public virtual double GetSpeed()
    {
        return 0.0;
    }
    public virtual double GetPace()
    {
        return 0.0;
    }
    public virtual string GetSummary()
    {
        return $"{Date} {GetType().Name} ({Duration} min)";
    }
    // I think I need to get more add to this get summary
}