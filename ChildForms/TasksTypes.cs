namespace Project.ChildForms;

public partial class TasksTypes : Form
{
    private List<TaskType> _types = new();


    public TasksTypes()
    {
        InitializeComponent();
        UploadDefaultTypes();

        foreach (var item in _types)
        {
            item.SetTools(this);
        }
    }

    private void UploadDefaultTypes()
    {
        _types.Add(new TaskType("Easy", 5));
        _types.Add(new TaskType("Casual", 10));
        _types.Add(new TaskType("Hard", 15));
        _types.Add(new TaskType("Very hard", 25));
    }

    
}
