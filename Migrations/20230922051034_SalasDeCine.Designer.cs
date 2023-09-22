﻿// <auto-generated />
using System;
using EFCore_Peliculas;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using NetTopologySuite.Geometries;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace EFCore_Peliculas.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230922051034_SalasDeCine")]
    partial class SalasDeCine
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.HasPostgresExtension(modelBuilder, "postgis");
            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("EFCore_Peliculas.Cine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("character varying(150)");

                    b.Property<Point>("Ubicacion")
                        .HasColumnType("geometry");

                    b.HasKey("Id");

                    b.ToTable("Cines");
                });

            modelBuilder.Entity("EFCore_Peliculas.CineOferta", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CineId")
                        .HasColumnType("integer");

                    b.Property<DateTime>("FechaFin")
                        .HasColumnType("date");

                    b.Property<DateTime>("FechaInicio")
                        .HasColumnType("date");

                    b.Property<decimal>("PorcentajeDescuento")
                        .HasPrecision(5, 2)
                        .HasColumnType("numeric(5,2)");

                    b.HasKey("Id");

                    b.HasIndex("CineId")
                        .IsUnique();

                    b.ToTable("CineOfertas");
                });

            modelBuilder.Entity("EFCore_Peliculas.Entities.Actor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Biografia")
                        .HasColumnType("text");

                    b.Property<DateTime?>("FechaNacimiento")
                        .HasColumnType("date");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("character varying(100)");

                    b.HasKey("Id");

                    b.ToTable("Actores");
                });

            modelBuilder.Entity("EFCore_Peliculas.Entities.Genero", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.HasKey("Id");

                    b.ToTable("Generos");
                });

            modelBuilder.Entity("EFCore_Peliculas.Pelicula", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<bool>("EnCartelera")
                        .HasColumnType("boolean");

                    b.Property<DateTime>("FechaEstreno")
                        .HasColumnType("date");

                    b.Property<string>("PosterURL")
                        .HasMaxLength(500)
                        .IsUnicode(true)
                        .HasColumnType("character varying(500)");

                    b.Property<string>("Titulo")
                        .IsRequired()
                        .HasMaxLength(250)
                        .HasColumnType("character varying(250)");

                    b.HasKey("Id");

                    b.ToTable("Peliculas");
                });

            modelBuilder.Entity("EFCore_Peliculas.SalaDeCine", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<int>("CineId")
                        .HasColumnType("integer");

                    b.Property<decimal>("Precio")
                        .HasPrecision(9, 2)
                        .HasColumnType("numeric(9,2)");

                    b.Property<int?>("SalaDeCineId")
                        .HasColumnType("integer");

                    b.Property<int>("TipoSalaDeCine")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasDefaultValue(1);

                    b.HasKey("Id");

                    b.HasIndex("SalaDeCineId");

                    b.ToTable("SalasDeCine");
                });

            modelBuilder.Entity("GeneroPelicula", b =>
                {
                    b.Property<int>("GenerosId")
                        .HasColumnType("integer");

                    b.Property<int>("PeliculasId")
                        .HasColumnType("integer");

                    b.HasKey("GenerosId", "PeliculasId");

                    b.HasIndex("PeliculasId");

                    b.ToTable("GeneroPelicula");
                });

            modelBuilder.Entity("PeliculaSalaDeCine", b =>
                {
                    b.Property<int>("PeliculasId")
                        .HasColumnType("integer");

                    b.Property<int>("SalasDeCineId")
                        .HasColumnType("integer");

                    b.HasKey("PeliculasId", "SalasDeCineId");

                    b.HasIndex("SalasDeCineId");

                    b.ToTable("PeliculaSalaDeCine");
                });

            modelBuilder.Entity("EFCore_Peliculas.CineOferta", b =>
                {
                    b.HasOne("EFCore_Peliculas.Cine", null)
                        .WithOne("CineOferta")
                        .HasForeignKey("EFCore_Peliculas.CineOferta", "CineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCore_Peliculas.SalaDeCine", b =>
                {
                    b.HasOne("EFCore_Peliculas.SalaDeCine", null)
                        .WithMany("SalasDeCine")
                        .HasForeignKey("SalaDeCineId");
                });

            modelBuilder.Entity("GeneroPelicula", b =>
                {
                    b.HasOne("EFCore_Peliculas.Entities.Genero", null)
                        .WithMany()
                        .HasForeignKey("GenerosId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCore_Peliculas.Pelicula", null)
                        .WithMany()
                        .HasForeignKey("PeliculasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("PeliculaSalaDeCine", b =>
                {
                    b.HasOne("EFCore_Peliculas.Pelicula", null)
                        .WithMany()
                        .HasForeignKey("PeliculasId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("EFCore_Peliculas.SalaDeCine", null)
                        .WithMany()
                        .HasForeignKey("SalasDeCineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("EFCore_Peliculas.Cine", b =>
                {
                    b.Navigation("CineOferta");
                });

            modelBuilder.Entity("EFCore_Peliculas.SalaDeCine", b =>
                {
                    b.Navigation("SalasDeCine");
                });
#pragma warning restore 612, 618
        }
    }
}
