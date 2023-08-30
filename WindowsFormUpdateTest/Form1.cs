namespace WindowsFormUpdateTest;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
        version.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version?.ToString();
    }
}
