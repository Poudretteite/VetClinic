using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetClinic.Models
{
    [Table("leki")]
    internal class Lek
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string Nazwa { get; set; }

        [Required]
        public int Ilosc {  get; set; }

        public ICollection<Wizyta> Wizyty {  get; set; } = new List<Wizyta>();
    }
}
