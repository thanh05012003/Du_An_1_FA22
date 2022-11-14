using Microsoft.EntityFrameworkCore.Migrations;

namespace _1.BUS.Migrations
{
    public partial class Bugcf211022 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonCT_HoaDon_MaHD",
                table: "HoaDonCT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HoaDonCT",
                table: "HoaDonCT");

            migrationBuilder.AlterColumn<string>(
                name: "MaHD",
                table: "HoaDonCT",
                type: "varchar(20)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "varchar(20)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_HoaDonCT",
                table: "HoaDonCT",
                columns: new[] { "MaSP", "MaHD" });

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonCT_HoaDon_MaHD",
                table: "HoaDonCT",
                column: "MaHD",
                principalTable: "HoaDon",
                principalColumn: "Ma",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_HoaDonCT_HoaDon_MaHD",
                table: "HoaDonCT");

            migrationBuilder.DropPrimaryKey(
                name: "PK_HoaDonCT",
                table: "HoaDonCT");

            migrationBuilder.AlterColumn<string>(
                name: "MaHD",
                table: "HoaDonCT",
                type: "varchar(20)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(20)");

            migrationBuilder.AddPrimaryKey(
                name: "PK_HoaDonCT",
                table: "HoaDonCT",
                column: "MaSP");

            migrationBuilder.AddForeignKey(
                name: "FK_HoaDonCT_HoaDon_MaHD",
                table: "HoaDonCT",
                column: "MaHD",
                principalTable: "HoaDon",
                principalColumn: "Ma",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
