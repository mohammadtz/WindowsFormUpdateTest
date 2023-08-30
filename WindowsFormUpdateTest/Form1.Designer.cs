namespace WindowsFormUpdateTest;

partial class Form1
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        label1 = new Label();
        textBox1 = new TextBox();
        version = new Label();
        SuspendLayout();
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI", 48F, FontStyle.Regular, GraphicsUnit.Point);
        label1.Location = new Point(205, 33);
        label1.Name = "label1";
        label1.Size = new Size(393, 86);
        label1.TabIndex = 0;
        label1.Text = "Hello World!";
        // 
        // textBox1
        // 
        textBox1.Location = new Point(356, 213);
        textBox1.Name = "textBox1";
        textBox1.Size = new Size(100, 23);
        textBox1.TabIndex = 1;
        // 
        // version
        // 
        version.AutoSize = true;
        version.Location = new Point(386, 149);
        version.Name = "version";
        version.Size = new Size(45, 15);
        version.TabIndex = 2;
        version.Text = "version";
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(version);
        Controls.Add(textBox1);
        Controls.Add(label1);
        Name = "Form1";
        Text = "Form1";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Label label1;
    private TextBox textBox1;
    private Label version;
}
