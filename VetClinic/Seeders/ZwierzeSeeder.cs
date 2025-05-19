using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.Models;

namespace VetClinic.Seeders
{
    internal class ZwierzeSeeder
    {
        internal static IEnumerable<Zwierze> GetSeedData(int liczbaRekordow)
        {
            var faker = new Faker();
            var Zwierzeta = new List<Zwierze>();

            for (var i = 1; i <= liczbaRekordow; i++)
            {
                string typ = faker.PickRandom(Constants.AnimalType);
                string gatunek = faker.PickRandom(Constants.AnimalSpeciesByType[typ]);

                Zwierzeta.Add(new Zwierze()
                {
                    Id = i,
                    Imie = faker.Name.FirstName(),
                    Gatunek = gatunek,
                    Typ = typ,
                    Wiek = faker.Random.Int(0,20),
                    WlascicielId = typ == Constants.AnimalType[4] ? -1 : faker.Random.Int(1, 30)
                });
            }

            return Zwierzeta;
        }
    }
}
