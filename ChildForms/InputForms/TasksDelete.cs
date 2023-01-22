namespace Project.ChildForms.InputForms;

public partial class TasksDelete : Form
{
    public Tasks ParentForm { get; set; }

    public TasksDelete()
    {
        InitializeComponent();
        cbTask.DataSource = MainForm.Tasks;
    }

    private void bDelete_Click(object sender, EventArgs e)
    {
        MainForm.Tasks.Remove(MainForm.Tasks.ElementAt(cbTask.SelectedIndex));
        this.Close();
    }

    private void TasksDelete_FormClosing(object sender, FormClosingEventArgs e)
    {
        var count = ParentForm.Controls.Count - 2;
        for (int i = 0; i < count; i++)
        {
            ParentForm.Controls.RemoveAt(2);
        }
        ParentForm.DisplayTasks();
    }
}