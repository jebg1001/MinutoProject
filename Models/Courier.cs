using System.ComponentModel.DataAnnotations.Schema;

namespace MinutosProject.Models
{
    [Table("Courier")]
    public class Courier
    {
        [Column("id")]
        public int ID { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }
    }
}