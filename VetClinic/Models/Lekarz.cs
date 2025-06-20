﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetClinic.Models
{
    [Table("lekarze")]
    public class Lekarz : Osoba
    {
        [Required]
        [StringLength(50)]
        public string Specjalizacja { get; set; }

        [Required]
        [StringLength(50)]
        public string Tryb {  get; set; }

        public override string ToString()
        {
            return $"{Id}. {Imie} {Nazwisko} - Lekarz: {Specjalizacja}";
        }
    }
}
