﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using info.Models;

#nullable disable

namespace info.Migrations
{
    [DbContext(typeof(infoDbContext))]
    partial class infoDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("info.Models.infomed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<DateTime>("Expiry")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<string>("illness")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("medicinetype")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("sales")
                        .HasColumnType("int");

                    b.Property<int>("stock")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("infomeds");
                });
#pragma warning restore 612, 618
        }
    }
}
