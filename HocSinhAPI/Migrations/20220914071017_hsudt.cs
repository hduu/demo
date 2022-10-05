using Microsoft.EntityFrameworkCore.Migrations;

namespace HocSinhAPI.Migrations
{
    public partial class hsudt : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HocSinhs_Lops_LopId",
                table: "HocSinhs");

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
                principalColumn: "LopId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HocSinhs_Lops_LopId",
                table: "HocSinhs");

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
                principalColumn: "LopId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
