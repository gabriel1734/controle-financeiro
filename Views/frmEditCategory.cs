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
    public partial class frmEditCategory : Form
    {
        public frmEditCategory(Categoria categoria)
        {
            InitializeComponent();
            LoadCategoryData(categoria);
        }

        private void frmEditCategory_Load(object sender, EventArgs e)
        {

        }

        private void LoadCategoryData(Categoria categoria)
        {
            nameCategoria.Text = categoria.Nome;
        }

        private void btnDoneEdit_Click(object sender, EventArgs e)
        {
            DashboardController.EditarCategoria(newNameCategoria.Text);
        }

    }
}
