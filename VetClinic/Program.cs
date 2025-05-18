using Microsoft.EntityFrameworkCore;
using System.Configuration;
using VetClinic.Data;
using VetClinic.Seeders;

namespace VetClinic
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var factory = new AppDbContextFactory();
            using (var context = factory.CreateDbContext(Array.Empty<String>()))
            {
                var pendingMigrations = context.Database.GetPendingMigrations();

                if (pendingMigrations.Any())
                {
                    context.Database.Migrate();
                }

                if (!context.Adresy.Any()) { context.Adresy.AddRange(AdresSeeder.GetSeedData()); }
                context.SaveChanges();
                if (!context.Osoby.Any()) { context.Osoby.AddRange(OsobaSeeder.GetSeedData()); }
                context.SaveChanges();
                if (!context.Lekarze.Any()) { context.Lekarze.AddRange(LekarzSeeder.GetSeedData()); }
                context.SaveChanges();
                if (!context.Zwierzeta.Any()) { context.Zwierzeta.AddRange(ZwierzeSeeder.GetSeedData()); }
                context.SaveChanges();
                if (!context.Wizyty.Any()) { context.Wizyty.AddRange(WizytaSeeder.GetSeedData()); }
                context.SaveChanges();
                if (!context.Leki.Any()) { context.Leki.AddRange(LekSeeder.GetSeedData()); }
                context.SaveChanges();
                if (!context.Zamowienia.Any()) { context.Zamowienia.AddRange(ZamowienieSeeder.GetSeedData()); }
                context.SaveChanges();
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}