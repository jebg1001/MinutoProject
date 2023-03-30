using System.ComponentModel.DataAnnotations.Schema;

namespace MinutosProject.Models
{
    [Table("TipoServicio")]
    public class TipoServicio
    {
        [Column("id")]
        public int ID { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }
    }
}