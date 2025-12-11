public class Goal
{
    private string _shortName;
    private string _description;
    private string _points;

    public Goal(string name, string description, string points)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }

    public virtual int RecordEvent()
    {
        return int.Parse(_points);
    }

    public virtual bool IsComplete()
    {
        return true;
    }

    public string GetName()
    {
        return _shortName;
    }

    public virtual string GetDetailsString()
    {

        return $"{_shortName},{_description},{_points}";
    }

    public virtual string GetStringRepresentation()
    {
        return $"{_shortName} ({_description})";
    }
}