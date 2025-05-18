using Bogus;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.Models;

namespace VetClinic.Seeders
{
    internal class WizytaSeeder
    {
        internal static IEnumerable<Wizyta> GetSeedData()
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<String>());

            var faker = new Faker();
            var Wizyty = new List<Wizyta>();
            // Specjalizacja lekarza musi zgadzać się z typem zwierzęcia
            // Tryb wizyty musi zgadzać się z trybem pracy lekarza
            // Lekarz nie może mieć dwóch wizyt w czasie krótszym niż godzina
            // Nie może być wizyt poza godzinami 10 - 18

            int i;
            for (i = 1; i < 40; i++)
            {
                int zwierzeid = faker.Random.Int(0, 40);
                string zwierzetyp = context.Zwierzeta.First(z => z.Id == zwierzeid).Typ;

                int lekarzid = context.Lekarze.First(l => l.Specjalizacja == zwierzetyp).Id;

                var day = DateTime.SpecifyKind(faker.Date.Between(DateTime.Today.Subtract(TimeSpan.FromDays(200)), DateTime.Today), DateTimeKind.Utc);

                string tryb = Constants.Tryby[1];

                if (zwierzetyp == "Zwierzeta dzikie" || zwierzetyp == "Zwierzeta gospodarskie")
                {
                    tryb = Constants.Tryby[0];
                }

                Wizyty.Add(new Wizyta()
                {
                    Id = i,
                    ZwierzeId = zwierzeid,
                    Tryb = tryb,
                    LekarzId = lekarzid,
                    Opis = faker.PickRandom(Constants.Diagnoses),
                    Data = day
                });
            }

            return Wizyty;

            }
    }
}
