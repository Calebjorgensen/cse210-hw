public class EternalGoal : Goal
{
    public EternalGoal(string name, string desc, int score):base(name, desc, score)
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
    public override string GetPrintableGoal()
    {
        return ($"[ ] {_name} ({_desc})");
    }
    
    

}