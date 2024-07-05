// UsuarioController.cs
using controlefinanceiro.Data;
using controlefinanceiro.Helpers;
using controlefinanceiro.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Threading.Tasks;

namespace controlefinanceiro.Controllers
{
    internal class UsuarioController
    {
        
        public static bool CountIfExist()
        {
           
            using(AppDbContext db = new AppDbContext())
            {

                if (db.Usuarios.AsQueryable().Count() > 0) { 
                    return true;
                }
            }
           
            return false;
        }

        public static void storeUser(Usuario user)
        {
            user.Senha = HashHelper.GetMd5Hash(user.Senha + "pao de batata");
            using(AppDbContext db = new AppDbContext())
            {         
                db.Usuarios.Add(user);
                db.SaveChanges();
            }
        }

        public static Usuario? getUser(string username, string password)
        {
            password = HashHelper.GetMd5Hash(password + "pao de batata");
            using (AppDbContext db = new AppDbContext())
            {
                return db.Usuarios.AsQueryable()
                    .Where(u => u.Username == username && u.Senha == password)
                    .FirstOrDefault();
            }
        }

    }
}
