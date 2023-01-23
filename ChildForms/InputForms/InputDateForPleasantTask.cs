namespace Project.ChildForms.InputForms;

public partial class InputDateForPleasantTask : Form
{
    public int Index { get; set; }

    public InputDateForPleasantTask()
    {
        InitializeComponent();
    }

    private void bConfirm_Click(object sender, EventArgs e)
    {
        var date = DateOnly.Parse(dtpDate.Text).ToString();
        var task = MainForm.PleasantTasksShopList.ElementAt(Index);
        task.Date = date;
        MainForm.PleasantTasksList.Add(task);
        this.Close();
    }
}