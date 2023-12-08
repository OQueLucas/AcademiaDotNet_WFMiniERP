﻿// <auto-generated />
using System;
using AcademiaDotNet_WFMiniERP.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace AcademiaDotNet_WFMiniERP.Migrations
{
    [DbContext(typeof(Contexto))]
    [Migration("20231208153741_change-value-preco-to-decimal")]
    partial class changevalueprecotodecimal
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("AcademiaDotNet_WFMiniERP.DataModels.Cliente", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CPF")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("AcademiaDotNet_WFMiniERP.DataModels.Fornecedor", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("CNPJ")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RazaoSocial")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Fornecedores");
                });

            modelBuilder.Entity("AcademiaDotNet_WFMiniERP.DataModels.ItemNota", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NotaID")
                        .HasColumnType("int");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(8,2)");

                    b.Property<int>("ProdutoID")
                        .HasColumnType("int");

                    b.Property<int>("Quantidade")
                        .HasColumnType("int");

                    b.Property<decimal>("ValorTotal")
                        .HasColumnType("decimal(10,2)");

                    b.HasKey("ID");

                    b.HasIndex("NotaID");

                    b.HasIndex("ProdutoID");

                    b.ToTable("ItemNota");
                });

            modelBuilder.Entity("AcademiaDotNet_WFMiniERP.DataModels.Nota", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("ClienteID")
                        .HasColumnType("int");

                    b.Property<DateTime>("DataEmissao")
                        .HasColumnType("datetime2");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("ClienteID");

                    b.ToTable("Notas");
                });

            modelBuilder.Entity("AcademiaDotNet_WFMiniERP.DataModels.Produto", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"), 1L, 1);

                    b.Property<int>("FornecedorID")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Preco")
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("ID");

                    b.HasIndex("FornecedorID");

                    b.ToTable("Produtos");
                });

            modelBuilder.Entity("AcademiaDotNet_WFMiniERP.DataModels.ItemNota", b =>
                {
                    b.HasOne("AcademiaDotNet_WFMiniERP.DataModels.Nota", "Nota")
                        .WithMany("itens")
                        .HasForeignKey("NotaID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("AcademiaDotNet_WFMiniERP.DataModels.Produto", "Produto")
                        .WithMany()
                        .HasForeignKey("ProdutoID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Nota");

                    b.Navigation("Produto");
                });

            modelBuilder.Entity("AcademiaDotNet_WFMiniERP.DataModels.Nota", b =>
                {
                    b.HasOne("AcademiaDotNet_WFMiniERP.DataModels.Cliente", "Cliente")
                        .WithMany("Notas")
                        .HasForeignKey("ClienteID")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("Cliente");
                });

            modelBuilder.Entity("AcademiaDotNet_WFMiniERP.DataModels.Produto", b =>
                {
                    b.HasOne("AcademiaDotNet_WFMiniERP.DataModels.Fornecedor", "Fornecedor")
                        .WithMany("Produtos")
                        .HasForeignKey("FornecedorID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Fornecedor");
                });

            modelBuilder.Entity("AcademiaDotNet_WFMiniERP.DataModels.Cliente", b =>
                {
                    b.Navigation("Notas");
                });

            modelBuilder.Entity("AcademiaDotNet_WFMiniERP.DataModels.Fornecedor", b =>
                {
                    b.Navigation("Produtos");
                });

            modelBuilder.Entity("AcademiaDotNet_WFMiniERP.DataModels.Nota", b =>
                {
                    b.Navigation("itens");
                });
#pragma warning restore 612, 618
        }
    }
}
