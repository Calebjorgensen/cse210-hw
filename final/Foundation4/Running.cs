class Running : Activity
{
    private double _distance;
    public double Distance
    {
        get {return _distance;}
        private set {_distance = value;}
    }

    public Running(string date, int duration, double distance) : base(date, duration)
    {
        Distance = distance;
    }
    public override double GetDistance()
    {
        return Distance;
    }
    public override double GetSpeed()
    {
        return Distance / Duration * 60;
    }
    public override double GetPace()
    {
        return Duration / Distance;
    }
    public override string GetSummary()
    {
        string distanceUnit = "Miles";
        string speedUnit = "Mph";

        if (Distance < 1)
        {
            distanceUnit = "Km";
            speedUnit = "Kph";
        }
        return $"{base.GetSummary()} - Distance: {Distance} {distanceUnit}" + $" Speed: {GetSpeed()} {speedUnit}, Pace: {GetPace()} min per {distanceUnit}";
    }
}