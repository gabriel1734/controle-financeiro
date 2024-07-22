using controlefinanceiro.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using controlefinanceiro.Controllers;
using controlefinanceiro.Views;
using System;
using ControleFinanceiro.Controllers;
using controlefinanceiro.Models;


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
            var services = new ServiceCollection();
            services.AddDbContext<AppDbContext>();
            var serviceProvider = services.BuildServiceProvider();

            using (var scope = serviceProvider.CreateScope())
            {
                var dataContext = scope.ServiceProvider.GetRequiredService<AppDbContext>();
                dataContext.Database.Migrate();
            }


            if (!UsuarioController.CountIfExist())
             {
                  Application.Run(new frmRegister());
             }
             else
             {
                 Application.Run(new frmLogin());
             }
        }
    }
}