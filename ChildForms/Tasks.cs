using System.Reflection;
using System.Text.Json;

namespace Project.ChildForms;

public partial class Tasks : Form, ISavableControls
{
    private const string TasksControlsFileName = "TasksControls.json";
    private const string TasksListFileName = "TasksList.json";
    private string _jsonString;

    public Tasks()
    {
        InitializeComponent();
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
        File.WriteAllText(TasksControlsFileName, _jsonString);
        _jsonString = JsonSerializer.Serialize(MainForm.TasksList);
        File.WriteAllText(TasksListFileName, _jsonString);
    }

    public void LoadControls()
    {
        if (!File.Exists(TasksControlsFileName)) { return; }

        _jsonString = File.ReadAllText(TasksControlsFileName);
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

    public void DisplayTasks()
    {
        for (int i = 0; i < MainForm.TasksList.Count; i++)
        {
            MainForm.TasksList[i].SetTools(this, i);
        }
    }

    private void bAdd_Click(object sender, EventArgs e)
    {
        var inputForm = new InputForms.TasksInput();
        inputForm.StartPosition = FormStartPosition.CenterScreen;
        inputForm.ParentForm = this;
        inputForm.ShowDialog();
    }

    private void bDelete_Click(object sender, EventArgs e)
    {
        var deleteForm = new InputForms.TasksDelete();
        deleteForm.StartPosition = FormStartPosition.CenterScreen;
        deleteForm.ParentForm = this;
        deleteForm.ShowDialog();
    }
}
