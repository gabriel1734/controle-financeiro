using controlefinanceiro.Models;
using ControleFinanceiro.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace controlefinanceiro.Views
{
    public partial class frmAddNewCat : Form
    {
        public frmAddNewCat()
        {
            InitializeComponent();
        }

        private void frmAddNewCat_Load(object sender, EventArgs e)
        {

        }
        private void btnAddNew_Click(object sender, EventArgs e)
        {
            DashboardController.AdicionarCategoria(categoria.Text);
            MessageBox.Show("Category Added Successfully ");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
