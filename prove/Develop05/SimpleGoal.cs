public class SimpleGoal : Goal
{
    private bool _isComplete;
    public SimpleGoal(string name, string desc, int score):base(name, desc, score)
    {
        _isComplete = false;

    }
        public override void RecordEvent()
    {
        _isComplete = true;
    }

    public override bool IsComplete()
    {
        return base.IsComplete();
    }
    public override string GetPrintableGoal()
    {
        if(_isComplete == true)
        {
            return ($"[X] {_name}({_desc})");
        }
        else
        {
            return ($"[ ] {_name}({_desc})");
        }    
    }
    public override string GetGoal()
    {
        return $"SimpleGoal~{_name}~{_desc}~{_score}";
    }
}