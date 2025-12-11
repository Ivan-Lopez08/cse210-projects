using System.Data;

public class Swimming : Activity
{
    private int _laps;
    private const int _lapLength = 50;

    public Swimming(string date, int minutes, int laps)
        : base(date, minutes)
    {
        _laps = laps;
    }

    public override double GetDistance()
    {
        return (_laps * _lapLength) / 1000.0;
    }

    public override double GetSpeed()
    {
        double distance = GetDistance();
        return (distance / GetMinutes()) * 60;
    }

    public override double GetPace()
    {
        return GetMinutes() / GetDistance();
    }
}
