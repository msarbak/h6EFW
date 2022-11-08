using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace h6EFW.Migrations
{
    /// <inheritdoc />
    public partial class kitapSayfasiEklendi : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "KitapSayfasi",
                table: "Kitaplar",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "KitapSayfasi",
                table: "Kitaplar");
        }
    }
}
