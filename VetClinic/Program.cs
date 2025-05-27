using Microsoft.EntityFrameworkCore;
using VetClinic.Data;

namespace VetClinic
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var factory = new AppDbContextFactory();
            using (var context = factory.CreateDbContext(Array.Empty<string>()))
            {
                DbSeeder.SeedDatabase(context);
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}
