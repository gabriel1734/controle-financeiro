using controlefinanceiro.Data;
using controlefinanceiro.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleFinanceiro.Controllers
{
    public class DashboardController
    {
        private readonly AppDbContext _context;

        public DashboardController()
        {
            _context = new AppDbContext();
        }

        public DateTime GetCurrentDate()
        {
            return DateTime.Now;
        }

        public List<Transacao> GetMovimentacoesDoDia(DateTime date)
        {
            return _context.Transacoes.Where(m => m.Data.Date == date.Date).ToList();
        }

        public decimal GetTotalMovimentacoesDoDia(DateTime date)
        {
            var movimentacoes = GetMovimentacoesDoDia(date);
            return movimentacoes.Sum(m => m.Valor);
        }

        public decimal GetSaldoInicial(int usuarioId)
        {
            var saldo = _context.Saldos.FirstOrDefault(s => s.UsuarioId == usuarioId);
            return saldo != null ? saldo.ValorSaldo : 0;
        }

        public decimal GetSaldoDoDia(int usuarioId, DateTime date)
        {
            decimal saldoInicial = GetSaldoInicial(usuarioId);
            var movimentacoes = GetMovimentacoesDoDia(date);
            decimal saldoDoDia = saldoInicial + movimentacoes.Sum(m => m.Valor);
            return saldoDoDia;
        }

        public decimal GetValorAtualDisponivel(int usuarioId)
        {
            var saldoInicial = GetSaldoInicial(usuarioId);
            var totalMovimentacoes = _context.Transacoes.Where(t => t.UsuarioId == usuarioId).Sum(t => t.Valor);
            return saldoInicial + totalMovimentacoes;
        }
    }
}
