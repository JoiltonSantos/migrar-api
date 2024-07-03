using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Migrar.Migrations
{
    /// <inheritdoc />
    public partial class fourthmigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "destinos",
                columns: new[] { "id_destino", "foto_destino", "local_destino", "valor_destino" },
                values: new object[,]
                {
                    { 1, "https://images.pexels.com/photos/1850619/pexels-photo-1850619.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Paris, França", 2000.00m },
                    { 2, "https://images.pexels.com/photos/2341830/pexels-photo-2341830.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Tóquio, Japão", 2500.00m },
                    { 3, "https://images.pexels.com/photos/3648269/pexels-photo-3648269.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Rio de Janeiro, Brasil", 1000.00m },
                    { 4, "https://images.pexels.com/photos/40142/new-york-skyline-manhattan-hudson-40142.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Nova York, EUA", 3000.00m },
                    { 5, "https://images.pexels.com/photos/2193300/pexels-photo-2193300.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Sydney, Austrália", 2800.00m },
                    { 6, "https://images.pexels.com/photos/136721/pexels-photo-136721.jpeg?auto=compress&cs=tinysrgb&w=1260&h=750&dpr=1", "Cidade do Cabo, África do Sul", 2200.00m }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "destinos",
                keyColumn: "id_destino",
                keyValue: 6);
        }
    }
}
