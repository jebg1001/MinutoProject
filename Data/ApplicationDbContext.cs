  
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace MinutosProject.Data{

    public class ApplicationDbContext : DbContext{

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<MinutosProject.Models.Auxiliar> Auxiliares { get; set; }
        public DbSet<MinutosProject.Models.Empresa> Empresas { get; set; }
        public DbSet<MinutosProject.Models.Envio> Envios { get; set; }
        public DbSet<MinutosProject.Models.Courier> Couriers { get; set; }
        public DbSet<MinutosProject.Models.TipoServicio> Servicios { get; set; }
        public DbSet<MinutosProject.Models.TipoMercaderia> Mercaderias { get; set; }
        public DbSet<MinutosProject.Models.Usuario> Usuarios { get; set; }
        public DbSet<MinutosProject.Models.Enrutamiento> Enrutamientos { get; set; }
    }
}