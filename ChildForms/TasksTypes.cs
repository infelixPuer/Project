using System.Text.Json;
using System.Reflection;

namespace Project.ChildForms;

public partial class TasksTypes : Form, ISavableControls
{
    private List<TaskType> _types = new();

    private const string FileName = "Controls.json";
    private string _jsonString;

    public TasksTypes()
    {
        InitializeComponent();
        UploadTypes();
    }

    private void UploadTypes()
    {
        if (File.Exists(FileName)) 
        {
            return; 
        }

        AddDefaultTypes();
        DisplayDefaultTypes();
    }

    private void AddDefaultTypes()
    {
        _types.Add(new TaskType("Easy", 5));
        _types.Add(new TaskType("Casual", 10));
        _types.Add(new TaskType("Hard", 15));
        _types.Add(new TaskType("Very hard", 25));
    }

    private void DisplayDefaultTypes()
    {
        foreach (var item in _types)
        {
            item.SetTools(this);
        }
    }

    public void SaveControls()
    {
        var controlPropierties = new List<ControlProperties>();

        foreach (Control control in this.Controls)
        {
            var cp = new ControlProperties();
            cp.Type = control.GetType().FullName;
            cp.Name = control.Name;
            cp.Text = control.Text;
            cp.Location = control.Location;
            cp.Size = control.Size;
            cp.AutoSize = control.AutoSize;
            cp.Visiable = control.Visible;
            controlPropierties.Add(cp);
        }

        _jsonString = JsonSerializer.Serialize(controlPropierties);
        File.WriteAllText(FileName, _jsonString);
    }

    public void LoadControls()
    {
        if (!File.Exists(FileName)) { return; }

        _jsonString = File.ReadAllText(FileName);
        var controls = JsonSerializer.Deserialize<List<ControlProperties>>(_jsonString);

        if (controls == null) { return; }

        foreach (var cp in controls)
        {
            var assembly = Assembly.GetAssembly(typeof(Label));

            if (assembly == null) { return; }

            var type = assembly.GetType(cp.Type);

            if (type != null)
            {
                var control = (Control)Activator.CreateInstance(type);
                control.Name = cp.Name;
                control.Text = cp.Text;
                control.Location = cp.Location;
                control.Size = cp.Size;
                control.AutoSize = cp.AutoSize;
                control.Visible = cp.Visiable;
                Controls.Add(control);
            }            
        }
    }
}
