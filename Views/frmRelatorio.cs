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
    public partial class frmRelatorio : Form
    {
        public frmRelatorio()
        {
            InitializeComponent();
            ConfigurarDateTimePicker();
            ConfigurarCategoria();
            ConfigurarEntradaSaida();
        }
        private void ConfigurarDateTimePicker()
        {
            dataInicio.Value = DateTime.Now;
            dataInicio.Format = DateTimePickerFormat.Custom;
            dataInicio.CustomFormat = "dd/MM/yyyy";

            dataFim.Value = DateTime.Now.AddDays(1);
            dataFim.Format = DateTimePickerFormat.Custom;
            dataFim.CustomFormat = "dd/MM/yyyy";
        }

        private void ConfigurarCategoria()
        {
            List<Categoria> categorias = DashboardController.ListarCategorias();
            categorias.Insert(0, new Categoria { Id = 0, Nome = "Todas Categorias" });
            categoria.DataSource = categorias.ToList();
            categoria.DisplayMember = "Nome";
            categoria.ValueMember = "Id";
        }

        private void ConfigurarEntradaSaida()
        {
            List<string> opts = new List<string> { "Todos Tipos", "Entrada", "Saída" };
            EntradaSaida.DataSource = opts;

        }

        private void gerarRelatorio_Click(object sender, EventArgs e)
        {
            RelatorioController.ObterTransacoesPorFiltro(dataInicio.Value, dataFim.Value, (int)categoria.SelectedValue, EntradaSaida.SelectedValue?.ToString());
        }
    }
}
