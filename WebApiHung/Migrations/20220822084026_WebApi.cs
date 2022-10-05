using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace WebApiHung.Migrations
{
    public partial class WebApi : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhachHangs",
                columns: table => new
                {
                    KhachHangid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoTen = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHangs", x => x.KhachHangid);
                });

            migrationBuilder.CreateTable(
                name: "LoaiSanPhams",
                columns: table => new
                {
                    Loaisanphamid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenLoaiSanPham = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiSanPhams", x => x.Loaisanphamid);
                });

            migrationBuilder.CreateTable(
                name: "HoaDons",
                columns: table => new
                {
                    HoanDonid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KhachHangid = table.Column<int>(type: "int", nullable: true),
                    TenHoaDon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MaGiaoDich = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GhiChu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThoiGianTao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ThoiGianCapNhap = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TongTien = table.Column<float>(type: "real", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDons", x => x.HoanDonid);
                    table.ForeignKey(
                        name: "FK_HoaDons_KhachHangs_KhachHangid",
                        column: x => x.KhachHangid,
                        principalTable: "KhachHangs",
                        principalColumn: "KhachHangid",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "SanPhams",
                columns: table => new
                {
                    Sanphamid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Loaisanphamid = table.Column<int>(type: "int", nullable: false),
                    TenSanPham = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GiaThanh = table.Column<float>(type: "real", nullable: false),
                    MoTa = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NgayHetHan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DaHetHan = table.Column<bool>(type: "bit", nullable: false),
                    SoLuongTonKho = table.Column<int>(type: "int", nullable: true),
                    KyHieuSanPham = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SanPhams", x => x.Sanphamid);
                    table.ForeignKey(
                        name: "FK_SanPhams_LoaiSanPhams_Loaisanphamid",
                        column: x => x.Loaisanphamid,
                        principalTable: "LoaiSanPhams",
                        principalColumn: "Loaisanphamid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ChiTietHoaDons",
                columns: table => new
                {
                    chietiethoadonid = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoaDonid = table.Column<int>(type: "int", nullable: false),
                    SanPhamid = table.Column<int>(type: "int", nullable: false),
                    SoLuong = table.Column<int>(type: "int", nullable: false),
                    DonViTinh = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ThanhTien = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ChiTietHoaDons", x => x.chietiethoadonid);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDons_HoaDons_HoaDonid",
                        column: x => x.HoaDonid,
                        principalTable: "HoaDons",
                        principalColumn: "HoanDonid",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ChiTietHoaDons_SanPhams_SanPhamid",
                        column: x => x.SanPhamid,
                        principalTable: "SanPhams",
                        principalColumn: "Sanphamid",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDons_HoaDonid",
                table: "ChiTietHoaDons",
                column: "HoaDonid");

            migrationBuilder.CreateIndex(
                name: "IX_ChiTietHoaDons_SanPhamid",
                table: "ChiTietHoaDons",
                column: "SanPhamid");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDons_KhachHangid",
                table: "HoaDons",
                column: "KhachHangid");

            migrationBuilder.CreateIndex(
                name: "IX_SanPhams_Loaisanphamid",
                table: "SanPhams",
                column: "Loaisanphamid");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ChiTietHoaDons");

            migrationBuilder.DropTable(
                name: "HoaDons");

            migrationBuilder.DropTable(
                name: "SanPhams");

            migrationBuilder.DropTable(
                name: "KhachHangs");

            migrationBuilder.DropTable(
                name: "LoaiSanPhams");
        }
    }
}
