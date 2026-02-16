using System;

public abstract class Activity
{
    private DateTime _date;
    private int _minutes;

    public Activity(DateTime date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // Req 4: Abstract methods - NO implementation, derived classes MUST override
    public abstract double GetDistance();
    public abstract double GetSpeed();
    public abstract double GetPace();

    // Req 5: Virtual GetSummary in base class - calls the overridden methods
    public virtual string GetSummary()
    {
        return $"{_date:dd MMM yyyy} {_GetActivityType()} ({_minutes} min) - " +
               $"Distance: {GetDistance():F1} km, Speed: {GetSpeed():F1} kph, Pace: {GetPace():F1} min per km";
    }

    // Helper method for activity type
    private string _GetActivityType()
    {
        return GetType().Name;
    }

    // Protected getters for derived classes
    protected DateTime GetDate() => _date;
    protected int GetMinutes() => _minutes;
}
