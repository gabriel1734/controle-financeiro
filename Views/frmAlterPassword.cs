using controlefinanceiro.Controllers;
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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;


namespace controlefinanceiro.Views
{
    public partial class frmAlterPassword : Form
    {
        private Usuario usuario;
        public frmAlterPassword(Usuario user)
        {
            InitializeComponent();
            this.usuario = user;
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            try
            {
                UsuarioController.setNewPassword(txtPassword.Text, txtConfirmPassword.Text, usuario);
                MessageBox.Show("Password changed successfully!!!");
                this.Hide();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Password change failed or password don't match, try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
