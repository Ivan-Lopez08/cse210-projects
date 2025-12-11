public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, string points) : base(name, description, points)
    {
        
    }

    public override int RecordEvent()
    {
        return base.RecordEvent();
    }

    public override bool IsComplete()
    {
        return false;
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