using System.ComponentModel.DataAnnotations.Schema;

namespace MinutosProject.Models
{
    [Table("Empresa")]
    public class Empresa
    {
        [Column("id")]
        public int ID { get; set; }

        [Column("nombre")]
        public string Nombre { get; set; }
    }
}