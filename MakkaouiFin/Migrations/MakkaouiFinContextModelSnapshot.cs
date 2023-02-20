﻿// <auto-generated />
using System;
using MakkaouiFin.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MakkaouiFin.Migrations
{
    [DbContext(typeof(MakkaouiFinContext))]
    partial class MakkaouiFinContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.3")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MakkaouiFin.Models.LignePanier", b =>
                {
                    b.Property<int>("LignePanierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("LignePanierID"));

                    b.Property<int>("PanierID")
                        .HasColumnType("int");

                    b.Property<int>("ProduitID")
                        .HasColumnType("int");

                    b.Property<int>("Quantite")
                        .HasColumnType("int");

                    b.HasKey("LignePanierID");

                    b.ToTable("LignePanier");
                });

            modelBuilder.Entity("MakkaouiFin.Models.Panier", b =>
                {
                    b.Property<int>("PanierID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PanierID"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("PanierID");

                    b.ToTable("Panier");
                });

            modelBuilder.Entity("MakkaouiFin.Models.Produit", b =>
                {
                    b.Property<int>("ProduitID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ProduitID"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<float?>("Price")
                        .HasColumnType("real");

                    b.HasKey("ProduitID");

                    b.ToTable("Produit");
                });
#pragma warning restore 612, 618
        }
    }
}
