using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Migrar.Migrations
{
    /// <inheritdoc />
    public partial class sixthmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 3,
                column: "foto_destino",
                value: "https://images.pexels.com/photos/2876407/pexels-photo-2876407.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 3,
                column: "foto_destino",
                value: "https://images.pexels.com/photos/351283/pexels-photo-351283.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1");
        }
    }
}
