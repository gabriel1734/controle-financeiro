using controlefinanceiro.Controllers;
using controlefinanceiro.Models;
using controlefinanceiro.Views;

namespace controlefinanceiro
{
   
        public partial class frmLogin : Form
        {
            public frmLogin()
            {
                InitializeComponent();
            }

            private void btnLogin_Click(object sender, EventArgs e)
            {
                string username = txtUsername.Text;
                string password = txtPassword.Text;

                Usuario user = UsuarioController.getUser(username, password);

                if (user != null)
                {
                    frmHome homeForm = new frmHome(user);
                    homeForm.Show();
                    this.Hide();
                }
                else
                {
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
        }
    
}
