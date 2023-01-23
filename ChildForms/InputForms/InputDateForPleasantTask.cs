using static Project.MainForm;

namespace Project.ChildForms.InputForms;

public partial class InputDateForPleasantTask : Form
{
    public int Index { get; set; }
    public MainForm ParentForm { get; set; }

    public InputDateForPleasantTask()
    {
        InitializeComponent();
    }

    private void bConfirm_Click(object sender, EventArgs e)
    {
        var date = DateOnly.Parse(dtpDate.Text).ToString();
        var task = PleasantTasksShopList.ElementAt(Index);
        task.Date = date;
        PleasantTasksList.Add(task);
        CurrentUser.SubtractFromBalance(task.Cost);
        ParentForm.lCurrentBalance.Text = CurrentUser.Balance.ToString();
        this.Close();
    }
}