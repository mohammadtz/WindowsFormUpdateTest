namespace WindowsFormUpdateTest;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        version.Text = GetVersion();
    }

    private string GetVersion() => $"Version: {Application.ProductVersion}";
}
