using controlefinanceiro.Controllers;
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
            
            Controllers.UsuarioController.storeUser(username,password,confirmPassword);
            MessageBox.Show("User registered successfully.!!!");
            Models.Usuario user = UsuarioController.getUser(username, password);
            this.Hide();
            frmHome home = new(user);
            home.Show();
        }
    }
}
