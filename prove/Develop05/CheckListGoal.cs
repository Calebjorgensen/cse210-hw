public class CheckListGoal : Goal
{
    private int _bonus;
    private int _currentAmount;
    private int _totalAmount;

    public CheckListGoal(string name, string desc, int score):base(name, desc, score)
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
        return ($"{_name}");
    }

}