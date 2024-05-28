﻿// <auto-generated />
using System;
using CoreDepartman.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace CoreDepartman.Migrations
{
    [DbContext(typeof(Context))]
    [Migration("20240527184535_migration3")]
    partial class migration3
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("CoreDepartman.Models.departmanlar", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Aciklama")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("departmanAd")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.ToTable("departmanlars");
                });

            modelBuilder.Entity("CoreDepartman.Models.personel", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ad")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("departmentid")
                        .HasColumnType("int");

                    b.Property<string>("sehir")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("soyad")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("id");

                    b.HasIndex("departmentid");

                    b.ToTable("personels");
                });

            modelBuilder.Entity("CoreDepartman.Models.personel", b =>
                {
                    b.HasOne("CoreDepartman.Models.departmanlar", "department")
                        .WithMany("personels")
                        .HasForeignKey("departmentid");
                });
#pragma warning restore 612, 618
        }
    }
}