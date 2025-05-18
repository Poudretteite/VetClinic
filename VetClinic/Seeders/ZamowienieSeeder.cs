using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.Models;

namespace VetClinic.Seeders
{
    internal class ZamowienieSeeder
    {
        internal static IEnumerable<Zamowienie> GetSeedData()
        {
            var faker = new Faker();
            var Zamowienia = new List<Zamowienie>();

            for (int i = 1; i <= 20; i++)
            {
                Zamowienia.Add(new Zamowienie
                {
                    Id = i,
                    LekId = faker.Random.Int(1, 40),
                    Ilosc = faker.Random.Int(20, 80)
                });
            }

            return Zamowienia;
        }
    }
}
