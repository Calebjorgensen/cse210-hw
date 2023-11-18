public class CheckListGoal : Goal
{
    private int _bonus;
    private int _currentAmount;
    private int _totalAmount;
    private bool _isComplete;

    public CheckListGoal(string name, string desc, int score, int bonus, int totalAmount):base(name, desc, score)
    {
        _isComplete = false;
        _bonus = bonus;
        _currentAmount = 0;
        _totalAmount = totalAmount;
    }
        public override void RecordEvent()
    {
        if(_currentAmount == _totalAmount)
        {
            _isComplete = true;
        }
    }

    public override bool IsComplete()
    {
        return base.IsComplete();
    }
    public override string GetPrintableGoal()
    {
        
        if(_isComplete == true)
        {
            return ($"[X] {_name} ({_desc}) -- Currently Completed: {_currentAmount}/{_totalAmount}");
        }
        else
        {
            return ($"[ ] {_name} ({_desc}) -- Currently Completed: {_currentAmount}/{_totalAmount}");
        }
    }
    public override string GetGoal()
    {
        return $"CheckList~{_name}~{_desc}~{_score}~{_bonus}~{_currentAmount}~{_totalAmount}";
    }

}