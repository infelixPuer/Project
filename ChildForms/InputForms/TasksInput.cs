using static Project.MainForm;

namespace Project.ChildForms.InputForms;

public partial class TasksInput : Form
{
    private const string NameWarning = "Name must consist of letters only!";
    private const string Caption = "Wrong spelling";

    public Tasks ParentForm { get; set; }

    public TasksInput()
    {
        InitializeComponent();
        cbType.DataSource = TaskTypes;
    }

    private void bAdd_Click(object sender, EventArgs e)
    {
        if (!CheckName())
        {
            DisplayWarning();
            return;
        }

        MainForm.Tasks.Add(new Task(tbName.Text, TaskTypes.ElementAt(cbType.SelectedIndex), dtpDeadline.Text));
        this.Close();
    }

    private bool CheckName()
    {
        foreach (var c in tbName.Text)
        {
            if (char.IsLetter(c) || char.IsWhiteSpace(c))
            {
                continue;
            }

            return false;
        }

        return true;
    }

    private void DisplayWarning()
    {
        MessageBox.Show(NameWarning, Caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
    }

    private void TasksInput_FormClosing(object sender, FormClosingEventArgs e)
    {
        var count = ParentForm.Controls.Count - 2;
        for (int i = 0; i < count; i++)
        {
            ParentForm.Controls.RemoveAt(2);
        }
        ParentForm.DisplayTasks();
    }
}
