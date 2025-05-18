using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace VetClinic.Models
{
    [Table("zamowienia")]
    internal class Zamowienie
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int LekId { get; set; }

        [ForeignKey("LekId")]
        public Lek lek { get; set; }

        [Required]
        public int Ilosc {  get; set; }

    }
}
