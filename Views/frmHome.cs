using controlefinanceiro.Controllers;
using controlefinanceiro.Models;
using ControleFinanceiro.Controllers;
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
        private Usuario user;
        public frmHome(Models.Usuario user)
        {
            InitializeComponent();
            loadHome(DateTime.Now);
            this.user = user;
            lblUser.Text = user.Username;
            sidebarContainer.Width = 0;
            profileContainer.Width = 30;
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

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            sidebarContainer.BringToFront();
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
            using (Views.frmAddTransaction addTransaction = new Views.frmAddTransaction(user))
            {
                addTransaction.ShowDialog();
                loadHome(DateTime.Now);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Views.frmEditTransaction editTransaction = new Views.frmEditTransaction(user);
            editTransaction.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Views.frmCategories categories = new Views.frmCategories();
            categories.Show();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Views.frmRelatorio relatorio = new Views.frmRelatorio();
            relatorio.Show();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {

        }

        private void loadHome(DateTime date)
        {
            List<Transacao> transacoes = DashboardController.ObterTransacoesDoDia(date);

            TotalBalance.Text = SaldoController.ObterSaldo().ToString();
            DayBalance.Text = SaldoController.ObterSaldoPorDia(date).ToString();

            mainTransactions.Rows.Clear();
            mainTransactions.Columns.Clear();

            mainTransactions.Columns.Add("Id", "Id");
            mainTransactions.Columns.Add("Categoria", "Categoria");
            mainTransactions.Columns.Add("Valor", "Valor");
            mainTransactions.Columns.Add("Data", "Data");
            mainTransactions.Columns.Add("Descrição", "Descrição");
            mainTransactions.Columns.Add("Tipo", "Tipo");

            foreach (var transacao in transacoes)
            {
                mainTransactions.Rows.Add(
                    transacao.Id,
                    transacao.Categoria.Nome,
                    transacao.Valor.ToString("C"),
                    transacao.Data.ToString("dd/MM/yyyy"),
                    transacao.Descricao,
                    transacao.Tipo
                );
            }
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            loadHome(dateTransaction.Value);
        }
        private void logout_Click(object sender, EventArgs e)
        {
            LogoutController.Logout();
        }

        private void TotalBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void mainTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DayBalance_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
            profileTransition.Start();
        }

        bool profileExpand = false;
        private void profileTransition_Tick(object sender, EventArgs e)
        {
            profileContainer.BringToFront();
            if (profileExpand == false)
            {
                profileContainer.Width += 10;
                if (profileContainer.Width >= 180)
                {
                    profileTransition.Stop();

                    profileExpand = true;
                }
            }
            else
            {
                profileContainer.Width -= 10;
                if (profileContainer.Width <= 30)
                {
                    profileTransition.Stop();
                    profileExpand = false;
                }
            }
        }

        private void btnResetPassword_Click(object sender, EventArgs e)
        {
            Views.frmResetPassword resetPass = new Views.frmResetPassword(user);
            resetPass.Show();
        }

        private void lblUser_Click(object sender, EventArgs e)
        {

        }
    }
}
