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
    }
}
