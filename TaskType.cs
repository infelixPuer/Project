using System.Text.Json;

namespace Project;

public class TaskType
{
    private string _name;
    private int _cost;

    private CheckBox _cbCompleted;
    private Label _lName;
    private Label _lCost;

    private const int LeftMargin = 10;
    private const int UpMargin = 10;
    private const int DistanceBetweenTasks = 25;
    private const int DistanceBetweenArguments = 15;

    public string Name
    {
        get { return _name; }
        set { _name = value; }
    }

    public int Cost
    {
        get { return _cost; }
        set
        {
            if (value > 0)
            {
                _cost = value;
            }
        }
    }

    public TaskType(string name, int cost)
    {
        _name = name;
        _cost = cost;
    }

    public void SetTools(Form form, int index)
    {
        _cbCompleted = new()
        {
            AutoSize = true,
            Text = "",
            Location = new Point(LeftMargin, UpMargin + index * DistanceBetweenTasks),
            Visible = true
        };
        form.Controls.Add(_cbCompleted);

        _lName = new()
        {
            AutoSize = true,
            Text = Name,
            Location = new Point(_cbCompleted.Location.X + _cbCompleted.Size.Width + DistanceBetweenArguments,
            _cbCompleted.Location.Y)
        };
        form.Controls.Add(_lName);

        _lCost = new()
        {
            AutoSize = true,
            Text = Cost.ToString(),
            Location = new Point(_lName.Location.X + _lName.Size.Width + DistanceBetweenArguments,
            _lName.Location.Y)
        };
        form.Controls.Add(_lCost);
    }

    public override string ToString()
    {
        return $"{Name} {Cost}";
    }
}
