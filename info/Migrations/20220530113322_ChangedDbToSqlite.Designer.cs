﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using info.Models;

#nullable disable

namespace info.Migrations
{
    [DbContext(typeof(infoDbContext))]
    [Migration("20220530113322_ChangedDbToSqlite")]
    partial class ChangedDbToSqlite
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "6.0.2");

            modelBuilder.Entity("info.Models.infomed", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<int>("DisplayOrder")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Expiry")
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("TEXT");

                    b.Property<string>("illness")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("medicinetype")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("sales")
                        .HasColumnType("INTEGER");

                    b.Property<int>("stock")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("infomeds");
                });
#pragma warning restore 612, 618
        }
    }
}
