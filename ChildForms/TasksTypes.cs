using System.Text.Json;
using System.Reflection;
using static Project.MainForm;

namespace Project.ChildForms;

public partial class TasksTypes : Form, ISavableControls
{
    private const string FileName = "TasksTypesControls.json";
    private const string TaskTypesListFileName = "TaskTypesList.json";
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
        TaskTypes.Add(new TaskType("Easy", 5));
        TaskTypes.Add(new TaskType("Casual", 10));
        TaskTypes.Add(new TaskType("Hard", 15));
        TaskTypes.Add(new TaskType("Very hard", 25));
    }

    public void DisplayDefaultTypes()
    {
        for (int i = 0; i < TaskTypes.Count; i++)
        {
            TaskTypes[i].SetTools(this, i);
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
        _jsonString = JsonSerializer.Serialize(TaskTypes);
        File.WriteAllText(TaskTypesListFileName, _jsonString);
    }

    public void LoadControls()
    {
        if (File.Exists(TaskTypesListFileName))
        {
            _jsonString = File.ReadAllText(TaskTypesListFileName);
            TaskTypes = JsonSerializer.Deserialize<List<TaskType>>(_jsonString);
        }

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

    private void bAdd_Click(object sender, EventArgs e)
    {
        var inputForm = new InputForms.TaskTypeInput();
        inputForm.StartPosition = FormStartPosition.CenterScreen;
        inputForm.parentForm = this;
        inputForm.Show();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        var deleteForm = new InputForms.TaskTypeDelete();
        deleteForm.StartPosition = FormStartPosition.CenterScreen;
        deleteForm.parentForm = this;
        deleteForm.Show();
    }
}
