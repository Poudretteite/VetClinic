using Bogus;
using VetClinic.Models;
using VetClinic;

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

        var lekarzWizyty = new Dictionary<int, Dictionary<DateTime, int>>();
        int idCounter = 1;
        int maxAttempts = 200;

        int attempts = 0;

        Wizyta GenerateVisit(DateTime startDate, DateTime endDate)
        {
            var zwierze = faker.PickRandom(wszystkieZwierzeta);
            string typ = zwierze.Typ;

            var lekarz = wszyscyLekarze.FirstOrDefault(l => l.Specjalizacja == typ);
            if (lekarz == null) return null;

            DateTime data;
            int safetyCounter = 0;
            do
            {
                data = faker.Date.Between(startDate, endDate).Date;
                safetyCounter++;
                if (safetyCounter > 100) return null;
            }
            while (data.DayOfWeek == DayOfWeek.Saturday || data.DayOfWeek == DayOfWeek.Sunday);

            if (!lekarzWizyty.ContainsKey(lekarz.Id))
                lekarzWizyty[lekarz.Id] = new Dictionary<DateTime, int>();

            if (lekarzWizyty[lekarz.Id].TryGetValue(data, out int dailyCount) && dailyCount >= 5)
                return null;

            if (!lekarzWizyty[lekarz.Id].ContainsKey(data))
                lekarzWizyty[lekarz.Id][data] = 0;

            lekarzWizyty[lekarz.Id][data]++;

            var wizyta = new Wizyta
            {
                Id = idCounter++,
                ZwierzeId = zwierze.Id,
                LekarzId = lekarz.Id,
                Opis = faker.PickRandom(Constants.Diagnoses),
                Data = data,
                Leki = faker.PickRandom(wszystkieLeki, faker.Random.Int(1, 3)).Distinct().ToList()
            };

            return wizyta;
        }

        while (wizyty.Count < maxWizytPrzeszle && attempts < maxAttempts)
        {
            attempts++;

            var wizyta = GenerateVisit(DateTime.UtcNow.AddDays(-200), DateTime.UtcNow);
            if (wizyta == null)
                continue;

            wizyty.Add(wizyta);
        }

        attempts = 0;
        int futureCount = 0;
        while (futureCount < maxWizytPrzyszle && attempts < maxAttempts)
        {
            attempts++;

            var wizyta = GenerateVisit(DateTime.UtcNow, DateTime.UtcNow.AddDays(30));
            if (wizyta == null)
                continue;

            wizyty.Add(wizyta);
            futureCount++;
        }

        return wizyty;
    }
}
