namespace Project;

public class Task
{
    private string _name;
    private TaskType _type;
    private string _date;
    private bool _completed;

    private Label _lName;
    private Label _lType;
    private Label _lCost; 
    private Label _lDate;
    private CheckBox _cbCompleted;

    private const int LeftMargin = 10;
    private const int UpMargin = 10;
    private const int DistanceBetweenTasks = 25;
    private const int DistanceBetweenArguments = 15;

    public string Name
    {
        get => _name;
        set
        {
            if (value != null)
            {
                _name = value;
            }
        }
    }

    public TaskType Type
    {
        get => _type;
        set { _type = value; }
    }

    public string Date
    {
        get => _date;
        set { _date = value; }
    }

    public bool Completed
    {
        get => _completed;
        set { _completed = value; }
    }


    public Task(string name, TaskType type, string date)
    {
        Name = name;
        Type = type;
        Date = date;
        Completed = false;
    }

    public override string ToString()
    {
        return $"{Name}, {Type}, {Date}";
    }

    public void SetTools(Form form, int index)
    {
        _cbCompleted = new()
        {
            Name = $"cbCompleted_{index}",
            AutoSize = true,
            Text = "",
            Location = new Point(LeftMargin, UpMargin + index * DistanceBetweenTasks)
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

        _lType = new()
        {
            AutoSize = true,
            Text = Type.Name,
            Location = new Point(_lName.Location.X + _lName.Size.Width + DistanceBetweenArguments,
            _lName.Location.Y)
        };
        form.Controls.Add(_lType);

        _lCost = new()
        {
            AutoSize = true,
            Text = Type.Cost.ToString(),
            Location = new Point(_lType.Location.X + _lType.Size.Width + DistanceBetweenArguments,
            _lType.Location.Y)
        };
        form.Controls.Add(_lCost);

        _lDate = new()
        {
            AutoSize = true,
            Text = Date.ToString(),
            Location = new Point(_lCost.Location.X + _lCost.Size.Width + DistanceBetweenArguments,
            _lCost.Location.Y)
        };
        form.Controls.Add(_lDate);
    }
}
