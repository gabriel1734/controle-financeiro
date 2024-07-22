using controlefinanceiro.Models;
using ControleFinanceiro.Controllers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using OfficeOpenXml;
using System.Collections.Generic;
using System.IO;
using EpplusExcel = OfficeOpenXml.ExcelPackage;
using controlefinanceiro.Controllers;
using Microsoft.VisualBasic.ApplicationServices;

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
            DateTime inicio = dataInicio.Value;
            DateTime fim = dataFim.Value;
            int categoriaId = (int)categoria.SelectedValue;
            string tipo = EntradaSaida.SelectedValue?.ToString();

            List<Transacao> transacoes = RelatorioController.ObterTransacoesPorFiltro(inicio, fim, categoriaId, tipo);

            dataExcel.Columns.Clear();
            dataExcel.Rows.Clear();

            
            dataExcel.Columns.Add("Categoria", "Categoria");
            dataExcel.Columns.Add("Valor", "Valor");
            dataExcel.Columns.Add("Data", "Data");
            dataExcel.Columns.Add("Descricao", "Descrição");
            dataExcel.Columns.Add("Tipo", "Tipo");

            foreach (var transacao in transacoes)
            {
                dataExcel.Rows.Add(
                    transacao.Categoria.Nome,
                    transacao.Valor,
                    transacao.Data.ToString("dd/MM/yyyy"),
                    transacao.Descricao,
                    transacao.Tipo
                );
            }

            // Atualiza o saldo do período
            AtualizarSaldoPeriodo(inicio, fim, categoriaId,tipo);
        }

        private void AtualizarSaldoPeriodo(DateTime inicio, DateTime fim, int? categoriaId,string tipo)
        {
            decimal saldo = SaldoController.ObterSaldoPeriodo(inicio, fim, categoriaId,tipo);
            
            DayBalance.Text = saldo.ToString("N2");
        }

        private void exportarExcel_Click(object sender, EventArgs e)
        {
            var transacoes = new List<Transacao>();

            foreach (DataGridViewRow row in dataExcel.Rows)
            {
                if (row.Cells["Categoria"].Value != null)
                {
                    var transacao = new Transacao
                    {
                        Categoria = new Categoria { Nome = row.Cells["Categoria"].Value.ToString() },
                        Valor = Convert.ToDecimal(row.Cells["Valor"].Value),
                        Data = Convert.ToDateTime(row.Cells["Data"].Value),
                        Descricao = row.Cells["Descricao"].Value.ToString(),
                        Tipo = row.Cells["Tipo"].Value.ToString(),
                    };

                    transacoes.Add(transacao);
                }
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "Excel files (*.xlsx)|*.xlsx";
                saveFileDialog.Title = "Salvar Relatório como Excel";
                saveFileDialog.FileName = "relatorio.xlsx";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string caminhoArquivo = saveFileDialog.FileName;
                    RelatorioController.ExportarParaExcel(transacoes, caminhoArquivo);
                    MessageBox.Show("Relatório exportado com sucesso para " + caminhoArquivo, "Exportação Concluída", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void categoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Lógica para manipular o evento de mudança de índice selecionado
            // Você pode deixar vazio se não precisar fazer nada nesse evento
        }

        private void DayBalance_TextChanged(object sender, EventArgs e)
        {
            // Se você precisar de alguma lógica quando o texto for alterado, adicione aqui
        }

    }
}
