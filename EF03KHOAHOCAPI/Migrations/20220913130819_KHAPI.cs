using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace EF03KHOAHOCAPI.Migrations
{
    public partial class KHAPI : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "KhoaHocs",
                columns: table => new
                {
                    KhoaHocId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TenKH = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: true),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Hocphi = table.Column<int>(type: "int", nullable: false),
                    Ngaybatdau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ngaykethuc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhoaHocs", x => x.KhoaHocId);
                });

            migrationBuilder.CreateTable(
                name: "HocViens",
                columns: table => new
                {
                    HocvienId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Hoten = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Ngaysinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Quequan = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Diachi = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dienthoai = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KhoaHocId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HocViens", x => x.HocvienId);
                    table.ForeignKey(
                        name: "FK_HocViens_KhoaHocs_KhoaHocId",
                        column: x => x.KhoaHocId,
                        principalTable: "KhoaHocs",
                        principalColumn: "KhoaHocId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "NgayHocs",
                columns: table => new
                {
                    NgayhocId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Noidung = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ghichu = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    KhoaHocId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NgayHocs", x => x.NgayhocId);
                    table.ForeignKey(
                        name: "FK_NgayHocs_KhoaHocs_KhoaHocId",
                        column: x => x.KhoaHocId,
                        principalTable: "KhoaHocs",
                        principalColumn: "KhoaHocId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_HocViens_KhoaHocId",
                table: "HocViens",
                column: "KhoaHocId");

            migrationBuilder.CreateIndex(
                name: "IX_NgayHocs_KhoaHocId",
                table: "NgayHocs",
                column: "KhoaHocId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "HocViens");

            migrationBuilder.DropTable(
                name: "NgayHocs");

            migrationBuilder.DropTable(
                name: "KhoaHocs");
        }
    }
}
