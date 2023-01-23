using static Project.MainForm;

namespace Project.ChildForms.InputForms;

public partial class PleasantTaskDelete : Form
{
    public PleasantTasksShop ParentForm { get; set; }

    public PleasantTaskDelete()
    {
        InitializeComponent();
        cbPleasantTask.DataSource = PleasantTasksList;
    }

    private void bDelete_Click(object sender, EventArgs e)
    {
        PleasantTasksList.Remove(PleasantTasksList.ElementAt(cbPleasantTask.SelectedIndex));
        this.Close();
    }

    private void PleasantTaskDelete_FormClosing(object sender, FormClosingEventArgs e)
    {
        var count = ParentForm.Controls.Count - 2;
        for (int i = 0; i < count; i++)
        {
            ParentForm.Controls.RemoveAt(2);
        }
        ParentForm.DisplayDefaultPleasantTasks();
    }
}
