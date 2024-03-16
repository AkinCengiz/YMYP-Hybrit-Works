namespace EntityFrameworkIntro.DbFirst;

partial class FrmOneSupplier
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
        txtId = new TextBox();
        label1 = new Label();
        label2 = new Label();
        txtCompanyName = new Label();
        lblContactName = new Label();
        label4 = new Label();
        lblContactTitle = new Label();
        lblConTitle = new Label();
        btnGetSupplier = new Button();
        SuspendLayout();
        // 
        // txtId
        // 
        txtId.Location = new Point(128, 23);
        txtId.Name = "txtId";
        txtId.Size = new Size(75, 23);
        txtId.TabIndex = 0;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(28, 26);
        label1.Name = "label1";
        label1.Size = new Size(24, 15);
        label1.TabIndex = 1;
        label1.Text = "ID :";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(28, 77);
        label2.Name = "label2";
        label2.Size = new Size(100, 15);
        label2.TabIndex = 2;
        label2.Text = "Company Name :";
        // 
        // txtCompanyName
        // 
        txtCompanyName.AutoSize = true;
        txtCompanyName.Location = new Point(131, 77);
        txtCompanyName.Name = "txtCompanyName";
        txtCompanyName.Size = new Size(13, 15);
        txtCompanyName.TabIndex = 3;
        txtCompanyName.Text = "0";
        // 
        // lblContactName
        // 
        lblContactName.AutoSize = true;
        lblContactName.Location = new Point(131, 107);
        lblContactName.Name = "lblContactName";
        lblContactName.Size = new Size(13, 15);
        lblContactName.TabIndex = 5;
        lblContactName.Text = "0";
        // 
        // label4
        // 
        label4.AutoSize = true;
        label4.Location = new Point(28, 107);
        label4.Name = "label4";
        label4.Size = new Size(90, 15);
        label4.TabIndex = 4;
        label4.Text = "Contact Name :";
        // 
        // lblContactTitle
        // 
        lblContactTitle.AutoSize = true;
        lblContactTitle.Location = new Point(131, 135);
        lblContactTitle.Name = "lblContactTitle";
        lblContactTitle.Size = new Size(13, 15);
        lblContactTitle.TabIndex = 7;
        lblContactTitle.Text = "0";
        // 
        // lblConTitle
        // 
        lblConTitle.AutoSize = true;
        lblConTitle.Location = new Point(28, 135);
        lblConTitle.Name = "lblConTitle";
        lblConTitle.Size = new Size(80, 15);
        lblConTitle.TabIndex = 6;
        lblConTitle.Text = "Contact Title :";
        // 
        // btnGetSupplier
        // 
        btnGetSupplier.Location = new Point(234, 23);
        btnGetSupplier.Name = "btnGetSupplier";
        btnGetSupplier.Size = new Size(75, 23);
        btnGetSupplier.TabIndex = 8;
        btnGetSupplier.Text = "Get Supplier";
        btnGetSupplier.UseVisualStyleBackColor = true;
        btnGetSupplier.Click += btnGetSupplier_Click;
        // 
        // FrmOneSupplier
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnGetSupplier);
        Controls.Add(lblContactTitle);
        Controls.Add(lblConTitle);
        Controls.Add(lblContactName);
        Controls.Add(label4);
        Controls.Add(txtCompanyName);
        Controls.Add(label2);
        Controls.Add(label1);
        Controls.Add(txtId);
        Name = "FrmOneSupplier";
        Text = "FrmOneSupplier";
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtId;
    private Label label1;
    private Label label2;
    private Label txtCompanyName;
    private Label lblContactName;
    private Label label4;
    private Label lblContactTitle;
    private Label lblConTitle;
    private Button btnGetSupplier;
}