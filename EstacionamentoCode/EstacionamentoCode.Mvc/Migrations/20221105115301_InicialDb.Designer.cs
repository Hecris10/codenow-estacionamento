﻿// <auto-generated />
using System;
using EstacionamentoCode.Infra.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace EstacionamentoCode.Mvc.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20221105115301_InicialDb")]
    partial class InicialDb
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("EstacionamentoCode.Dominio.Models.Estacionamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("PrecoHora")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrecoInicial")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("QtdeVagasTotais")
                        .HasColumnType("int");

                    b.Property<int>("Tolerancia")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Estacionamentos");
                });

            modelBuilder.Entity("EstacionamentoCode.Dominio.Models.Veiculo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataAlteracao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataCadastro")
                        .HasColumnType("datetime2");

                    b.Property<int?>("EstacionamentoId")
                        .HasColumnType("int");

                    b.Property<int>("HoraEntrada")
                        .HasColumnType("int");

                    b.Property<int>("HoraSaida")
                        .HasColumnType("int");

                    b.Property<string>("Placa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TempoEstacionado")
                        .HasColumnType("int");

                    b.Property<int>("TipoDeVeiculo")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("EstacionamentoId");

                    b.ToTable("Veiculos");
                });

            modelBuilder.Entity("EstacionamentoCode.Dominio.Models.Veiculo", b =>
                {
                    b.HasOne("EstacionamentoCode.Dominio.Models.Estacionamento", null)
                        .WithMany("Veiculos")
                        .HasForeignKey("EstacionamentoId");
                });

            modelBuilder.Entity("EstacionamentoCode.Dominio.Models.Estacionamento", b =>
                {
                    b.Navigation("Veiculos");
                });
#pragma warning restore 612, 618
        }
    }
}
