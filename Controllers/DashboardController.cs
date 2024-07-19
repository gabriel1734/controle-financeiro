using controlefinanceiro.Data;
using controlefinanceiro.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleFinanceiro.Controllers
{
    internal class DashboardController
    {
        public static bool ExistemTransacoesDoDia(DateTime data)
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Transacoes.Any(t => t.Data.Date == data.Date);
            }
        }

        public static List<Transacao> ObterTransacoesDoDia(DateTime data)
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Transacoes.Where(t => t.Data.Date == data.Date).ToList();
            }
        }

        public static decimal CalcularTotalTransacoesDoDia(DateTime data)
        {
            var transacoes = ObterTransacoesDoDia(data);
            return transacoes.Sum(t => t.Valor);
        }

        public static decimal ObterSaldoInicial(int usuarioId)
        {
            using (AppDbContext db = new AppDbContext())
            {
                var saldo = db.Saldos.FirstOrDefault(s => s.UsuarioId == usuarioId);
                return saldo != null ? saldo.ValorSaldo : 0;
            }
        }

        public static decimal ObterSaldoDoDia(int usuarioId, DateTime data)
        {
            decimal saldoInicial = ObterSaldoInicial(usuarioId);
            var transacoes = ObterTransacoesDoDia(data);
            decimal saldoDoDia = saldoInicial + transacoes.Sum(t => t.Valor);
            return saldoDoDia;
        }

        public static decimal ObterValorAtualDisponivel(int usuarioId)
        {
            decimal saldoInicial = ObterSaldoInicial(usuarioId);
            using (AppDbContext db = new AppDbContext())
            {
                var totalTransacoes = db.Transacoes.Where(t => t.UsuarioId == usuarioId).Sum(t => t.Valor);
                return saldoInicial + totalTransacoes;
            }
        }

        public static void AdicionarCategoria(string nome)
        {
            using (AppDbContext db = new AppDbContext())
            {
                var categoria = new Categoria
                {
                    Nome = nome
                };

                db.Categorias.Add(categoria);
                db.SaveChanges();
            }
        }

        public static List<Categoria> ListarCategorias()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Categorias.ToList();
            }
        }

        public static bool RemoverCategoria(int id)
        {
            using (AppDbContext db = new AppDbContext())
            {
                bool existemTransacoes = db.Transacoes.Any(t => t.CategoriaId == id);
                if (existemTransacoes)
                {
                    throw new System.Exception("There is a transaction with this category");
                }

                var categoria = db.Categorias.Find(id);
                if (categoria != null)
                {
                    db.Categorias.Remove(categoria);
                    db.SaveChanges();
                    return true; // Categoria removida com sucesso
                }
                throw new System.Exception("Category not found!");
            }
        }
    }
}
