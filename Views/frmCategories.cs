using controlefinanceiro.Models;
using ControleFinanceiro.Controllers;
using Microsoft.VisualBasic.ApplicationServices;
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
    public partial class frmCategories : Form
    {
        private Usuario user;

        public frmCategories(Usuario user)
        {
            InitializeComponent();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
            List<Categoria> categoria = DashboardController.ListarCategorias();
            categorias.DataSource = categoria;
            categorias.DisplayMember = "Nome";
            categorias.ValueMember = "Id";
        }

        private void btnEditCat_Click(object sender, EventArgs e)
        {
            if(categorias.SelectedItem == null)
            {
                MessageBox.Show("Select a category to edit");
                return;
            }

            Categoria categoria = (Categoria)categorias.SelectedItem;
            Views.frmEditCategory editCategories = new(categoria);
            editCategories.Show();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Views.frmAddNewCat newCategories = new Views.frmAddNewCat(user);
            newCategories.Show();
            frmCategories_Load(sender, e);
        }
    }
}
