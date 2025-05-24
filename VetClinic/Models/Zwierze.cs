using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel;

namespace VetClinic.Models
{
    [Table("zwierzeta")]
    internal class Zwierze
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50), Display(Name = "Imię")]
        public string Imie {  get; set; }

        [Required]
        [StringLength(50)]
        public string Gatunek { get; set; }

        [Required]
        [StringLength(50)]
        public string Typ { get; set; }

        [Required]
        public int Wiek { get; set; }

        [Required]
        public int WlascicielId { get; set; }

        [ForeignKey("WlascicielId")]
        public Osoba Wlasciciel {  get; set; }

        public override string ToString()
        {
            return $"{Id}. {Imie} - {Gatunek}";
        }
    }
}
