using System.ComponentModel.DataAnnotations.Schema;

namespace MinutosProject.Models
{
    [Table("Auxiliar")]
    public class Auxiliar
    {
        [Column("id")]
        public int ID { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }
    }
}