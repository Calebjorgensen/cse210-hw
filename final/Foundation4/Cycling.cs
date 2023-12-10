class Cycling : Activity
{
    private double _speed;

    public double Speed
    {
        get {return _speed;}
        private set {_speed = value;}
    }

    public Cycling(string date, int duration, double speed) : base(date, duration)
    {
        _speed = speed;
    }
    public override double GetDistance()
    {
        return Speed * Duration / 60;
    }
    public override double GetSpeed()
    {
        return Speed;
    }
    public override double GetPace()
    {
        return 60 / Speed;
    }
    public override string GetSummary()
    {
        return $"{base.GetSummary()} - Distance: {GetDistance()} " + $"Speed: {Speed} Pace: {GetPace()} min per Mile";
    }

}