using EntityFrameworkIntro.DbFirstApp.Models;

namespace EntityFrameworkIntro.DbFirstApp;

public partial class FrmProducts : Form
{
    public FrmProducts()
    {
        InitializeComponent();
    }

    public static Product _product;
    private void Form1_Load(object sender, EventArgs e)
    {
        NorthwndContext context = new NorthwndContext();
        dataGridView1.DataSource = context.Products.ToList();
        var categories = context.Categories.ToList();
        cmbCategories.DataSource = categories;
        cmbCategories.DisplayMember = "CategoryName";
        cmbCategories.ValueMember = "CategoryID";

    }

    private void btnFiltre_Click(object sender, EventArgs e)
    {
        decimal minPrice = Convert.ToDecimal(txtMin.Text);
        decimal maxPrice = Convert.ToDecimal(txtMax.Text);
        NorthwndContext context = new NorthwndContext();
        var products = context.Products.Where(p => p.UnitPrice >= minPrice && p.UnitPrice <= maxPrice).ToList();
        dataGridView1.DataSource = products;

    }

    private void cmbCategories_SelectedIndexChanged(object sender, EventArgs e)
    {
        //var category = cmbCategories.SelectedValue;

        //NorthwndContext context = new NorthwndContext();
        //var products = context.Products.Where(p => p.Category == category).ToList();
        //dataGridView1.DataSource = products;
    }

    private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
    {
        
    }

    private void btnNew_Click(object sender, EventArgs e)
    {
        FrmAddOrUpdateProduct frm = new FrmAddOrUpdateProduct();
        frm.Text = "Add Product";
        frm.Show();
    }

    private void dataGridView1_DoubleClick(object sender, EventArgs e)
    {
        int id = Convert.ToInt32(dataGridView1.CurrentRow.Cells[0].Value);
        NorthwndContext context = new NorthwndContext();
        _product = context.Products.FirstOrDefault(p => p.ProductId == id);
        
        FrmAddOrUpdateProduct frm = new FrmAddOrUpdateProduct();
        frm.Text = "Update Product";
        
        frm.Show();
    }
    void LoadGrid()
    {
        NorthwndContext context = new NorthwndContext();
        dataGridView1.DataSource = context.Products.ToList();
    }
}
