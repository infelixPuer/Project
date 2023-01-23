using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace Project.ChildForms.InputForms;

public partial class UserNameInput : Form
{
    private const string NameWarning = "Name must consist of letters only!";
    private const string Caption = "Wrong spelling";

    public MainForm ParentForm { get; set; }

    public UserNameInput()
    {
        InitializeComponent();
    }

    private void bConfirm_Click(object sender, EventArgs e)
    {
        if (!CheckUserName())
        {
            DisplayWarning();
            return;
        }

        MainForm.CurrentUser = new User(tbUserName.Text);
        ParentForm.lName.Text = MainForm.CurrentUser.Name;
        ParentForm.lCurrentBalance.Text = MainForm.CurrentUser.Balance.ToString();
        this.Close();
    }

    private bool CheckUserName()
    {
        var name = tbUserName.Text;

        foreach (var c in name)
        {
            if (char.IsLetter(c) || char.IsWhiteSpace(c)) { continue; }

            return false;
        }

        return true;
    }

    private void DisplayWarning()
    {
        MessageBox.Show(NameWarning, Caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        return;
    }
}
