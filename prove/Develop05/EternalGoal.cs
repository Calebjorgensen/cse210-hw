public class EternalGoal : Goal
{
    public override void RecordEvent()
    {
        base.RecordEvent(); // Look up base, might get rid of it. 
    }

    public override void IsComplete()
    {
        base.IsComplete();
    }
}