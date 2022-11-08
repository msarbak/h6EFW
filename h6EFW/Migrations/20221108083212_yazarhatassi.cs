using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace h6EFW.Migrations
{
    /// <inheritdoc />
    public partial class yazarhatassi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Yazarlar_YazarID",
                table: "Kitaplar");

            migrationBuilder.AlterColumn<int>(
                name: "YazarID",
                table: "Kitaplar",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<int>(
                name: "Yazar",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Yazarlar_YazarID",
                table: "Kitaplar",
                column: "YazarID",
                principalTable: "Yazarlar",
                principalColumn: "YazarID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Kitaplar_Yazarlar_YazarID",
                table: "Kitaplar");

            migrationBuilder.DropColumn(
                name: "Yazar",
                table: "Kitaplar");

            migrationBuilder.AlterColumn<int>(
                name: "YazarID",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Kitaplar_Yazarlar_YazarID",
                table: "Kitaplar",
                column: "YazarID",
                principalTable: "Yazarlar",
                principalColumn: "YazarID",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
