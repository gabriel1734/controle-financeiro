using controlefinanceiro.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace controlefinanceiro.Controllers
{
    internal class SaldoController
    {
        public static decimal ObterSaldo()
        {
            using (AppDbContext db = new AppDbContext())
            {
                var transacoes = db.Transacoes.ToList();
                return transacoes.Sum(t => t.Valor);
            }
        }

        public static decimal ObterSaldoPorDia(DateTime data)
        {
            using (AppDbContext db = new AppDbContext())
            {
                var transacoes = db.Transacoes.Where(t => t.Data.Date == data.Date).ToList();
                return transacoes.Sum(t => t.Valor);
            }
        }
        public static decimal ObterSaldoPeriodo(DateTime inicio, DateTime fim, int? categoriaId, string tipo)
        {
            using (AppDbContext db = new AppDbContext())
            {
                var query = db.Transacoes.Where(t => t.Data.Date >= inicio.Date && t.Data.Date <= fim.Date);

                if (categoriaId.HasValue && categoriaId.Value > 0)
                {
                    query = query.Where(t => t.CategoriaId == categoriaId.Value);
                }

  
                if (tipo == "Entrada")
                {
                    query = query.Where(t => t.Valor > 0);
                }
                else if (tipo == "Saída")
                {
                    query = query.Where(t => t.Valor < 0);
                }

                var transacoes = query.ToList();

                decimal saldo = transacoes.Sum(t => t.Valor);
                return saldo;
            }
        }
    }
}
