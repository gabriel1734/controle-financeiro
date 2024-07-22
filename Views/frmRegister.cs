using controlefinanceiro.Controllers;
using controlefinanceiro.Models;
using System;
using System.Windows.Forms;

namespace controlefinanceiro.Views
{
    public partial class frmRegister : Form
    {
        public frmRegister()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string password = txtPassword.Text;
            string confirmPassword = txtConfirmPassword.Text;

            try
            {
                UsuarioController.storeUser(username, password, confirmPassword);
                MessageBox.Show("User registered successfully!");
                Usuario user = UsuarioController.getUser(username, password);
                if (user != null)
                {
                    this.Hide();
                    frmHome home = new frmHome(user);
                    home.Show();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Registration Failed, try again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
