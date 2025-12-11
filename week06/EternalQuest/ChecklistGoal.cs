public class ChecklistGoal : Goal
{
    private int _amountCompleted;
    private int _target;
    private int _bonus;

    public ChecklistGoal(string name, string description, string points, int target, int bonus, int amountCompleted = 0) : base(name, description, points)
    {
        _target = target;
        _bonus = bonus;
        _amountCompleted = amountCompleted;
    }

    public override int RecordEvent()
    {
        _amountCompleted += 1;
        if(_amountCompleted == _target)
        {
            return base.RecordEvent() + _bonus;
        }

        return base.RecordEvent();
    }

    public override bool IsComplete()
    {
        if(_amountCompleted == _target)
        {
            return true;
        }

        return false;
    }

    public override string GetDetailsString()
    {
        string baseString = base.GetDetailsString();
        return $"{baseString},{_bonus},{_target},{_amountCompleted}";
    }

    public override string GetStringRepresentation()
    {
        string baseString = base.GetStringRepresentation();

        if (IsComplete())
        {
            return $"[X] {baseString} -- Currently completed: {_amountCompleted}/{_target}";
        }
        else
        {
            return $"[ ] {baseString} -- Currently completed: {_amountCompleted}/{_target}";
        }
    }
}