using Microsoft.EntityFrameworkCore;
using VetClinic.Data;
using VetClinic.Seeders;
using VetClinic.Models;

namespace VetClinic
{
    public static class DbSeeder
    {
        public static void SeedDatabase(AppDbContext context)
        {
            var pendingMigrations = context.Database.GetPendingMigrations();
            if (pendingMigrations.Any())
            {
                context.Database.Migrate();
            }
            context.SaveChanges();

            if (!context.Osoby.Any())
            {
                context.Osoby.AddRange(OsobaSeeder.GetSeedData(30));
            }
            context.SaveChanges();

            if (!context.Lekarze.Any())
            {
                context.Lekarze.AddRange(LekarzSeeder.GetSeedData());
            }
            context.SaveChanges();

            if (!context.Zwierzeta.Any())
            {
                context.Zwierzeta.AddRange(ZwierzeSeeder.GetSeedData(50));
            }
            context.SaveChanges();

            List<Lek> leki;
            if (!context.Leki.Any())
            {
                leki = LekSeeder.GetSeedData().ToList();
                context.Leki.AddRange(leki);
            }
            else
            {
                leki = context.Leki.ToList();
            }
            context.SaveChanges();

            if (!context.Wizyty.Any())
            {
                var wizyty = WizytaSeeder.GetSeedData(leki, 40, 20);
                context.Wizyty.AddRange(wizyty);
            }
            context.SaveChanges();

            if (!context.Zamowienia.Any())
            {
                context.Zamowienia.AddRange(ZamowienieSeeder.GetSeedData(30));
            }
            context.SaveChanges();
        }
    }
}
