﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using WebPostgreSQL.Models;

#nullable disable

namespace WebPostgreSQL.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20220910033037_CRiacao-Inicial")]
    partial class CRiacaoInicial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("WebPostgreSQL.Models.Cliente", b =>
                {
                    b.Property<int>("CodigoCliente")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("Codigo");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CodigoCliente"));

                    b.Property<string>("CNPJ")
                        .HasColumnType("text")
                        .HasColumnName("CNPJ");

                    b.Property<DateTime?>("DataCadastro")
                        .HasColumnType("timestamp with time zone")
                        .HasColumnName("DataCadastro");

                    b.Property<string>("Endereco")
                        .HasColumnType("text")
                        .HasColumnName("Endereco");

                    b.Property<string>("Nome")
                        .HasColumnType("text")
                        .HasColumnName("Nome");

                    b.Property<string>("Telefone")
                        .HasColumnType("text")
                        .HasColumnName("Telefone");

                    b.HasKey("CodigoCliente");

                    b.ToTable("CLIENTES");
                });
#pragma warning restore 612, 618
        }
    }
}