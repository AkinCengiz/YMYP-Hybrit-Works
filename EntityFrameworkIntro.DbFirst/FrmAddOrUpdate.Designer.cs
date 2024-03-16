namespace EntityFrameworkIntro.DbFirst;

partial class FrmAddOrUpdate
{
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
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
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
        txtCompanyName = new TextBox();
        SuspendLayout();
        // 
        // txtCompanyName
        // 
        txtCompanyName.Location = new Point(12, 12);
        txtCompanyName.Name = "txtCompanyName";
        txtCompanyName.PlaceholderText = "Company Name";
        txtCompanyName.Size = new Size(153, 23);
        txtCompanyName.TabIndex = 0;
        // 
        // FrmAddOrUpdate
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(txtCompanyName);
        Name = "FrmAddOrUpdate";
        Text = "FrmAddOrUpdate";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtCompanyName;
}