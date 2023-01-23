namespace Project;

public class PleasantTask
{
    private int _cost;
    private Label _lName;
    private Label _lCost;
    private Label _lDate;
    private CheckBox _cbCompleted;

    private const int LeftMargin = 10;
    private const int UpMargin = 10;
    private const int DistanceBetweenTasks = 25;
    private const int DistanceBetweenArguments = 15;

    public string Name { get; set; }

    public int Cost { get; set; }

    public string Date { get; set; }

    public bool Completed { get; set; }

    public PleasantTask (string name, int cost, string date)
    {
        Name = name;
        Cost = cost;
        Date = date;
        Completed = false;
    }

    public override string ToString()
    {
        return $"{Name} {Cost} {Date}";
    }

    public void SetTools(Form form, int index)
    {
        _cbCompleted = new()
        {
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

        _lCost = new()
        {
            AutoSize = true,
            Text = Cost.ToString(),
            Location = new Point(_lName.Location.X + _lName.Size.Width + DistanceBetweenArguments,
            _lName.Location.Y)
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
