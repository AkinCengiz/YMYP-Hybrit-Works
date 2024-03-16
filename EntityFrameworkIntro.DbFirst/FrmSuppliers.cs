using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EntityFrameworkIntro.DbFirst.Models;

namespace EntityFrameworkIntro.DbFirst;
public partial class FrmSuppliers : Form
{
    public FrmSuppliers()
    {
        InitializeComponent();
    }

    private NorthwndContext _context;
    private void FrmSuppliers_Load(object sender, EventArgs e)
    {
        _context = new NorthwndContext();
        dgvSupplier.DataSource = _context.Suppliers.ToList();
    }

    private void btnOrderByCompanyName_Click(object sender, EventArgs e)
    {
        _context = new NorthwndContext();
        var suppliers = _context.Suppliers.OrderBy(s => s.CompanyName).ToList();
        dgvSupplier.DataSource = suppliers;
    }

    private void btnTake_Click(object sender, EventArgs e)
    {
        int take = Convert.ToInt32(txtTake.Text);
        _context = new NorthwndContext();
        var suppliers = _context.Suppliers.Take(take).ToList();
        dgvSupplier.DataSource = suppliers;
    }

    private void btnNewForm_Click(object sender, EventArgs e)
    {
        FrmOneSupplier frm = new FrmOneSupplier();
        frm.Show();
    }
}
