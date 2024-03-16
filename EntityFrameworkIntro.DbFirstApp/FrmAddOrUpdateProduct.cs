using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkIntro.DbFirstApp.Models;

namespace EntityFrameworkIntro.DbFirstApp;
public partial class FrmAddOrUpdateProduct : Form
{
    
    public FrmAddOrUpdateProduct()
    {
        InitializeComponent();
    }

    private void FrmAddOrUpdateProduct_Load(object sender, EventArgs e)
    {
        btnSave.Text = (this.Text == "Add Product") ? "Add" : "Update";
        if (this.Text == "Update Product")
        {
            txtProductName.Text = FrmProducts._product.ProductName;
            txtUnitPrice.Text = FrmProducts._product.UnitPrice.ToString();
            txtStock.Text = FrmProducts._product.UnitsInStock.ToString();
        }
    }

    private void btnSave_Click(object sender, EventArgs e)
    {
        string name = txtProductName.Text;
        decimal unitPrice = Convert.ToDecimal(txtUnitPrice.Text);
        short stock = Convert.ToInt16(txtStock.Text);
        NorthwndContext context = new NorthwndContext();
        if (stock < 0 || stock > 100)
        {
            MessageBox.Show("Stok miktarı 0 ile 100 arasında olmalıdır...");
            return;
        }
        if (this.Text == "Add Product")
        {
            context.Products.Add(new()
            {
                ProductName = "Laptop",
                UnitPrice = unitPrice,
                UnitsInStock = stock
            });
            context.SaveChanges();
        }
        else
        {
            var product = FrmProducts._product;
            product.ProductName = name;
            product.UnitPrice = unitPrice;
            product.UnitsInStock = stock;
            context.Products.Update(product);
            context.SaveChanges();
            this.Close();
            FrmProducts frm = new FrmProducts();
            frm.Show();
        }
    }

    
}
