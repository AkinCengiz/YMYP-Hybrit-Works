using EntityFrameworkIntro.DbFirstApp.Models;

namespace EntityFrameworkIntro.DbFirstApp;

public partial class FrmProducts : Form
{
    public FrmProducts()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        NorthwndContext context = new NorthwndContext();
        dataGridView1.DataSource = context.Products.ToList();
        cmbCategories.DataSource = context.Categories.ToList();
        cmbCategories.DisplayMember = "CategoryName";
        cmbCategories.ValueMember = "CategoryId";
    }

    private void btnFiltre_Click(object sender, EventArgs e)
    {
        decimal minPrice = Convert.ToDecimal(txtMin.Text);
        decimal maxPrice = Convert.ToDecimal(txtMax.Text);
        NorthwndContext context = new NorthwndContext();
        var products = context.Products.Where(p => p.UnitPrice >= minPrice && p.UnitPrice <= maxPrice).ToList();
        dataGridView1.DataSource =products;

    }
}
