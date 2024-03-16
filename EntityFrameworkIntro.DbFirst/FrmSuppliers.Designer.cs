namespace EntityFrameworkIntro.DbFirst;

partial class FrmSuppliers
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
        btnOrderByCompanyName = new Button();
        txtSearch = new TextBox();
        lblSearch = new Label();
        label1 = new Label();
        txtTake = new TextBox();
        dgvSupplier = new DataGridView();
        btnTake = new Button();
        btnNewForm = new Button();
        btnNew = new Button();
        ((System.ComponentModel.ISupportInitialize)dgvSupplier).BeginInit();
        SuspendLayout();
        // 
        // btnOrderByCompanyName
        // 
        btnOrderByCompanyName.Location = new Point(12, 12);
        btnOrderByCompanyName.Name = "btnOrderByCompanyName";
        btnOrderByCompanyName.Size = new Size(104, 45);
        btnOrderByCompanyName.TabIndex = 0;
        btnOrderByCompanyName.Text = "Order By Company Name";
        btnOrderByCompanyName.UseVisualStyleBackColor = true;
        btnOrderByCompanyName.Click += btnOrderByCompanyName_Click;
        // 
        // txtSearch
        // 
        txtSearch.Location = new Point(199, 24);
        txtSearch.Name = "txtSearch";
        txtSearch.Size = new Size(100, 23);
        txtSearch.TabIndex = 1;
        // 
        // lblSearch
        // 
        lblSearch.AutoSize = true;
        lblSearch.Location = new Point(129, 30);
        lblSearch.Name = "lblSearch";
        lblSearch.Size = new Size(51, 15);
        lblSearch.TabIndex = 2;
        lblSearch.Text = "Search : ";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(319, 30);
        label1.Name = "label1";
        label1.Size = new Size(39, 15);
        label1.TabIndex = 4;
        label1.Text = "Take : ";
        // 
        // txtTake
        // 
        txtTake.Location = new Point(364, 27);
        txtTake.Name = "txtTake";
        txtTake.Size = new Size(100, 23);
        txtTake.TabIndex = 3;
        // 
        // dgvSupplier
        // 
        dgvSupplier.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dgvSupplier.Location = new Point(12, 73);
        dgvSupplier.Name = "dgvSupplier";
        dgvSupplier.Size = new Size(776, 365);
        dgvSupplier.TabIndex = 5;
        // 
        // btnTake
        // 
        btnTake.Location = new Point(481, 26);
        btnTake.Name = "btnTake";
        btnTake.Size = new Size(75, 23);
        btnTake.TabIndex = 6;
        btnTake.Text = "Take";
        btnTake.UseVisualStyleBackColor = true;
        btnTake.Click += btnTake_Click;
        // 
        // btnNewForm
        // 
        btnNewForm.Location = new Point(586, 27);
        btnNewForm.Name = "btnNewForm";
        btnNewForm.Size = new Size(75, 23);
        btnNewForm.TabIndex = 7;
        btnNewForm.Text = "GET";
        btnNewForm.UseVisualStyleBackColor = true;
        btnNewForm.Click += btnNewForm_Click;
        // 
        // btnNew
        // 
        btnNew.Location = new Point(703, 26);
        btnNew.Name = "btnNew";
        btnNew.Size = new Size(75, 23);
        btnNew.TabIndex = 8;
        btnNew.Text = "NEW";
        btnNew.UseVisualStyleBackColor = true;
        // 
        // FrmSuppliers
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnNew);
        Controls.Add(btnNewForm);
        Controls.Add(btnTake);
        Controls.Add(dgvSupplier);
        Controls.Add(label1);
        Controls.Add(txtTake);
        Controls.Add(lblSearch);
        Controls.Add(txtSearch);
        Controls.Add(btnOrderByCompanyName);
        Name = "FrmSuppliers";
        Text = "FrmSuppliers";
        Load += FrmSuppliers_Load;
        ((System.ComponentModel.ISupportInitialize)dgvSupplier).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button btnOrderByCompanyName;
    private TextBox txtSearch;
    private Label lblSearch;
    private Label label1;
    private TextBox txtTake;
    private DataGridView dgvSupplier;
    private Button btnTake;
    private Button btnNewForm;
    private Button btnNew;
}