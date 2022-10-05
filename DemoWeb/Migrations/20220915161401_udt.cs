using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace DemoWeb.Migrations
{
    public partial class udt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HocSinhs_Lops_LopId",
                table: "HocSinhs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgaySinh",
                table: "HocSinhs",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.AlterColumn<int>(
                name: "LopId",
                table: "HocSinhs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinhs_Lops_LopId",
                table: "HocSinhs",
                column: "LopId",
                principalTable: "Lops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HocSinhs_Lops_LopId",
                table: "HocSinhs");

            migrationBuilder.AlterColumn<DateTime>(
                name: "NgaySinh",
                table: "HocSinhs",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "LopId",
                table: "HocSinhs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_HocSinhs_Lops_LopId",
                table: "HocSinhs",
                column: "LopId",
                principalTable: "Lops",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
