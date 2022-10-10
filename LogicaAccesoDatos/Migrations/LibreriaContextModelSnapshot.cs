﻿// <auto-generated />
using System;
using LogicaAccesoDatos.BaseDatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LogicaAccesoDatos.Migrations
{
    [DbContext(typeof(LibreriaContext))]
    partial class LibreriaContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("LogicaNegocio.Dominio.Grupo", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("Grupo");
                });

            modelBuilder.Entity("LogicaNegocio.Dominio.Pais", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CodigoIso")
                        .IsRequired()
                        .HasColumnType("nvarchar(3)")
                        .HasMaxLength(3);

                    b.Property<int>("IdRegion")
                        .HasColumnType("int");

                    b.Property<string>("Imagen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("Pbi")
                        .HasColumnType("int");

                    b.Property<int>("Poblacion")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CodigoIso")
                        .IsUnique();

                    b.HasIndex("IdRegion");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Pais");
                });

            modelBuilder.Entity("LogicaNegocio.Dominio.Partido", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("date")
                        .HasColumnType("datetime2");

                    b.HasKey("ID");

                    b.ToTable("Partido");
                });

            modelBuilder.Entity("LogicaNegocio.Dominio.Region", b =>
                {
                    b.Property<int>("IdRegion")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdRegion");

                    b.HasIndex("Nombre")
                        .IsUnique();

                    b.ToTable("Regiones");
                });

            modelBuilder.Entity("LogicaNegocio.Dominio.ResultadoPartido", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amarrillas")
                        .HasColumnType("int");

                    b.Property<int>("dobleAmarrilla")
                        .HasColumnType("int");

                    b.Property<int>("goles")
                        .HasColumnType("int");

                    b.Property<int>("idseleccionPartido")
                        .HasColumnType("int");

                    b.Property<int>("rojas")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("idseleccionPartido");

                    b.ToTable("ResultadoPartido");
                });

            modelBuilder.Entity("LogicaNegocio.Dominio.Seleccion", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CantApost")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdGrupo")
                        .HasColumnType("int");

                    b.Property<int>("IdPais")
                        .HasColumnType("int");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IdGrupo");

                    b.HasIndex("IdPais");

                    b.ToTable("Seleccion");
                });

            modelBuilder.Entity("LogicaNegocio.Dominio.SeleccionPartido", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("idpartido")
                        .HasColumnType("int");

                    b.Property<int>("idseleccion")
                        .HasColumnType("int");

                    b.HasKey("id");

                    b.HasIndex("idpartido");

                    b.HasIndex("idseleccion");

                    b.ToTable("SeleccionPartido");
                });

            modelBuilder.Entity("LogicaNegocio.Dominio.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Rol")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("Email")
                        .IsUnique()
                        .HasFilter("[Email] IS NOT NULL");

                    b.ToTable("Usuarios");
                });

            modelBuilder.Entity("LogicaNegocio.Dominio.Pais", b =>
                {
                    b.HasOne("LogicaNegocio.Dominio.Region", "Region")
                        .WithMany("Paises")
                        .HasForeignKey("IdRegion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LogicaNegocio.Dominio.ResultadoPartido", b =>
                {
                    b.HasOne("LogicaNegocio.Dominio.SeleccionPartido", "seleccionPartido")
                        .WithMany()
                        .HasForeignKey("idseleccionPartido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LogicaNegocio.Dominio.Seleccion", b =>
                {
                    b.HasOne("LogicaNegocio.Dominio.Grupo", "Grupo")
                        .WithMany()
                        .HasForeignKey("IdGrupo")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LogicaNegocio.Dominio.Pais", "Pais")
                        .WithMany()
                        .HasForeignKey("IdPais")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LogicaNegocio.Dominio.SeleccionPartido", b =>
                {
                    b.HasOne("LogicaNegocio.Dominio.Partido", "partido")
                        .WithMany()
                        .HasForeignKey("idpartido")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LogicaNegocio.Dominio.Seleccion", "Seleccion")
                        .WithMany()
                        .HasForeignKey("idseleccion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
