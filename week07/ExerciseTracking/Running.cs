public class Running : Activity
{
    private double _distance;  // Req 3: Distance STORED directly

    public Running(DateTime date, int minutes, double distance)
        : base(date, minutes)
    {
        _distance = distance;
    }

    // Req 4: Override abstract methods
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        return (_distance / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return 60 / GetSpeed();
    }
}
