class Swimming : Activity
{
    private int _laps;

    public int Laps
    {
        get {return _laps;}
        private set {_laps = value;}
    }

    public Swimming(string date, int duration, int laps) : base(date, duration)
    {
        Laps = laps;
    }
    public override double GetDistance()
    {
        return Laps * 50 / 1000.0;
    }
    public override double GetSpeed()
    {
        return GetDistance() / Duration * 60;
    }
    public override double GetPace()
    {
        return Duration / GetDistance();
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()}- Distance: {GetDistance()} " + $"Speed: {GetSpeed()} Pace: {GetPace()} min per Mile";
    }

}