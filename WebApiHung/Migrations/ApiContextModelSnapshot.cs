﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using WebApiHung.Context;

namespace WebApiHung.Migrations
{
    [DbContext(typeof(ApiContext))]
    partial class ApiContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.17")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("WebApiHung.Model.ChiTietHoaDon", b =>
                {
                    b.Property<int>("chietiethoadonid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("DonViTinh")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HoaDonid")
                        .HasColumnType("int");

                    b.Property<int>("SanPhamid")
                        .HasColumnType("int");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<float?>("ThanhTien")
                        .HasColumnType("real");

                    b.HasKey("chietiethoadonid");

                    b.HasIndex("HoaDonid");

                    b.HasIndex("SanPhamid");

                    b.ToTable("ChiTietHoaDons");
                });

            modelBuilder.Entity("WebApiHung.Model.HoaDon", b =>
                {
                    b.Property<int>("HoanDonid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("GhiChu")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("KhachHangid")
                        .HasColumnType("int");

                    b.Property<string>("MaGiaoDich")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenHoaDon")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("ThoiGianCapNhap")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("ThoiGianTao")
                        .HasColumnType("datetime2");

                    b.Property<float?>("TongTien")
                        .HasColumnType("real");

                    b.HasKey("HoanDonid");

                    b.HasIndex("KhachHangid");

                    b.ToTable("HoaDons");
                });

            modelBuilder.Entity("WebApiHung.Model.KhachHang", b =>
                {
                    b.Property<int>("KhachHangid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("HoTen")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SoDienThoai")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("KhachHangid");

                    b.ToTable("KhachHangs");
                });

            modelBuilder.Entity("WebApiHung.Model.LoaiSanPham", b =>
                {
                    b.Property<int>("Loaisanphamid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("TenLoaiSanPham")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Loaisanphamid");

                    b.ToTable("LoaiSanPhams");
                });

            modelBuilder.Entity("WebApiHung.Model.SanPham", b =>
                {
                    b.Property<int>("Sanphamid")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<bool>("DaHetHan")
                        .HasColumnType("bit");

                    b.Property<float>("GiaThanh")
                        .HasColumnType("real");

                    b.Property<string>("KyHieuSanPham")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Loaisanphamid")
                        .HasColumnType("int");

                    b.Property<string>("MoTa")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("NgayHetHan")
                        .HasColumnType("datetime2");

                    b.Property<int?>("SoLuongTonKho")
                        .HasColumnType("int");

                    b.Property<string>("TenSanPham")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Sanphamid");

                    b.HasIndex("Loaisanphamid");

                    b.ToTable("SanPhams");
                });

            modelBuilder.Entity("WebApiHung.Model.ChiTietHoaDon", b =>
                {
                    b.HasOne("WebApiHung.Model.HoaDon", "HoaDon")
                        .WithMany("ChiTietHoaDons")
                        .HasForeignKey("HoaDonid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("WebApiHung.Model.SanPham", "SanPham")
                        .WithMany()
                        .HasForeignKey("SanPhamid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("HoaDon");

                    b.Navigation("SanPham");
                });

            modelBuilder.Entity("WebApiHung.Model.HoaDon", b =>
                {
                    b.HasOne("WebApiHung.Model.KhachHang", "KhachHang")
                        .WithMany()
                        .HasForeignKey("KhachHangid");

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("WebApiHung.Model.SanPham", b =>
                {
                    b.HasOne("WebApiHung.Model.LoaiSanPham", "LoaiSanPham")
                        .WithMany()
                        .HasForeignKey("Loaisanphamid")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiSanPham");
                });

            modelBuilder.Entity("WebApiHung.Model.HoaDon", b =>
                {
                    b.Navigation("ChiTietHoaDons");
                });
#pragma warning restore 612, 618
        }
    }
}
