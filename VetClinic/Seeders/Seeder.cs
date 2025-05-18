using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.Data;
using VetClinic.Models;

namespace VetClinic.Seeders
{
    internal static class Seeder
    {
        public static void SeedDatabase(AppDbContext context)
        {
            if (!context.Adresy.Any()) { context.Adresy.AddRange(AdresSeeder.GetSeedData()); }
            if (!context.Osoby.Any()) { context.Osoby.AddRange(OsobaSeeder.GetSeedData()); }
            if (!context.Lekarze.Any()) { context.Lekarze.AddRange(LekarzSeeder.GetSeedData()); }
            if (!context.Zwierzeta.Any()) { context.Zwierzeta.AddRange(ZwierzeSeeder.GetSeedData()); }
            if (!context.Wizyty.Any()) { context.Wizyty.AddRange(WizytaSeeder.GetSeedData()); }
            if (!context.Leki.Any()) { context.Leki.AddRange(LekSeeder.GetSeedData()); }
            if (!context.Zamowienia.Any()) { context.Zamowienia.AddRange(ZamowienieSeeder.GetSeedData()); }

            context.SaveChanges();
        }
    }
}
