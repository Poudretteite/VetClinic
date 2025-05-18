using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.Models;
using Bogus;

namespace VetClinic.Seeders
{
    internal static class AdresSeeder
    {
        internal static IEnumerable<Adres> GetSeedData()
        {
            var faker = new Faker();
            var Adresy = new List<Adres>();

            for (int i = 1; i <= 20; i++)
            {
                Adresy.Add(new Adres
                {
                    Id = i,
                    Miasto = faker.Address.City(),
                    Ulica = faker.Address.StreetName(),
                    Nr_ulicy = faker.Random.Int(1, 200),
                    Nr_lokalu = faker.Random.Bool(0.7f) ? faker.Random.Int(1, 100) : null
                });
            }

            Adresy.Add(new Adres
            {
                Id = -1,
                Miasto = "Warszawa",
                Ulica = "Opiekuncza",
                Nr_ulicy = 99,
                Nr_lokalu = null
            });

            return Adresy;
        }
    }
}
