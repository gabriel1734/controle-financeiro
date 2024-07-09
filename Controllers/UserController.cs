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

                if (db.Usuarios.AsQueryable().Count() > 0)
                {
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

    }
}
