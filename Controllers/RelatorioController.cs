using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using controlefinanceiro.Models;
using controlefinanceiro.Data;
using OfficeOpenXml.Core.ExcelPackage;

namespace ControleFinanceiro.Controllers
{
    public class RelatorioController
    {
        public static List<Transacao> ObterTransacoesPorFiltro(DateTime dataInicio, DateTime dataFim, int? categoria, string? tipo)
        {
            using (AppDbContext db = new AppDbContext())
            {
                var query = db.Transacoes.AsQueryable();

                if (dataInicio != DateTime.MinValue)
                {
                    query = query.Where(t => t.Data.Date >= dataInicio.Date);
                }

                if (dataFim != DateTime.MinValue)
                {
                    query = query.Where(t => t.Data.Date <= dataFim.Date);
                }

                if (categoria != 0)
                {
                    query = query.Where(t => t.Categoria.Id == categoria);
                }

                if (tipo != "Todos Tipos")
                {
                    query = query.Where(t => t.Tipo == tipo);
                }

                return query.ToList();
            }
        }

        public static decimal CalcularSaldoPeriodo(DateTime dataInicio, DateTime dataFim, int? categoria, string tipo)
        {
            var transacoes = ObterTransacoesPorFiltro(dataInicio, dataFim, categoria, tipo);
            return transacoes.Sum(t => t.Valor);
        }

        public static List<CategoriaTransacoes> ObterTransacoesAgrupadasPorCategoria(DateTime dataInicio, DateTime dataFim, int? categoria, string tipo)
        {
            var transacoes = ObterTransacoesPorFiltro(dataInicio, dataFim, categoria, tipo);

            var agrupadoPorCategoria = transacoes
                .GroupBy(t => t.Categoria.Nome)
                .Select(g => new CategoriaTransacoes
                {
                    Categoria = g.Key,
                    Total = g.Sum(t => t.Valor),
                    Transacoes = g.ToList()
                })
                .ToList();

            return agrupadoPorCategoria;
        }

        public static void ExportarParaExcel(List<Transacao> transacoes, string caminhoArquivo)
        {
            using (var memoryStream = new MemoryStream())
            {
                using (var package = new OfficeOpenXml.ExcelPackage(memoryStream))
                {
                    var worksheet = package.Workbook.Worksheets.Add("Transacoes");

                    worksheet.Cells[1, 1].Value = "Id";
                    worksheet.Cells[1, 2].Value = "Data";
                    worksheet.Cells[1, 3].Value = "Categoria";
                    worksheet.Cells[1, 4].Value = "Descrição";
                    worksheet.Cells[1, 5].Value = "Tipo";
                    worksheet.Cells[1, 6].Value = "Valor";

                    int row = 2;
                    foreach (var transacao in transacoes)
                    {
                        worksheet.Cells[row, 1].Value = transacao.Id;
                        worksheet.Cells[row, 2].Value = transacao.Data.ToString("dd/MM/yyyy");
                        worksheet.Cells[row, 3].Value = transacao.Categoria.Nome;
                        worksheet.Cells[row, 4].Value = transacao.Descricao;
                        worksheet.Cells[row, 5].Value = transacao.Tipo;
                        worksheet.Cells[row, 6].Value = transacao.Valor;
                        row++;
                    }

                    package.Save();
                }

                File.WriteAllBytes(caminhoArquivo, memoryStream.ToArray());
            }
        }
    }

    public class CategoriaTransacoes
    {
        public string Categoria { get; set; }
        public decimal Total { get; set; }
        public List<Transacao> Transacoes { get; set; }
    }
}
