using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using LogicaNegocio.Dominio;

namespace LogicaAccesoDatos.BaseDatos
{
    public class LibreriaContext : DbContext
    {
        public DbSet<Pais> Paises { get; set; }
       // public DbSet<Eliminatoria> Eliminatorias { get; set; }

       // public DbSet<Fase> Fases { get; set; }
//        public DbSet<Grupo> Grupos { get; set; }

       public DbSet<Region> Regiones { get; set; }
       // public DbSet<Rol> Roles { get; set; }
       public DbSet<User> Users { get; set; }

      //  public DbSet<Partido> Partidos { get; set; }

        public DbSet<Seleccion> Seleccion { get; set; }

        public DbSet<Grupo> grupo { get; set; }
        public DbSet<SeleccionPartido> SeleccionPartidos { get; set; }
        public DbSet<ResultadoPartido> ResultadoPartidos { get; set; }
        public DbSet<Incidencia>  incidencias { get; set; }
        public DbSet<Partido> Partido { get; set; }
     



        public LibreriaContext(DbContextOptions<LibreriaContext> opciones) : base(opciones)
        {
            DbSet<Pais> Paises;
          //  DbSet<Eliminatoria> Eliminatorias;
          //  DbSet<Fase> Fases;
          //  DbSet<Grupo> Grupos;
           DbSet<Region> Regiones;
            DbSet<User> Users;

            DbSet<Incidencia> incidencias;
            // DbSet<Partido> Partidos;
            DbSet<Seleccion> Selecciones;

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pais>().HasIndex(pais => pais.Nombre).IsUnique(true);
            modelBuilder.Entity<Pais>().HasIndex(pais => pais.CodigoIso).IsUnique(true);

            modelBuilder.Entity<Region>().HasIndex(region => region.Nombre).IsUnique(true);

            modelBuilder.Entity<User>().HasIndex(user => user.Email).IsUnique(true);


            modelBuilder.Entity<Pais>().HasOne(pa => pa.Region).WithMany(Region => Region.Paises);

       

        }
    }
}
