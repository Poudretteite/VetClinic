﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetClinic.Models
{
    [Table("osoby")]
    public class Osoba
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50), Display(Name = "Imię")]
        public string Imie { get; set; }

        [Required]
        [StringLength(50)]
        public string Nazwisko { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Data_ur {  get; set; } = DateTime.Now;

        [Required]
        [Phone]
        public string Telefon { get; set; }

        public override string ToString()
        {
            return $"{Id}. {Imie} {Nazwisko}";
        }

    }
}
