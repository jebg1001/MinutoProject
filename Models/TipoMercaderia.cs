using System.ComponentModel.DataAnnotations.Schema;

namespace MinutosProject.Models
{
    [Table("TipoMercaderia")]
    public class TipoMercaderia
    {
        [Column("id")]
        public int ID { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }
    }
}