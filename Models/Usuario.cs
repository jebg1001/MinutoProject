using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MinutosProject.Models
{
    [Table("Usuario")]
    public class Usuario
    {
        [Key]
        [Column("email")]
        public string email { get; set; }

        [Column("password")]
        public string password { get; set; }
    }
}