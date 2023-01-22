using Project.ChildForms;
using System.Text.Json;

namespace Project;

public partial class MainForm : Form
{
    private const string TaskTypesListFileName = "TaskTypesList.json";
    private const string TasksListFileName = "TasksList.json";
    private string _jsonString;

    public static List<TaskType> TaskTypes = new();
    public static List<Task> Tasks = new();

    private Form _activeForm;

    public MainForm()
    {
        InitializeComponent();
        this.StartPosition = FormStartPosition.CenterScreen;

        if (File.Exists(TaskTypesListFileName))
        {
            _jsonString = File.ReadAllText(TaskTypesListFileName);
            TaskTypes = JsonSerializer.Deserialize<List<TaskType>>(_jsonString);
        }
        else
        {
            AddDefaultTypes();
        }

        if (File.Exists(TasksListFileName))
        {
            _jsonString = File.ReadAllText(TasksListFileName);
            Tasks = JsonSerializer.Deserialize<List<Task>>(_jsonString);
        }
    }

    private void AddDefaultTypes()
    {
        TaskTypes.Add(new TaskType("Easy", 5));
        TaskTypes.Add(new TaskType("Casual", 10));
        TaskTypes.Add(new TaskType("Hard", 15));
        TaskTypes.Add(new TaskType("Very hard", 25));
    }

    private void bTasks_Click(object sender, EventArgs e)
    {
        if (_activeForm != null)
        {
            SaveFormControls((ISavableControls) _activeForm);
        }

        ActivateChildForm(new Tasks());
    }

    private void bTasksTypes_Click(object sender, EventArgs e)
    {
        if (_activeForm != null)
        {
            SaveFormControls((ISavableControls)_activeForm);
        }

        ActivateChildForm(new TasksTypes());
    }

    private void bPleasantTasks_Click(object sender, EventArgs e)
    {
        if (_activeForm != null)
        {
            SaveFormControls((ISavableControls)_activeForm);
        }

        ActivateChildForm(new PleasantTasks());
    }

    private void bPleasantTasksShop_Click(object sender, EventArgs e)
    {
        if (_activeForm != null)
        {
            SaveFormControls((ISavableControls)_activeForm);
        }

        ActivateChildForm(new PleasantTasksShop());
    }

    private void ActivateChildForm(Form childForm)
    {
        if (_activeForm != null)
        {
            _activeForm.Activate();
        }

        _activeForm = childForm;        
        childForm.TopLevel = false;
        childForm.FormBorderStyle = FormBorderStyle.None;
        childForm.Dock = DockStyle.Fill;
        pWindows.Controls.Add(childForm);
        pWindows.Tag = childForm;
        childForm.BringToFront();
        childForm.Show();
        LoadFormControls((ISavableControls)childForm);
    }

    private void SaveFormControls(ISavableControls form)
    {
        form.SaveControls();
    }

    private void LoadFormControls(ISavableControls form)
    {
        form.LoadControls();
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        SaveFormControls((ISavableControls)_activeForm);
    }   
}