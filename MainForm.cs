using Project.ChildForms;

namespace Project;

public partial class MainForm : Form
{
    private static readonly string TasksFileName = "Tasks.json";
    private static readonly string TasksTypesFileName = "TasksTypes.json";
    private static readonly string PleasantTasksFileName = "PleasantTasks.json";
    private static readonly string PleasantTasksShopFileName = "PleasantTasksShop.json";

    private Form _activeForm;

    public MainForm()
    {
        InitializeComponent();
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
}