﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Parcial1_JoseMiguel.DAL;

#nullable disable

namespace Parcial1_JoseMiguel.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20230605231111_Inicial")]
    partial class Inicial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Parcial1_JoseMiguel.Models.Ingresos", b =>
                {
                    b.Property<int>("IngresoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Concepto")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Fecha")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Monto")
                        .HasColumnType("INTEGER");

                    b.HasKey("IngresoId");

                    b.ToTable("Ingresos");
                });
#pragma warning restore 612, 618
        }
    }
}