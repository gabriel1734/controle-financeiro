using controlefinanceiro.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;


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
            var serviceProvider = new ServiceCollection()
           .AddDbContext<AppDbContext>(options =>
               options.UseSqlite("Data Source=controle_financeiro.db"))
           .BuildServiceProvider();

            using (var context = serviceProvider.GetService<AppDbContext>())
            {
                context.Database.Migrate();
            }
            ApplicationConfiguration.Initialize();
            Application.Run(new frmLogin());
        }
    }
}