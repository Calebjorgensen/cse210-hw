public class Goal
{

    protected string _name;
    protected string _desc;
    protected int _score;

    public Goal(string name, string desc, int score)
    {
        _name = name;
        _desc = desc;
        _score = score;
    }

    public virtual void RecordEvent()
    {
        // Empty because it is the parent, the children will fill it out. 
    }

    public virtual bool IsComplete()
    {
        return false;
         
    }

    public virtual string GetPrintableGoal()
    {
        return "";
    }

    public virtual string GetGoal()
    {
        return ($"{_name}~{_desc}~{_score}");
    }


}