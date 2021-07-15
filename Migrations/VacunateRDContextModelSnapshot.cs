﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Vacunate_RD;

namespace Vacunate_RD.Migrations
{
    [DbContext(typeof(VacunateRDContext))]
    partial class VacunateRDContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.7");

            modelBuilder.Entity("Vacunate_RD.Data.Provincia", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Provincias");
                });

            modelBuilder.Entity("Vacunate_RD.Data.Vacuna", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Nombre")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.ToTable("Vacunas");
                });

            modelBuilder.Entity("Vacunate_RD.Data.Vacunado", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Apellido")
                        .HasColumnType("TEXT");

                    b.Property<string>("Cedula")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fecha_Dosis")
                        .HasColumnType("TEXT");

                    b.Property<string>("Fecha_nacimiento")
                        .HasColumnType("TEXT");

                    b.Property<string>("Nombre")
                        .HasColumnType("TEXT");

                    b.Property<int>("Provincia")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Telefono")
                        .HasColumnType("TEXT");

                    b.Property<int>("TipoVacuna")
                        .HasColumnType("INTEGER");

                    b.Property<string>("signo_zodiaco")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Vacunados");
                });
#pragma warning restore 612, 618
        }
    }
}
