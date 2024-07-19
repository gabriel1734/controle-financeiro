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

        public frmCategories()
        {
            InitializeComponent();
            loadCategories();
        }

        private void frmCategories_Load(object sender, EventArgs e)
        {
        }

        private void loadCategories()
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

            using (Views.frmEditCategory editCategory = new Views.frmEditCategory((Categoria)categorias.SelectedItem))
            {
                editCategory.ShowDialog();
                loadCategories();
            }
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            using (Views.frmAddNewCat newCategories = new Views.frmAddNewCat())
            {
                newCategories.ShowDialog();
                loadCategories();
            }
        }
    }
}
