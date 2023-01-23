using Microsoft.Win32;
using Project.ChildForms;
using Project.ChildForms.InputForms;
using System.Text.Json;

namespace Project;

public partial class MainForm : Form
{
    private const string TasksListFileName = "TasksList.json";
    private const string TaskTypesListFileName = "TaskTypesList.json";
    private const string PleasantTasksListFileName = "PleasantTasksList.json";
    private const string PleasantTasksShopListFileName = "PleasantTasksShopList.json";
    private const string UserInfoFileName = "UserInfo.json";
    private string _jsonString;

    public static List<Task> TasksList = new();
    public static List<TaskType> TaskTypesList = new();
    public static List<PleasantTask> PleasantTasksList = new();
    public static List<PleasantTask> PleasantTasksShopList = new();

    public static User CurrentUser;

    private Form _activeForm;

    public MainForm()
    {
        InitializeComponent();
        this.StartPosition = FormStartPosition.CenterScreen;
        lCurrentDate.Text = DateTime.Now.ToShortDateString();
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

        if (File.Exists(PleasantTasksShopListFileName))
        {
            _jsonString = File.ReadAllText(PleasantTasksShopListFileName);
            PleasantTasksShopList = JsonSerializer.Deserialize<List<PleasantTask>>(_jsonString);
        }
        else
        {
            AddDefaultPleasantTasks();
        }

        if (File.Exists(PleasantTasksListFileName))
        {
            _jsonString = File.ReadAllText(PleasantTasksListFileName);
            PleasantTasksList = JsonSerializer.Deserialize<List<PleasantTask>>(_jsonString);
        }
    }

    private void GetUserName()
    {
        string keyName = "FirstRun";
        //Registry.CurrentUser.DeleteSubKey("Project");
        var key = Registry.CurrentUser.CreateSubKey("Project");

        if (key.GetValue(keyName) == null)
        {
            var userNameInputForm = new UserNameInput();
            userNameInputForm.StartPosition = FormStartPosition.CenterScreen;
            userNameInputForm.ParentForm = this;
            userNameInputForm.ShowDialog();
            key.SetValue(keyName, false);
            return;
        }

        _jsonString = File.ReadAllText(UserInfoFileName);
        CurrentUser = JsonSerializer.Deserialize<User>(_jsonString);

        lName.Text = CurrentUser.Name;
        lCurrentBalance.Text = CurrentUser.Balance.ToString();
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
        PleasantTasksShopList.Add(new PleasantTask("Go to the cinema", 25, ""));
        PleasantTasksShopList.Add(new PleasantTask("Play computer games", 20, ""));
        PleasantTasksShopList.Add(new PleasantTask("Buy ice-cream", 10, ""));
        PleasantTasksShopList.Add(new PleasantTask("Make party", 40, ""));
    }

    private void bTasks_Click(object sender, EventArgs e)
    {
        if (_activeForm != null)
        {
            SaveFormControls((ISavableControls) _activeForm);
        }

        var tasks = new Tasks();
        tasks.ParentForm = this;

        ActivateChildForm(tasks);
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

        var shop = new PleasantTasksShop();
        shop.ParentForm = this;

        ActivateChildForm(shop);
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
        if (form == null) { return; }

        form.SaveControls();
    }

    private void LoadFormControls(ISavableControls form)
    {
        form.LoadControls();
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
    {
        SaveFormControls((ISavableControls)_activeForm);

        _jsonString = JsonSerializer.Serialize(CurrentUser);
        File.WriteAllText(UserInfoFileName, _jsonString);
    }   
}