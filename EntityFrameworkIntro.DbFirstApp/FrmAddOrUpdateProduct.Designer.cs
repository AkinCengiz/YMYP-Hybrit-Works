namespace EntityFrameworkIntro.DbFirstApp;

partial class FrmAddOrUpdateProduct
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
        txtProductName = new TextBox();
        txtUnitPrice = new TextBox();
        txtStock = new TextBox();
        btnSave = new Button();
        SuspendLayout();
        // 
        // txtProductName
        // 
        txtProductName.Location = new Point(12, 27);
        txtProductName.Name = "txtProductName";
        txtProductName.PlaceholderText = "Product Name";
        txtProductName.Size = new Size(187, 23);
        txtProductName.TabIndex = 0;
        // 
        // txtUnitPrice
        // 
        txtUnitPrice.Location = new Point(12, 56);
        txtUnitPrice.Name = "txtUnitPrice";
        txtUnitPrice.PlaceholderText = "Unit Price";
        txtUnitPrice.Size = new Size(187, 23);
        txtUnitPrice.TabIndex = 1;
        // 
        // txtStock
        // 
        txtStock.Location = new Point(12, 85);
        txtStock.Name = "txtStock";
        txtStock.PlaceholderText = "Stock";
        txtStock.Size = new Size(187, 23);
        txtStock.TabIndex = 2;
        // 
        // btnSave
        // 
        btnSave.Location = new Point(124, 123);
        btnSave.Name = "btnSave";
        btnSave.Size = new Size(75, 23);
        btnSave.TabIndex = 3;
        btnSave.Text = "button1";
        btnSave.UseVisualStyleBackColor = true;
        btnSave.Click += btnSave_Click;
        // 
        // FrmAddOrUpdateProduct
        // 
        AutoScaleDimensions = new SizeF(7F, 15F);
        AutoScaleMode = AutoScaleMode.Font;
        ClientSize = new Size(298, 450);
        Controls.Add(btnSave);
        Controls.Add(txtStock);
        Controls.Add(txtUnitPrice);
        Controls.Add(txtProductName);
        Name = "FrmAddOrUpdateProduct";
        Text = "FrmAddOrUpdateProduct";
        Load += FrmAddOrUpdateProduct_Load;
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private TextBox txtProductName;
    private TextBox txtUnitPrice;
    private TextBox txtStock;
    private Button btnSave;
}