namespace EntityFrameworkIntro.DbFirstApp;

partial class FrmProducts
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
        dataGridView1 = new DataGridView();
        txtMin = new TextBox();
        label1 = new Label();
        label2 = new Label();
        txtMax = new TextBox();
        btnFiltre = new Button();
        cmbCategories = new ComboBox();
        btnNew = new Button();
        ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
        SuspendLayout();
        // 
        // dataGridView1
        // 
        dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        dataGridView1.Location = new Point(12, 60);
        dataGridView1.Name = "dataGridView1";
        dataGridView1.Size = new Size(776, 378);
        dataGridView1.TabIndex = 0;
        dataGridView1.CellClick += dataGridView1_CellClick;
        dataGridView1.DoubleClick += dataGridView1_DoubleClick;
        // 
        // txtMin
        // 
        txtMin.Location = new Point(46, 12);
        txtMin.Name = "txtMin";
        txtMin.Size = new Size(100, 23);
        txtMin.TabIndex = 1;
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Location = new Point(12, 15);
        label1.Name = "label1";
        label1.Size = new Size(28, 15);
        label1.TabIndex = 2;
        label1.Text = "Min";
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Location = new Point(172, 15);
        label2.Name = "label2";
        label2.Size = new Size(30, 15);
        label2.TabIndex = 4;
        label2.Text = "Max";
        // 
        // txtMax
        // 
        txtMax.Location = new Point(206, 12);
        txtMax.Name = "txtMax";
        txtMax.Size = new Size(100, 23);
        txtMax.TabIndex = 3;
        // 
        // btnFiltre
        // 
        btnFiltre.Location = new Point(323, 12);
        btnFiltre.Name = "btnFiltre";
        btnFiltre.Size = new Size(88, 23);
        btnFiltre.TabIndex = 5;
        btnFiltre.Text = "Filter";
        btnFiltre.UseVisualStyleBackColor = true;
        btnFiltre.Click += btnFiltre_Click;
        // 
        // cmbCategories
        // 
        cmbCategories.FormattingEnabled = true;
        cmbCategories.Location = new Point(620, 12);
        cmbCategories.Name = "cmbCategories";
        cmbCategories.Size = new Size(168, 23);
        cmbCategories.TabIndex = 6;
        cmbCategories.SelectedIndexChanged += cmbCategories_SelectedIndexChanged;
        // 
        // btnNew
        // 
        btnNew.Location = new Point(517, 11);
        btnNew.Name = "btnNew";
        btnNew.Size = new Size(75, 23);
        btnNew.TabIndex = 7;
        btnNew.Text = "NEW";
        btnNew.UseVisualStyleBackColor = true;
        btnNew.Click += btnNew_Click;
        // 
        // FrmProducts
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(800, 450);
        Controls.Add(btnNew);
        Controls.Add(cmbCategories);
        Controls.Add(btnFiltre);
        Controls.Add(label2);
        Controls.Add(txtMax);
        Controls.Add(label1);
        Controls.Add(txtMin);
        Controls.Add(dataGridView1);
        Name = "FrmProducts";
        Text = "Form1";
        Load += Form1_Load;
        ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private DataGridView dataGridView1;
    private TextBox txtMin;
    private Label label1;
    private Label label2;
    private TextBox txtMax;
    private Button btnFiltre;
    private ComboBox cmbCategories;
    private Button btnNew;
}
