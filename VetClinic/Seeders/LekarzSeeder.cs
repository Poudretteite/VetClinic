using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VetClinic.Models;

namespace VetClinic.Seeders
{
    internal static class LekarzSeeder
    {

        internal static IEnumerable<Lekarz> GetSeedData() => new List<Lekarz>
        {
        new Lekarz { Id = 1, Imie = "Anna", Nazwisko = "Kowalska", Email = "anna@vet.pl", Telefon = "123123123", Data_ur = DateTime.SpecifyKind(new DateTime(1980, 5, 10), DateTimeKind.Utc), Specjalizacja = Constants.AnimalType[0], Tryb = Constants.Tryby[1] },
        new Lekarz { Id = 3, Imie = "Jan", Nazwisko = "Nowak", Email = "jan@vet.pl", Telefon = "321321321", Data_ur = DateTime.SpecifyKind(new DateTime(1975, 3, 20), DateTimeKind.Utc), Specjalizacja = Constants.AnimalType[1], Tryb = Constants.Tryby[0] },
        new Lekarz { Id = 6, Specjalizacja = Constants.AnimalType[2], Tryb = Constants.Tryby[1], Imie = "Ewa", Nazwisko = "Malinowska", Email = "ewa@vet.pl", Telefon = "456456456", Data_ur = DateTime.SpecifyKind(new DateTime(1982, 1, 15), DateTimeKind.Utc)},
        new Lekarz { Id = 9, Specjalizacja = Constants.AnimalType[3], Tryb = Constants.Tryby[1], Imie = "Piotr", Nazwisko = "Zielinski", Email = "piotr@vet.pl", Telefon = "654654654", Data_ur = DateTime.SpecifyKind(new DateTime(1990, 7, 22), DateTimeKind.Utc)},
        new Lekarz { Id = 12, Specjalizacja = Constants.AnimalType[4], Tryb = Constants.Tryby[0], Imie = "Marta", Nazwisko = "Dabrowska", Email = "marta@vet.pl", Telefon = "789789789", Data_ur = DateTime.SpecifyKind(new DateTime(1985, 11, 5), DateTimeKind.Utc)}
    };
    }
}
