namespace Project.ChildForms.InputForms;

public partial class PleasantTaskInput : Form
{
    private const string NameWarning = "Name must consist of letters only!";
    private const string CostWarning = "Cost must consist of digits only!";
    private const string Caption = "Wrong spelling";

    public PleasantTasksShop ParentForm { get; set; }

    public PleasantTaskInput()
    {
        InitializeComponent();
    }

    private void bAdd_Click(object sender, EventArgs e)
    {
        if (!CheckName())
        {
            DisplayWarning("name");
            return;
        }

        if (!CheckCost())
        {
            DisplayWarning("cost");
            return;
        }

        MainForm.PleasantTasksList.Add(new PleasantTask(tbName.Text, int.Parse(tbCost.Text), ""));
        this.Close();
    }

    private bool CheckName()
    {
        var name = tbName.Text;

        foreach (var c in name)
        {
            if (char.IsLetter(c) || char.IsWhiteSpace(c)) { continue; }

            return false;
        }

        return true;
    }

    private bool CheckCost()
    {
        var cost = tbCost.Text;

        foreach (var c in cost)
        {
            if (char.IsDigit(c)) { continue; }

            return false;
        }

        return true;
    }

    private void DisplayWarning(string objectOfWarning)
    {
        if (objectOfWarning == "name")
        {
            MessageBox.Show(NameWarning, Caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }

        if (objectOfWarning == "cost")
        {
            MessageBox.Show(CostWarning, Caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            return;
        }
    }

    private void PleasantTaskInput_FormClosing(object sender, FormClosingEventArgs e)
    {
        var count = ParentForm.Controls.Count - 2;
        for (int i = 0; i < count; i++)
        {
            ParentForm.Controls.RemoveAt(2);
        }
        ParentForm.DisplayDefaultPleasantTasks();
    }
}
