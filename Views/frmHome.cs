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
    public partial class frmHome : Form
    {
        public frmHome(Models.Usuario user)
        {
            InitializeComponent();
        }
        bool manageExpand = false;

        private void manageTransition_Tick(object sender, EventArgs e)
        {
            if (manageExpand == false)
            {
                manageContainer.Height += 10;
                if (manageContainer.Height >= 171)
                {
                    manageTransition.Stop();
                    manageExpand = true;
                }
            }
            else
            {
                manageContainer.Height -= 10;
                if (manageContainer.Height <= 43)
                {
                    manageTransition.Stop();
                    manageExpand = false;
                }
            }
        }

        private void btnManage_Click(object sender, EventArgs e)
        {
            manageTransition.Start();
        }

        private void btnSidebar_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        bool sidebarExpand = false;
        private Usuario user;

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == false)
            {
                sidebarContainer.Width += 10;
                if (sidebarContainer.Width >= 200)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = true;
                }
            }
            else
            {
                sidebarContainer.Width -= 10;
                if (sidebarContainer.Width <= 0)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = false;
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Views.frmAddTransaction addTransaction = new Views.frmAddTransaction(user);
            addTransaction.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Views.frmEditTransaction editTransaction = new Views.frmEditTransaction(user);
            editTransaction.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Views.frmCategories categories = new Views.frmCategories(user);
            categories.Show();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }
    }
}
