﻿// <auto-generated />
using System;
using DemoWeb.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DemoWeb.Migrations
{
    [DbContext(typeof(HocSinhContext))]
    partial class HocSinhContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DemoWeb.Models.HocSinh", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Hoten")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("LopId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("LopId");

                    b.ToTable("HocSinhs");
                });

            modelBuilder.Entity("DemoWeb.Models.Lop", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Siso")
                        .HasColumnType("int");

                    b.Property<string>("Tenlop")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Lops");
                });

            modelBuilder.Entity("DemoWeb.Models.HocSinh", b =>
                {
                    b.HasOne("DemoWeb.Models.Lop", "Lop")
                        .WithMany("HocSinhs")
                        .HasForeignKey("LopId");

                    b.Navigation("Lop");
                });

            modelBuilder.Entity("DemoWeb.Models.Lop", b =>
                {
                    b.Navigation("HocSinhs");
                });
#pragma warning restore 612, 618
        }
    }
}
