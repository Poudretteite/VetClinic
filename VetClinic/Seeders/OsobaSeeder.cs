﻿using Bogus;
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
        internal static IEnumerable<Osoba> GetSeedData(int liczbaRekordow)
        {
            var faker = new Faker();
            var osoby = new List<Osoba>();
            var maxDate = new DateTime(2007, 12, 31);
            var minDate = new DateTime(1900, 1, 1);
            int[] lekarzIds = { 1, 3, 6, 9, 12 };

            for (int i = 1; i <= liczbaRekordow; i++)
            {
                if (lekarzIds.Contains(i)) continue;

                osoby.Add(new Osoba
                {
                    Id = i,
                    Imie = faker.Name.FirstName(),
                    Nazwisko = faker.Name.LastName(),
                    Email = faker.Internet.Email(),
                    Data_ur = faker.Date.Between(minDate, maxDate).ToUniversalTime(),
                    Telefon = faker.Phone.PhoneNumber("#########")
                });
            }

            osoby.Add(new Osoba
            {
                Id = -1,
                Imie = "Centrum",
                Nazwisko = "Opieki Zwierzat",
                Email = "carecenter@vetclinic.local",
                Data_ur = DateTime.UtcNow,
                Telefon = "123456789"
            });

            return osoby;
        }
    }
}
