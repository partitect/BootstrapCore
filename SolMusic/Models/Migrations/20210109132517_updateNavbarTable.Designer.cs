﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SolMusic.Models;

namespace SolMusic.Models.Migrations
{
    [DbContext(typeof(MyContext))]
    [Migration("20210109132517_updateNavbarTable")]
    partial class updateNavbarTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.1");

            modelBuilder.Entity("SolMusic.Models.Navbar", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("link")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("menu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("parentId")
                        .HasColumnType("int");

                    b.Property<int>("type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Pages");
                });
#pragma warning restore 612, 618
        }
    }
}
