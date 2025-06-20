﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using VetClinic.Data;

namespace VetClinic
{
    public static class Constants
    {
        public static readonly string[] AnimalType = new[]
        {
            "Zwierzeta domowe",
            "Zwierzeta gospodarskie",
            "Ptaki egzotyczne",
            "Gady i plazy",
            "Zwierzeta dzikie"
        };

        public static readonly string[] Tryby = new[]
        {
            "Terenowy",
            "Kliniczny"
        };

        public static readonly Dictionary<string, List<string>> AnimalSpeciesByType = new()
        {
            ["Zwierzeta domowe"] = new List<string>
        {
            "Pies", "Kot", "Chomik", "Krolik", "Swinka morska"
        },
            ["Zwierzeta gospodarskie"] = new List<string>
        {
            "Krowa", "Koza", "Owca", "Swina", "Kura", "Kon"
        },
            ["Ptaki egzotyczne"] = new List<string>
        {
            "Papuga falista", "Kanarek", "Zeberek", "Papuga nimfa", "Kakadu", "Pingwin"
        },
            ["Gady i plazy"] = new List<string>
        {
            "Zolw", "Jaszczurka", "Waz", "Kameleon", "Aksolotl", "Zaba"
        },
            ["Zwierzeta dzikie"] = new List<string>
        {
            "Lis", "Jelen", "Sarna", "Dziki kot", "Wilk", "Zubr"
        }
        };

        public static readonly List<string> Diagnoses = new List<string>
        {
            "Zapalenie ucha",
            "Nadczynność tarczycy",
            "Infekcja dróg moczowych",
            "Borelioza",
            "Zapalenie skóry",
            "Problemy z trawieniem",
            "Zapalenie stawów",
            "Choroba serca",
            "Alergia pokarmowa",
            "Pasożyty wewnętrzne",
            "Niewydolność nerek",
            "Przewlekłe zapalenie płuc",
            "Gorączka",
            "Zatrucie pokarmowe",
            "Guzy nowotworowe",
            "Problemy z wątrobą",
            "Urazy mechaniczne",
            "Zakażenie bakteryjne",
            "Zakażenie wirusowe",
            "Problemy z układem nerwowym"
        };

        public static readonly List<string> Medicines = new List<string>
        {
            "Amoksycylina",
            "Doxycyklina",
            "Metronidazol",
            "Enrofloksacyna",
            "Cefaleksyna",
            "Karboplatyna",
            "Ketoprofen",
            "Meloksikam",
            "Furosemid",
            "Prednizon",
            "Ciprofloksacyna",
            "Trimetoprim-sulfametoksazol",
            "Chlorheksydyna",
            "Alopurinol",
            "Famotydyna",
            "Omeprazol",
            "Acepromazyna",
            "Fenobarbital",
            "Diazepam",
            "Butorfanol",
            "Hydrokortyzon",
            "Loratadyna",
            "Karbamazepina",
            "Naproksen",
            "Gabapentyna",
            "Wankomycyna",
            "Gentamycyna",
            "Tylostromycyna",
            "Klonidyna",
            "Ivermektina",
            "Selekoksyb",
            "Fluniksyna",
            "Fentanyl",
            "Metoklopramid",
            "Chloramfenikol",
            "Deksametazon",
            "Klemastyna",
            "Bupiwakaina",
            "Rimadyl",
            "Enalapryl"
        };

        public static bool IsValidEmail(string email)
        {
            if (string.IsNullOrWhiteSpace(email))
                return false;

            string pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, pattern);
        }

        public static string CurrentConnectionString { get; set; } =
            "Host=localhost;Port=5432;Database=VetClinic;Username=postgres;Password=haslo";
        public static string username;
        public static string password;
        public static string name;

        public static AppDbContext CreateContext()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseNpgsql(CurrentConnectionString)
                .EnableSensitiveDataLogging()
                .Options;

            return new AppDbContext(options);
        }
    }
}
