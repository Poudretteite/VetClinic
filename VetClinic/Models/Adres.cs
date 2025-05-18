using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetClinic.Models
{
    [Table("adresy")]
    internal class Adres
    {
        [Key] 
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Miasto { get; set; }

        [Required]
        [StringLength(50)]
        public string Ulica { get; set; }

        [Required]
        public int Nr_ulicy { get; set; }
        public int? Nr_lokalu { get; set; }
    }
}
