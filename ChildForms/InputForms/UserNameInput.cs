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

        ParentForm.User = new User(tbUserName.Text);
        ParentForm.lName.Text = ParentForm.User.Name;
        ParentForm.lCurrentBalance.Text = ParentForm.User.Balance.ToString();
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
