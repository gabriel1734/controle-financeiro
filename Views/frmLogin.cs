using controlefinanceiro.Controllers;

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

            Models.Usuario user = UsuarioController.getUser(username, password);

            MessageBox.Show($"Welcome {user.Username}!!!");
            this.Hide();
            Views.frmHome home = new Views.frmHome(user);
            home.Show();
        }
    }
}
