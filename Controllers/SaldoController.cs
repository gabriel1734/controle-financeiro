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
    }
}
