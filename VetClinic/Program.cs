using Microsoft.EntityFrameworkCore;
using System.Configuration;
using VetClinic.Data;
using VetClinic.Models;
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

                if (!context.Adresy.Any()) { context.Adresy.AddRange(AdresSeeder.GetSeedData(20)); }
                context.SaveChanges();
                if (!context.Osoby.Any()) { context.Osoby.AddRange(OsobaSeeder.GetSeedData(30)); }
                context.SaveChanges();
                if (!context.Lekarze.Any()) { context.Lekarze.AddRange(LekarzSeeder.GetSeedData()); }
                context.SaveChanges();
                if (!context.Zwierzeta.Any()) { context.Zwierzeta.AddRange(ZwierzeSeeder.GetSeedData(50)); }
                context.SaveChanges();
                List<Lek> leki = null;
                if (!context.Leki.Any())
                {
                    leki = LekSeeder.GetSeedData(60).ToList();
                    context.Leki.AddRange(leki);
                    context.SaveChanges();
                }
                else
                {
                    leki = context.Leki.ToList();
                }

                if (!context.Wizyty.Any())
                {
                    var wizyty = WizytaSeeder.GetSeedData(leki, 40, 20);
                    context.Wizyty.AddRange(wizyty);
                    context.SaveChanges();
                }
                if (!context.Zamowienia.Any()) { context.Zamowienia.AddRange(ZamowienieSeeder.GetSeedData(30)); }
                context.SaveChanges();
            }

            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}