using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MinutosProject.Models
{
    [Table("Envio")]
    public class Envio
    {
        [Column("id")]
        public string ID { get; set; }

        [Required]
        [Column("aux")]
        public int Auxiliar { get; set; }

        [Required]
        [Column("courier")]
        public int Courier { get; set; }

        [Required]
        [Column("courier")]
        public int Empresa { get; set; }

        [Required]
        [Column("courier")]
        public int TipoServicio { get; set; }

        [Required]
        [Column("courier")]
        public int TipoMercaderia { get; set; }

        [Column("fec_entre")]
        public DateTime FechaEntrega { get; set; }

        [Column("hr_llegada")]
        public DateTime HraLlegada { get; set; }

        [Column("hr_salida")]
        public DateTime? HraSalida { get; set; }

        [Column("respuesta")]
        public string Respuesta { get; set; }

    }
}