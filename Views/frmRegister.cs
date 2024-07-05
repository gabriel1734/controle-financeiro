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

            if(password != confirmPassword)
            {
                MessageBox.Show("[ERROR] Passwords do not match.!!!");
                return;
            }
            
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("[ERROR] Username and password are required.!!!");
                return;
            }

            Models.Usuario user = new Models.Usuario();

            user.Username = username;
            user.Senha = password;
            
            Controllers.UsuarioController.storeUser(user);
            MessageBox.Show("User registered successfully.!!!");
            this.Hide();
            //frmHome home = new frmHome(user);
        }
    }
}
