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
            idCategoria.Text = categoria.Id.ToString();
        }

        private void btnDoneEdit_Click(object sender, EventArgs e)
        {
            DashboardController.EditarCategoria(newNameCategoria.Text, Convert.ToInt32(idCategoria.Text));
            MessageBox.Show("Category Successfully Edited");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void btnEraseCat_Click(object sender, EventArgs e)
        {
            DashboardController.RemoverCategoria(Convert.ToInt32(idCategoria.Text));
            MessageBox.Show("Category Successfully Removed");
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
