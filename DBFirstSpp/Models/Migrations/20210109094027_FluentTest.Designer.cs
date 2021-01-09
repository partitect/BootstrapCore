﻿// <auto-generated />
using System;
using DBFirstSpp.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DBFirstSpp.Models.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20210109094027_FluentTest")]
    partial class FluentTest
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("DBFirstSpp.Models.Category", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("Varchar(100)");

                    b.HasKey("ID");

                    b.ToTable("Category");
                });

            modelBuilder.Entity("DBFirstSpp.Models.Urunler", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int?>("CategoryID")
                        .HasColumnType("int");

                    b.Property<int>("DisplayIndex")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("Varchar(100)");

                    b.Property<decimal?>("Price")
                        .HasColumnType("decimal(18,3)");

                    b.HasKey("ID");

                    b.HasIndex("CategoryID");

                    b.ToTable("Uruns");
                });

            modelBuilder.Entity("DBFirstSpp.Models.Urunler", b =>
                {
                    b.HasOne("DBFirstSpp.Models.Category", "Category")
                        .WithMany("Uruns")
                        .HasForeignKey("CategoryID")
                        .OnDelete(DeleteBehavior.SetNull);

                    b.Navigation("Category");
                });

            modelBuilder.Entity("DBFirstSpp.Models.Category", b =>
                {
                    b.Navigation("Uruns");
                });
#pragma warning restore 612, 618
        }
    }
}
