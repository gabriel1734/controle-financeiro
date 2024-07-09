using controlefinanceiro.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using controlefinanceiro.Controllers;
using controlefinanceiro.Views;


namespace controlefinanceiro
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.

            if (!.CountIfExist())
            {
                Application.Run(new frmRegister());
            }
            else
            {
                Application.Run(new frmLogin());
            }
            
            ApplicationConfiguration.Initialize();
            

            

        }
    }
}