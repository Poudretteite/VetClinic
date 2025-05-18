using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetClinic.Models
{
    [Table("lekarze")]
    internal class Lekarz : Osoba
    {
        [Required]
        [StringLength(50)]
        public string Specjalizacja { get; set; }

        [Required]
        [StringLength(50)]
        public string Tryb {  get; set; }
    }
}
