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

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("[ERROR] Password and Username are required!!!");
                return;
            }

            Models.Usuario user = UsuarioController.getUser(username, password);

            if (user == null)
            {
                MessageBox.Show("[ERROR] Invalid username or password!!!");
                return;
            }

            MessageBox.Show($"Welcome {user.Username}!!!");
            this.Hide();
            //frmHome home = new frmHome(user);
        }
    }
}
