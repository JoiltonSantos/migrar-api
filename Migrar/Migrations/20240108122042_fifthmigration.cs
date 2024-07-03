using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrar.Migrations
{
    /// <inheritdoc />
    public partial class fifthmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 3,
                column: "foto_destino",
                value: "https://images.pexels.com/photos/351283/pexels-photo-351283.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 3,
                column: "foto_destino",
                value: "https://images.pexels.com/photos/3648269/pexels-photo-3648269.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1");
        }
    }
}
