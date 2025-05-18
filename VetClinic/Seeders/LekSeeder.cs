using Bogus;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.Models;

namespace VetClinic.Seeders
{
    internal class LekSeeder
    {
        internal static IEnumerable<Lek> GetSeedData()
        {
            var faker = new Faker();
            var Leki = new List<Lek>();

            for (int i = 1; i <= 40; i++)
            {
                Leki.Add(new Lek
                {
                    Id = i,
                    Nazwa = Constants.Medicines[i-1],
                    Ilosc = faker.Random.Int(1, 100),
                });
            }

            return Leki;
        }
    }
}
