namespace Project;

public partial class MainForm : Form
{
    private Form _activeForm;

    public MainForm()
    {
        InitializeComponent();
    }

    private void bTasks_Click(object sender, EventArgs e)
    {
        ActivateChildForm(new ChildForms.Tasks());
    }

    private void bTasksTypes_Click(object sender, EventArgs e)
    {
        ActivateChildForm(new ChildForms.TasksTypes());
    }

    private void bPleasantTasks_Click(object sender, EventArgs e)
    {
        ActivateChildForm(new ChildForms.PleasantTasks());
    }

    private void bPleasantTasksShop_Click(object sender, EventArgs e)
    {
        ActivateChildForm(new ChildForms.PleasantTasksShop());
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
    }
}