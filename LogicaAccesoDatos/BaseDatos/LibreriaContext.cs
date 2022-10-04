using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using LogicaNegocio.Dominio;

namespace LogicaAccesoDatos.BaseDatos
{
    public class LibreriaContext : DbContext
    {
        public DbSet<Pais> Paises { get; set; }
       // public DbSet<Fase> Fases { get; set; }
        public DbSet<Region> Region { get; set; }



        public LibreriaContext(DbContextOptions<LibreriaContext> opciones) : base(opciones)
        {
            DbSet<Pais> Paises;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          

            base.OnModelCreating(modelBuilder);
        }
    }
}
