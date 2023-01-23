using Microsoft.Win32;
using Project.ChildForms;
using System.Text.Json;

namespace Project;

public partial class MainForm : Form
{
    private const string TaskTypesListFileName = "TaskTypesList.json";
    private const string TasksListFileName = "TasksList.json";
    private const string PleasantTasksListFileName = "PleasantTasksList.json";
    private string _jsonString;

    public static List<TaskType> TaskTypesList = new();
    public static List<Task> TasksList = new();
    public static List<PleasantTask> PleasantTasksList = new();

    public User User;

    private Form _activeForm;

    public MainForm()
    {
        InitializeComponent();
        this.StartPosition = FormStartPosition.CenterScreen;
        GetUserName();

        if (File.Exists(TaskTypesListFileName))
        {
            _jsonString = File.ReadAllText(TaskTypesListFileName);
            TaskTypesList = JsonSerializer.Deserialize<List<TaskType>>(_jsonString);
        }
        else
        {
            AddDefaultTypes();
        }

        if (File.Exists(TasksListFileName))
        {
            _jsonString = File.ReadAllText(TasksListFileName);
            TasksList = JsonSerializer.Deserialize<List<Task>>(_jsonString);
        }

        if (File.Exists(PleasantTasksListFileName))
        {
            _jsonString = File.ReadAllText(PleasantTasksListFileName);
            PleasantTasksList = JsonSerializer.Deserialize<List<PleasantTask>>(_jsonString);
        }
        else
        {
            AddDefaultPleasantTasks();
        }
    }

    private static void GetUserName()
    {
        string keyName = "FirstRun";

        var key = Registry.CurrentUser.CreateSubKey("Project");

        if (key.GetValue(keyName) == null)
        {

            key.SetValue(keyName, false);
        }
    }

    private void AddDefaultTypes()
    {
        TaskTypesList.Add(new TaskType("Easy", 5));
        TaskTypesList.Add(new TaskType("Casual", 10));
        TaskTypesList.Add(new TaskType("Hard", 15));
        TaskTypesList.Add(new TaskType("Very hard", 25));
    }

    private void AddDefaultPleasantTasks()
    {
        PleasantTasksList.Add(new PleasantTask("Go to the cinema", 25, ""));
        PleasantTasksList.Add(new PleasantTask("Play computer games", 20, ""));
        PleasantTasksList.Add(new PleasantTask("Buy ice-cream", 10, ""));
        PleasantTasksList.Add(new PleasantTask("Make party", 40, ""));
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

        ActivateChildForm(new TaskTypes());
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