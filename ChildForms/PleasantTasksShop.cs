using System.Reflection;
using System.Text.Json;
using static Project.MainForm;

namespace Project.ChildForms;

public partial class PleasantTasksShop : Form, ISavableControls
{
    private const string PleasantTasksControlsFileName = "PleasantTasksControls.json";
    private const string PleasantTasksListFileName = "PleasantTasksList.json";
    private string _jsonString;

    public PleasantTasksShop()
    {
        InitializeComponent();

        UploadTypes();
    }
    private void UploadTypes()
    {
        if (File.Exists(PleasantTasksControlsFileName))
        {
            return;
        }

        DisplayDefaultPleasantTasks();
    }

    public void DisplayDefaultPleasantTasks()
    {
        for (int i = 0; i < PleasantTasksList.Count; i++)
        {
            PleasantTasksList[i].SetTools(this, i);
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
        File.WriteAllText(PleasantTasksControlsFileName, _jsonString);
        _jsonString = JsonSerializer.Serialize(TaskTypesList);
        File.WriteAllText(PleasantTasksListFileName, _jsonString);
    }

    public void LoadControls()
    {
        if (!File.Exists(PleasantTasksControlsFileName)) { return; }

        _jsonString = File.ReadAllText(PleasantTasksControlsFileName);
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
        var inputForm = new InputForms.PleasantTaskInput();
        inputForm.StartPosition = FormStartPosition.CenterScreen;
        inputForm.ParentForm = this;
        inputForm.ShowDialog();
    }

    private void bDelete_Click(object sender, EventArgs e)
    {
        var inputForm = new InputForms.PleasantTaskDelete();
        inputForm.StartPosition = FormStartPosition.CenterScreen;
        inputForm.ParentForm = this;
        inputForm.ShowDialog();
    }
}
