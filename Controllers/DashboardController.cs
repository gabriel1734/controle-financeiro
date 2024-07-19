using controlefinanceiro.Data;
using controlefinanceiro.Models;
using Microsoft.EntityFrameworkCore;
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
                return db.Transacoes
                    .Include(t => t.Categoria)
                    .Where(t => t.Data.Date == data.Date)
                    .ToList();
            }
        }

        public static List<Transacao> ListarTransacoes()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Transacoes
                    .Include(t => t.Categoria)
                    .ToList();
            }
        }

        public static void AdicionarCategoria(string nome)
        {
            using (AppDbContext db = new AppDbContext())
            {
                var categoria = new Categoria
                {
                    Nome = nome,
                    status = true
                };

                if(db.Categorias.Any(c => c.Nome == nome && c.status == true))
                {
                    throw new System.Exception("Category already exists!");
                }

                db.Categorias.Add(categoria);
                db.SaveChanges();
            }
        }

        public static List<Categoria> ListarCategorias()
        {
            using (AppDbContext db = new AppDbContext())
            {
               return db.Categorias.Where(c => c.status != false).ToList();
            }
        }
        public static void AdicionarTransacao(int usuarioId, int categoriaId, decimal valor, DateTime data, string descricao, string tipo)
        {
            if(valor <= 0)
            {
                throw new System.Exception("Value must be greater than zero!");
            }
            
            if(data > DateTime.Now)
            {
                throw new System.Exception("Date cannot be greater than today!");
            }

            if (tipo != "Entrada" && tipo != "Saída")
            {
                throw new System.Exception("Invalid transaction type!");
            }


            using (AppDbContext db = new AppDbContext())
            {
                

                if (!db.Categorias.Any(c => c.Id == categoriaId))
                {
                    throw new System.Exception("Category not found!");
                }

                if(tipo == "Saída")
                {
                    valor = valor * -1;
                }

                Transacao novaTransacao = new Transacao
                {
                    UsuarioId = usuarioId,
                    CategoriaId = categoriaId,
                    Valor = valor,
                    Data = data,
                    Descricao = descricao,
                    Tipo = tipo
                };

                db.Transacoes.Add(novaTransacao);
                db.SaveChanges();
            }
        }

        public static bool RemoverCategoria(int id)
        {
            using (AppDbContext db = new AppDbContext())
            {
                var categoria = db.Categorias.Find(id);
                if (categoria != null)
                {
                    categoria.status = false;
                    db.Categorias.Update(categoria);
                    db.SaveChanges();
                    return true; 
                }
                throw new System.Exception("Category not found!");
            }
        }

        public static void EditarCategoria(string nome, int id)
        {
            if(string.IsNullOrEmpty(nome))
            {
                throw new System.Exception("Category name cannot be empty!");
            }
            using (AppDbContext db = new AppDbContext())
            {
                Categoria categoria = db.Categorias.Find(id);
                Console.WriteLine(categoria);
                if (categoria != null)
                {
                    categoria.Nome = nome;
                    db.Categorias.Update(categoria);
                    db.SaveChanges();
                } else
                {
                    throw new System.Exception("Category not found!");
                }
            }
        }
    }
}
