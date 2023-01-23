using Project.ChildForms.InputForms;
using System.Reflection;
using System.Text.Json;
using static Project.MainForm;

namespace Project.ChildForms;

public partial class PleasantTasksShop : Form, ISavableControls
{
    private const string PleasantTasksControlsFileName = "PleasantTasksShopControls.json";
    private const string PleasantTasksListFileName = "PleasantTasksShopList.json";
    private string _jsonString;

    private const string NotEnoughPointsWarningMessage = "You haven't got enough points to buy this task!";
    private const string Caption = "Not enough points";

    public MainForm ParentForm { get; set; }

    public PleasantTasksShop()
    {
        InitializeComponent();

        UploadTypes();
    }
    private void UploadTypes()
    {
        if (File.Exists(PleasantTasksControlsFileName))
        {
            return;
        }

        DisplayDefaultPleasantTasks();
    }

    public void DisplayDefaultPleasantTasks()
    {
        for (int i = 0; i < PleasantTasksShopList.Count; i++)
        {
            PleasantTasksShopList[i].SetTools(this, i);
        }
    }    

    public void SaveControls()
    {
        var controlPropierties = new List<ControlProperties>();

        foreach (Control control in this.Controls)
        {
            var cp = new ControlProperties();
            cp.Type = control.GetType().FullName;
            cp.Name = control.Name;
            cp.Text = control.Text;
            cp.Location = control.Location;
            cp.Size = control.Size;
            cp.AutoSize = control.AutoSize;
            cp.Visiable = control.Visible;
            controlPropierties.Add(cp);
        }

        _jsonString = JsonSerializer.Serialize(controlPropierties);
        File.WriteAllText(PleasantTasksControlsFileName, _jsonString);
        _jsonString = JsonSerializer.Serialize(PleasantTasksShopList);
        File.WriteAllText(PleasantTasksListFileName, _jsonString);
    }

    public void LoadControls()
    {
        if (!File.Exists(PleasantTasksControlsFileName)) { return; }

        _jsonString = File.ReadAllText(PleasantTasksControlsFileName);
        var controls = JsonSerializer.Deserialize<List<ControlProperties>>(_jsonString);

        if (controls == null) { return; }

        foreach (var cp in controls)
        {
            var assembly = Assembly.GetAssembly(typeof(Label));

            if (assembly == null) { return; }

            var type = assembly.GetType(cp.Type);

            if (type != null)
            {
                var control = (Control)Activator.CreateInstance(type);
                control.Name = cp.Name;
                control.Text = cp.Text;
                control.Location = cp.Location;
                control.Size = cp.Size;
                control.AutoSize = cp.AutoSize;
                control.Visible = cp.Visiable;
                Controls.Add(control);
            }
        }
    }

    private void bAdd_Click(object sender, EventArgs e)
    {
        var inputForm = new PleasantTaskInput();
        inputForm.StartPosition = FormStartPosition.CenterScreen;
        inputForm.ParentForm = this;
        inputForm.ShowDialog();
    }

    private void bDelete_Click(object sender, EventArgs e)
    {
        var inputForm = new PleasantTaskDelete();
        inputForm.StartPosition = FormStartPosition.CenterScreen;
        inputForm.ParentForm = this;
        inputForm.ShowDialog();
    }

    private void bBuy_Click(object sender, EventArgs e)
    {
        var checkBoxes = new List<CheckBox>();
        var totalCost = 0;

        for (int i = 0; i < PleasantTasksShopList.Count; i++)
        {
            checkBoxes.Add((CheckBox)Controls.Find($"cbCompleted_{i}", true)[0]);
        }

        for (int i = 0; i < checkBoxes.Count; i++)
        {
            if (checkBoxes[i].Checked)
            {
                totalCost += PleasantTasksShopList[i].Cost;
            }
        }

        if (totalCost > CurrentUser.Balance)
        {
            DisplayWarning();
            return;
        }

        for (int i = 0; i < checkBoxes.Count; i++)
        {
            if (checkBoxes[i].Checked)
            {
                var inputForm = new InputDateForPleasantTask();
                inputForm.StartPosition = FormStartPosition.CenterScreen;
                inputForm.Index = i;
                inputForm.ParentForm = ParentForm;
                inputForm.ShowDialog();
            }
        }
    }

    private void DisplayWarning()
    {
        MessageBox.Show(NotEnoughPointsWarningMessage, Caption, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);        
    }
}
