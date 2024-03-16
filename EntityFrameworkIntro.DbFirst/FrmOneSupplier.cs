using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkIntro.DbFirst.Entities;

namespace EntityFrameworkIntro.DbFirst;
public partial class FrmOneSupplier : Form
{
    public FrmOneSupplier()
    {
        InitializeComponent();
    }

    private void btnGetSupplier_Click(object sender, EventArgs e)
    {
        NorthwindContext context = new NorthwindContext();
        Supplier supplier = context.Suppliers.FirstOrDefault(x => x.SupplierId == Convert.ToInt32(txtId.Text));
        lblContactName.Text = supplier.ContactName;
        lblContactTitle.Text = supplier.ContactTitle;
        txtCompanyName.Text = supplier.CompanyName;
    }
}
