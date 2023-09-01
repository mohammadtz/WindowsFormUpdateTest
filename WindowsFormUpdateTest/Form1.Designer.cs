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
        label2 = new Label();
        button1 = new Button();
        button2 = new Button();
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
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(386, 254);
        label2.Name = "label2";
        label2.Size = new Size(45, 15);
        label2.TabIndex = 3;
        label2.Text = "Persian";
        // 
        // button1
        // 
        button1.Location = new Point(333, 300);
        button1.Name = "button1";
        button1.Size = new Size(140, 23);
        button1.TabIndex = 4;
        button1.Text = "Min Version Required";
        button1.UseVisualStyleBackColor = true;
        // 
        // button2
        // 
        button2.Location = new Point(333, 329);
        button2.Name = "button2";
        button2.Size = new Size(140, 23);
        button2.TabIndex = 4;
        button2.Text = "Min Version Required";
        button2.UseVisualStyleBackColor = true;
        // 
        // Form1
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(button2);
        Controls.Add(button1);
        Controls.Add(label2);
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
    private Label label2;
    private Button button1;
    private Button button2;
}
