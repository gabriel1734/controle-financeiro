using controlefinanceiro.Models;
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

        }

        private void btnEditCat_Click(object sender, EventArgs e)
        {
            Views.frmEditCategory editCategories = new Views.frmEditCategory(user);
            editCategories.Show();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            Views.frmAddNewCat newCategories = new Views.frmAddNewCat(user);
            newCategories.Show();
        }
    }
}
