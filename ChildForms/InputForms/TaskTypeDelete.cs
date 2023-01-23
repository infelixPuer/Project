using static Project.MainForm;

namespace Project.ChildForms.InputForms;

public partial class TaskTypeDelete : Form
{
    public TaskTypes ParentForm { get; set; }

    public TaskTypeDelete()
    {
        InitializeComponent();
        cbType.DataSource = MainForm.TaskTypesList;
    }

    private void bDelete_Click(object sender, EventArgs e)
    {
        MainForm.TaskTypesList.Remove(MainForm.TaskTypesList.ElementAt(cbType.SelectedIndex));
        this.Close();
    }

    private void TaskTypeDelete_FormClosing(object sender, FormClosingEventArgs e)
    {
        var count = ParentForm.Controls.Count - 2;
        for (int i = 0; i < count; i++)
        {
            ParentForm.Controls.RemoveAt(2);
        }
        ParentForm.DisplayDefaultTypes();
    }
}
