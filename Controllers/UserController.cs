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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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

        public static void storeUser(string username, string password, string confirmPassword)
        {
            if (password != confirmPassword)
            {
                throw new System.Exception("Passwords do not match.!!!");
            }

            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new System.Exception("Password and Username are required!!!");
            }

            Usuario user = new Usuario();
            user.Username = username;

            user.Senha = HashHelper.GetMd5Hash(password + "pao de batata");
            using(AppDbContext db = new AppDbContext())
            {         
                db.Usuarios.Add(user);
                db.SaveChanges();
            }
        }
        public static Usuario getUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
               throw new System.Exception("Password and Username are required!!!");
            }
            password = HashHelper.GetMd5Hash(password + "pao de batata");
            using (AppDbContext db = new AppDbContext())
            {
                if(db.Usuarios.AsQueryable().Where(u => u.Username == username && u.Senha == password).Count() > 0)
                {
                    return db.Usuarios.AsQueryable().Where(u => u.Username == username && u.Senha == password).First();
                }
                else
                {
                    throw new System.Exception("User not found!!!");
                }
            }
        }

    }
}
