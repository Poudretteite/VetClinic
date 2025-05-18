using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace VetClinic.Models
{
    [Table("wizyty")]
    internal class Wizyta
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ZwierzeId { get; set; }

        [ForeignKey("ZwierzeId")]
        public Zwierze Zwierze { get; set; }

        [Required]
        public int LekarzId { get; set; }

        [ForeignKey("LekarzId")]
        public Lekarz Lekarz { get; set; }

        [Required]
        [StringLength(50)]
        public string Tryb { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime Data { get; set; }

        [Required]
        public string Opis { get; set; }

        public ICollection<Lek> Leki { get; set; } = new List<Lek>();

    }
}
