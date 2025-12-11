public class SimpleGoal : Goal
{
    private bool _isComplete;

    public SimpleGoal(string name, string description, string points, bool completed=false) : base(name, description, points)
    {
        _isComplete = completed;
    }

    public override int RecordEvent()
    {
        _isComplete = true;
        return base.RecordEvent();
    }

    public override bool IsComplete()
    {
        return _isComplete;
    }

    public override string GetDetailsString()
    {
        string baseString = base.GetDetailsString();

        return $"{baseString},{_isComplete}";
    }

    public override string GetStringRepresentation()
    {
        string baseString = base.GetStringRepresentation();

        if (IsComplete())
        {
            return $"[X] {baseString}";
        }
        else
        {
            return $"[ ] {baseString}";
        }
    }
}