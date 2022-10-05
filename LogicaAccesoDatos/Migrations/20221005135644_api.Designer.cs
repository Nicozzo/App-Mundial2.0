﻿// <auto-generated />
using System;
using LogicaAccesoDatos.BaseDatos;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace LogicaAccesoDatos.Migrations
{
    [DbContext(typeof(LibreriaContext))]
    [Migration("20221005135644_api")]
    partial class api
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.28")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

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

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Telefono")
                        .HasColumnType("int");

                    b.Property<int?>("paisId")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("paisId");

                    b.ToTable("Seleccion");
                });

            modelBuilder.Entity("LogicaNegocio.Dominio.Pais", b =>
                {
                    b.HasOne("LogicaNegocio.Dominio.Region", "Region")
                        .WithMany("Paises")
                        .HasForeignKey("IdRegion")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("LogicaNegocio.Dominio.Seleccion", b =>
                {
                    b.HasOne("LogicaNegocio.Dominio.Pais", "pais")
                        .WithMany()
                        .HasForeignKey("paisId");
                });
#pragma warning restore 612, 618
        }
    }
}
