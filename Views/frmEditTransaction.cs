using controlefinanceiro.Models;
using ControleFinanceiro.Controllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.Windows.Forms;

namespace controlefinanceiro.Views
{
    public partial class frmEditTransaction : Form
    {
        private Usuario user;
        public frmEditTransaction(Usuario usuario)
        {
            InitializeComponent();
            LoadTransaction();
            this.user = usuario;
        }

        private void frmEditTransaction_Load(object sender, EventArgs e)
        {

        }

        private void LoadTransaction()
        {
            List<Transacao> transacoes = DashboardController.ListarTransacoes();
            mainDataTransactions.Rows.Clear();
            mainDataTransactions.Columns.Clear();
            mainDataTransactions.Columns.Add("Id", "Id");
            mainDataTransactions.Columns.Add("Data", "Data");
            mainDataTransactions.Columns.Add("Categoria", "Categoria");
            mainDataTransactions.Columns.Add("Valor", "Valor");
            mainDataTransactions.Columns.Add("Tipo", "Tipo");
            mainDataTransactions.Columns.Add("Descrição", "Descrição");

            foreach (var item in transacoes)
            {
                mainDataTransactions.Rows.Add(
                    item.Id,
                    item.Data,
                    item.Categoria.Nome,
                    item.Valor,
                    item.Tipo,
                    item.Descricao
                    );
            }
        }

        private void mainDataTransactions_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.mainDataTransactions.Rows[e.RowIndex];
                Transacao tr = new Transacao
                {
                    Id = Convert.ToInt32(row.Cells["Id"].Value),
                    Data = Convert.ToDateTime(row.Cells["Data"].Value),
                    Categoria = new Categoria { Nome = row.Cells["Categoria"].Value.ToString() },
                    Valor = Convert.ToDecimal(row.Cells["Valor"].Value),
                    Tipo = row.Cells["Tipo"].Value.ToString(),
                    Descricao = row.Cells["Descrição"].Value.ToString()
                };
                
                using (Views.frmAddTransaction editTransaction = new frmAddTransaction(user, tr))
                {
                    editTransaction.ShowDialog();
                    LoadTransaction();
                }
            }
        }

        private void serchBtn_Click(object sender, EventArgs e)
        {
            List<Transacao> transacoes = DashboardController.ObterTransacoesDoDia(dateFilter.Value);
            mainDataTransactions.Rows.Clear();
            mainDataTransactions.Columns.Clear();
            mainDataTransactions.Columns.Add("Id", "Id");
            mainDataTransactions.Columns.Add("Data", "Data");
            mainDataTransactions.Columns.Add("Categoria", "Categoria");
            mainDataTransactions.Columns.Add("Valor", "Valor");
            mainDataTransactions.Columns.Add("Tipo", "Tipo");
            mainDataTransactions.Columns.Add("Descrição", "Descrição");

            if(transacoes.Count == 0)
            {
                MessageBox.Show("No transactions found for this date");
                return;
            }

            foreach (var item in transacoes)
            {
                mainDataTransactions.Rows.Add(
                    item.Id,
                    item.Data,
                    item.Categoria.Nome,
                    item.Valor,
                    item.Tipo,
                    item.Descricao
                    );
            }
        }
    }
}
