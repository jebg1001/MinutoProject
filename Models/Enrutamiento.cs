using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MinutosProject.Models
{
    [Table("Enrutamiento")]
    public class Enrutamiento
    {
        [Key]
        public int id{get;set;}
        [Column("courier")]
        public string courier { get; set; }

        [Column("zona")]
        public string zona { get; set; }

        [Column("motivo_1")]
        public string motivo_1 { get; set; }

        [Column("motivo_2")]
        public string motivo_2 { get; set; }

        [Column("motivo_3")]
        public string motivo_3 { get; set; }
    }
}