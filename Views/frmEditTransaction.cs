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
using System.Windows.Forms;

namespace controlefinanceiro.Views
{
    public partial class frmEditTransaction : Form
    {
        public frmEditTransaction(Usuario usuario)
        {
            InitializeComponent();
            LoadTransaction();
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
    }
}
