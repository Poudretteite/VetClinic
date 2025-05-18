using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using VetClinic.Models;

namespace VetClinic.Seeders
{
    internal static class OsobaSeeder
    {
        internal static IEnumerable<Osoba> GetSeedData()
        {
            var faker = new Faker();
            var osoby = new List<Osoba>();
            int[] lekarzIds = { 1, 3, 6, 9, 12 };

            for (int i = 1; i <= 30; i++)
            {
                if (lekarzIds.Contains(i)) continue;

                osoby.Add(new Osoba
                {
                    Id = i,
                    Imie = faker.Name.FirstName(),
                    Nazwisko = faker.Name.LastName(),
                    Email = faker.Internet.Email(),
                    Data_ur = faker.Date.Past(50, DateTime.Today.AddYears(-20)).ToUniversalTime(),
                    Telefon = faker.Phone.PhoneNumber("#########"),
                    AdresId = faker.Random.Int(1, 20)
                });
            }

            osoby.Add(new Osoba
            {
                Id = -1,
                Imie = "Centrum",
                Nazwisko = "Opieki Zwierzat",
                Email = "carecenter@vetclinic.local",
                Data_ur = DateTime.UtcNow,
                Telefon = "123456789",
                AdresId = -1
            });

            return osoby;
        }
    }
}
