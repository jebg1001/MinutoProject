using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MinutosProject.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [System.ComponentModel.DataAnnotations.Schema.DatabaseGenerat‌ed(System.ComponentM‌​odel.DataAnnotations‌​.Schema.DatabaseGeneratedOp‌​tion.None)]
        
        [Column("id")]
        public int id { get; set; }
        [Column("email")]
        public string email { get; set; }

        [Column("password")]
        public string password { get; set; }
    }
}