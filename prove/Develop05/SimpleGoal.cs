public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string desc, int score):base(name, desc, score)
    {

    }
        public override void RecordEvent()
    {
        base.RecordEvent();
    }

    public override bool IsComplete()
    {
        return base.IsComplete();
    }
}