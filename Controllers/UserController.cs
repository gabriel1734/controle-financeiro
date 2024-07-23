using controlefinanceiro.Data;
using controlefinanceiro.Controllers;
using controlefinanceiro.Helpers;
using controlefinanceiro.Models;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace controlefinanceiro.Controllers
{
    internal class UsuarioController
    {
        public static bool CountIfExist()
        {
            using (AppDbContext db = new AppDbContext())
            {
                return db.Usuarios.Any();
            }
        }

        public static void storeUser(string username, string password, string confirmPassword)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                throw new System.Exception("Password and Username are required!");
            }

            if (password != confirmPassword)
            {
                throw new System.Exception("Passwords do not match!");
            }

            if (!IsPasswordSecure(password))
            {
                throw new System.Exception("Password does not meet security requirements!");
            }

            Usuario user = new Usuario
            {
                Username = username,
                Senha = HashHelper.GetMd5Hash(password + "pao de batata")
            };

            using (AppDbContext db = new AppDbContext())
            {
                db.Usuarios.Add(user);
                db.SaveChanges();
            }
        }

        private static bool IsPasswordSecure(string password)
        {
            if (password.Length < 8)
                return false;
            if (!Regex.IsMatch(password, @"[A-Z]")) // Contains an uppercase letter
                return false;
            if (!Regex.IsMatch(password, @"[a-z]")) // Contains a lowercase letter
                return false;
            if (!Regex.IsMatch(password, @"\d")) // Contains a digit
                return false;
            if (!Regex.IsMatch(password, @"[\W_]")) // Contains a special character
                return false;
            return true;
        }

        public static Usuario getUser(string username, string password)
        {
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Password and Username are required!");
                return null;
            }

            password = HashHelper.GetMd5Hash(password + "pao de batata");

            using (AppDbContext db = new AppDbContext())
            {
                var user = db.Usuarios.FirstOrDefault(u => u.Username == username && u.Senha == password);

                if (user != null)
                {
                    return user;
                }
                else
                {
                    MessageBox.Show("User not found or incorrect password!");
                    return null;
                }
            }
        }
        public static void setNewPassword(string password, string confirmPassword, Usuario user)
        {
            if (string.IsNullOrEmpty(confirmPassword) || string.IsNullOrEmpty(password))
            {
                throw new System.Exception("Password and Username are required!");
            }

            if (password != confirmPassword)
            {
                throw new System.Exception("Passwords do not match!");
            }

            if (!IsPasswordSecure(password))
            {
                throw new System.Exception("Password does not meet security requirements!");
            }

            user.Senha = Helpers.HashHelper.GetMd5Hash(password + "pao de batata");
            using (AppDbContext db = new AppDbContext())
            {
                db.Usuarios.Update(user);
                db.SaveChanges();
            }
        }
    }
}
