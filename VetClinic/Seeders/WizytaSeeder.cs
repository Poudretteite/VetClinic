using Bogus;
using Microsoft.EntityFrameworkCore;
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
        internal static IEnumerable<Wizyta> GetSeedData(List<Lek> wszystkieLeki, int maxWizytPrzeszle, int maxWizytPrzyszle)
        {
            var factory = new AppDbContextFactory();
            using var context = factory.CreateDbContext(Array.Empty<string>());

            var faker = new Faker();
            var wizyty = new List<Wizyta>();
            var wszystkieZwierzeta = context.Zwierzeta.ToList();
            var wszyscyLekarze = context.Lekarze.ToList();

            var lekarzWizyty = new Dictionary<int, List<DateTime>>();
            int idCounter = 1;
            int maxAttempts = 300;

            int attempts = 0;

            Wizyta GenerateVisit(DateTime startDate, DateTime endDate, bool isFuture)
            {
                var zwierze = faker.PickRandom(wszystkieZwierzeta);
                string typ = zwierze.Typ;

                var lekarz = wszyscyLekarze.FirstOrDefault(l => l.Specjalizacja == typ);
                if (lekarz == null) return null;

                string tryb = (typ == "Zwierzeta dzikie" || typ == "Zwierzeta gospodarskie")
                    ? Constants.Tryby[0]
                    : Constants.Tryby[1];

                DateTime data;
                int safetyCounter = 0;
                do
                {
                    data = faker.Date.Between(startDate, endDate);
                    safetyCounter++;
                    if (safetyCounter > 100) return null;
                }
                while (data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday);

                int hour = faker.Random.Int(10, 17);
                data = new DateTime(data.Year, data.Month, data.Day, hour, 0, 0, DateTimeKind.Utc);

                if (!lekarzWizyty.ContainsKey(lekarz.Id))
                    lekarzWizyty[lekarz.Id] = new List<DateTime>();

                if (lekarzWizyty[lekarz.Id].Any(d => Math.Abs((d - data).TotalMinutes) < 60))
                    return null;

                var wizyta = new Wizyta
                {
                    Id = idCounter++,
                    ZwierzeId = zwierze.Id,
                    LekarzId = lekarz.Id,
                    Tryb = tryb,
                    Opis = faker.PickRandom(Constants.Diagnoses),
                    Data = data,
                    Leki = faker.PickRandom(wszystkieLeki, faker.Random.Int(1, 3)).Distinct().ToList()
                };

                return wizyta;
            }

            while (wizyty.Count < maxWizytPrzeszle && attempts < maxAttempts)
            {
                attempts++;

                var wizyta = GenerateVisit(DateTime.UtcNow.AddDays(-200), DateTime.UtcNow, false);
                if (wizyta == null)
                    continue;

                wizyty.Add(wizyta);
                lekarzWizyty[wizyta.LekarzId].Add(wizyta.Data);
            }

            attempts = 0;
            int Count2 = 0;
            while (Count2 < maxWizytPrzyszle && attempts < maxAttempts)
            {
                attempts++;

                var wizyta = GenerateVisit(DateTime.UtcNow, DateTime.UtcNow.AddDays(30), true);
                if (wizyta == null)
                    continue;

                wizyty.Add(wizyta);
                lekarzWizyty[wizyta.LekarzId].Add(wizyta.Data);
                Count2++;
            }

            return wizyty;
        }

    }

}
