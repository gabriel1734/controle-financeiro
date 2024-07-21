using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControleFinanceiro.Controllers
{
    public static class LogoutController
    {
        public static void Logout()
        {
            var confirmResult = MessageBox.Show("Tem certeza de que deseja sair?",
                                     "Confirmação de Logout",
                                     MessageBoxButtons.YesNo,
                                     MessageBoxIcon.Question);

            if (confirmResult == DialogResult.Yes)
            {  
                Application.Exit();
            }
            // Caso clique em "Não", nada acontece e o usuário permanece na tela atual.
        }
    }
}